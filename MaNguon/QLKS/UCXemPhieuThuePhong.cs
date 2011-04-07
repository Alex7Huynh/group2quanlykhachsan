using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QLKS
{
    public partial class UCXemPhieuThuePhong : UserControl
    {
        private List<PHONG> _arrPhong = new List<PHONG>();

        private List<List<PHIEUTHUE>> _cachePhieuThue = new List<List<PHIEUTHUE>>();

        private DateTime _beginDate;

        private DateTime _endDate;

        public void AddPhong(PHONG phong)
        {
            _arrPhong.Add(phong);
            _cachePhieuThue.Add(PHIEUTHUEBUS.LayDSPhieuThueTheoPhong(phong).ToList());
            //UpdateRows();
            UpdateRowsAndColumns();
        }

        public void RemovePhong(PHONG phong)
        {
            for (int i = 0; i < _arrPhong.Count; i++)
            {
                if (_arrPhong[i].MaPhong == phong.MaPhong)
                {
                    _arrPhong.RemoveAt(i);
                    _cachePhieuThue.RemoveAt(i);
                    break;
                }
            }
            //UpdateRows();
            UpdateRowsAndColumns();
        }

        public void RemoveAll()
        {
            int numberOfPhong = _arrPhong.Count;
            for (int i = 0; i < numberOfPhong; i++)
            {
                _arrPhong.RemoveAt(0);
                _cachePhieuThue.RemoveAt(0);
            }
            //UpdateRows();
            //UpdateRowsAndColumns();
        }

        public void AddDateRange(DateTime BeginDate, DateTime EndDate)
        {
            if (EndDate.CompareTo(BeginDate) > 0)
            {
                _beginDate = BeginDate;
                _endDate = EndDate;
                //UpdateColumns();
                UpdateRowsAndColumns();
            }
        }

        private void UpdateColumns()
        {
            //add columns
            TimeSpan ts = _endDate - _beginDate;
            int differenceInDays = ts.Days;
            if (dtgTheHienPhieuThuePhong.Columns.Count > 0)
            {
                if (dtgTheHienPhieuThuePhong.Columns.Count < (differenceInDays + 1))
                {
                    int numberOfColumns = dtgTheHienPhieuThuePhong.Columns.Count;
                    int numberOfColumnsToAdd = (differenceInDays + 1) - dtgTheHienPhieuThuePhong.Columns.Count;
                    DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[numberOfColumnsToAdd];

                    for (int i = 0; i < numberOfColumnsToAdd; i++)
                    {
                        columns[i] = new DataGridViewTextBoxColumn();
                        columns[i].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                        columns[i].HeaderText = _beginDate.AddDays(numberOfColumns + i).Day.ToString();
                        columns[i].Name = _beginDate.AddDays(numberOfColumns + i).ToString();
                        columns[i].ReadOnly = true;
                        columns[i].ValueType = typeof(string);
                        columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                        dtgTheHienPhieuThuePhong.Columns.Add(columns[i]);
                    }
                }
                else if (dtgTheHienPhieuThuePhong.Columns.Count > (differenceInDays + 1))
                {
                    int numberOfColumnsToRemove = dtgTheHienPhieuThuePhong.Columns.Count - (differenceInDays + 1);

                    for (int i = 0; i < numberOfColumnsToRemove; i++)
                    {
                        dtgTheHienPhieuThuePhong.Columns.RemoveAt(dtgTheHienPhieuThuePhong.Columns.Count - 1);
                    }
                }
            }
            else
            {
                int numberOfColumn = differenceInDays + 1;
                DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[numberOfColumn];
                for (int i = 0; i < numberOfColumn; i++)
                {
                    columns[i] = new DataGridViewTextBoxColumn();
                    columns[i].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                    columns[i].HeaderText = _beginDate.AddDays(i).Day.ToString();
                    columns[i].Name = _beginDate.AddDays(i).ToString();
                    columns[i].ReadOnly = true;
                    columns[i].ValueType = typeof(string);
                    columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dtgTheHienPhieuThuePhong.Columns.Add(columns[i]);
                }
            }
        }

        private void UpdateRows()
        {
            //clear all rows
            dtgTheHienPhieuThuePhong.Rows.Clear();

            //add rows
            if (dtgTheHienPhieuThuePhong.Columns.Count > 0)                      //sure that columns added first
            {
                int numberOfRows = _arrPhong.Count;
                DataGridViewRow[] rows = new DataGridViewRow[numberOfRows];
                for (int i = 0; i < numberOfRows; i++)
                {
                    rows[i] = new DataGridViewRow();
                    rows[i].HeaderCell.Value = _arrPhong[i].TenPhong;
                    dtgTheHienPhieuThuePhong.Rows.Add(rows[i]);
                }
            }
        }

        public UCXemPhieuThuePhong()
        {
            InitializeComponent();
        }

        private void dtgTheHienPhieuThuePhong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < _cachePhieuThue.Count)
            {
                foreach (PHIEUTHUE phieu in _cachePhieuThue[e.RowIndex])
                {
                    if (_beginDate.CompareTo(phieu.NgayThue) <= 0 && _endDate.CompareTo(phieu.NgayThue) >= 0)
                    {
                        if (phieu.NgayThue.Day < (e.ColumnIndex + 1) && (e.ColumnIndex + 1) <= phieu.NgayThue.Day + phieu.SoNgayThue - 1)
                        {
                            e.Value = "";
                            e.FormattingApplied = true;
                        }
                    }
                }
            }
        }

        private void dtgTheHienPhieuThuePhong_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < _cachePhieuThue.Count)
            {
                e.AdvancedBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
                if (e.RowIndex < 0 || e.ColumnIndex < 1)
                    return;
                foreach (PHIEUTHUE phieu in _cachePhieuThue[e.RowIndex])
                {
                    if (DateTime.Compare(_beginDate, phieu.NgayThue) <= 0 && DateTime.Compare(phieu.NgayThue, _endDate) <= 0)
                    {
                        if (phieu.NgayThue.Day == (e.ColumnIndex + 1))
                        {
                            e.CellStyle.BackColor = Color.Pink;
                        }
                        if (phieu.NgayThue.Day < (e.ColumnIndex + 1))
                        {
                            if ((e.ColumnIndex + 1) <= phieu.NgayThue.Day + phieu.SoNgayThue - 1)
                            {
                                e.AdvancedBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
                                e.CellStyle.BackColor = Color.Pink;
                                return;
                            }
                        }
                    }
                }
                e.AdvancedBorderStyle.Left = dtgTheHienPhieuThuePhong.AdvancedCellBorderStyle.Left;
            }
        }

        public void UpdateRowsAndColumns()
        {
            UpdateColumns();
            UpdateRows();
        }
    }
}
