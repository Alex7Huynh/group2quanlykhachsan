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

        #region XacDinhMau

        class Dinh
        {
            int _x;                 //vị trí của phiếu thuê trong cache

            public int X
            {
                get { return _x; }
                set { _x = value; }
            }

            int _y;                 //vị trí của phiếu thuê trong cache

            public int Y
            {
                get { return _y; }
                set { _y = value; }
            }
            
            int _bac;               //bậc của đỉnh, là số phiếu thuê kề với phiếu thuê hiện tại.

            public int Bac
            {
                get { return _bac; }
                set { _bac = value; }
            }
            int _color;             //màu của đỉnh đó

            public int Color
            {
                get { return _color; }
                set { _color = value; }
            }
        }

        private List<Dinh> _arrDinh = new List<Dinh>();

        private List<List<int>> _arrDinhKe = new List<List<int>>();

        private void UpdateColorPhieuThuePhong()
        {
            ChuyenPhieuThuePhongThanhDinh();

            ToMau(_arrDinh);
        }

        private void ChuyenPhieuThuePhongThanhDinh()
        {
            for (int i = 0; i < _cachePhieuThue.Count; i++)
                for (int j = 0; j < _cachePhieuThue[i].Count; j++)
                {
                    Dinh dinh = new Dinh();
                    dinh.X = i;
                    dinh.Y = j;
                    dinh.Bac = 0;                                               //khởi tạo bậc của đỉnh
                    dinh.Color = 0;                                             //khởi tạo _color = 0; tức chưa được tô màu
                    _arrDinh.Add(dinh);
                }

            //cập nhật bậc của đỉnh
            CapNhatDanhSachDinhKe();
            for (int i = 0; i < _arrDinh.Count; i++)
            {
                _arrDinh[i].Bac = _arrDinhKe[i].Count;
            }
        }

        private void CapNhatDanhSachDinhKe()
        {
            for (int i = 0; i < _arrDinh.Count; i++)
            {
                List<int> dsDinhKeCuaDinh = new List<int>();
                for (int j = 0; j < _arrDinh.Count; j++)
                {
                    if (La2DinhKeNhau(_arrDinh[i], _arrDinh[j]))
                    {
                        dsDinhKeCuaDinh.Add(j);
                    }
                }
                _arrDinhKe.Add(dsDinhKeCuaDinh);
            }
        }

        private bool La2DinhKeNhau(Dinh dinh, Dinh dinh_2)
        {
            throw new NotImplementedException();
        }

        private void ToMau(List<Dinh> dsDinh)
        {
            //sắp xếp các đỉnh theo thứ tự giảm dần của bậc
            //color = 1;
            //while (còn đỉnh chưa được tô màu)
            //{
            //      xét lần lượt các đỉnh (đã sắp xếp)
            //          nếu không có đỉnh nào kề nó có màu color,
            //              tô màu cho nó là color
            //      color = color + 1;
            //}
        }
        #endregion

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
