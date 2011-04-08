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
        
        /// <summary>
        /// 0812005//////////////////////////////////////////////////
        /// </summary>
        private static DateTime _ngaythue = DateTime.Now;
        private static int _rowdown = -1;
        private static int _coldown = -1;
        private static int _rowup = -1;
        private static int _colup = -1;

        private static DateTime _kethuc = DateTime.Now;

        public static DateTime Kethuc
        {
            get { return UCXemPhieuThuePhong._kethuc; }
            set { UCXemPhieuThuePhong._kethuc = value; }
        }

        public static DateTime Ngaythue
        {
            get { return UCXemPhieuThuePhong._ngaythue; }
            set { UCXemPhieuThuePhong._ngaythue = value; }
        }
        /// <summary>
        /// ////////////////////////////////////////////////////////
        /// </summary>
        private List<PHONG> _arrPhong = new List<PHONG>();

        private List<List<PHIEUTHUE>> _cachePhieuThue = new List<List<PHIEUTHUE>>();

        private DateTime _beginDate;

        private DateTime _endDate;

        //#region XacDinhMau 0812517

        //class Dinh
        //{
        //    int _x;                 //vị trí của phiếu thuê trong cache

        //    public int X
        //    {
        //        get { return _x; }
        //        set { _x = value; }
        //    }

        //    int _y;                 //vị trí của phiếu thuê trong cache

        //    public int Y
        //    {
        //        get { return _y; }
        //        set { _y = value; }
        //    }
            
        //    int _bac;               //bậc của đỉnh, là số phiếu thuê kề với phiếu thuê hiện tại.

        //    public int Bac
        //    {
        //        get { return _bac; }
        //        set { _bac = value; }
        //    }
        //    int _color;             //màu của đỉnh đó, 0= chưa có màu

        //    public int Color
        //    {
        //        get { return _color; }
        //        set { _color = value; }
        //    }
        //}

        //private List<Dinh> _arrDinh = new List<Dinh>();

        //private List<List<int>> _arrDinhKe = new List<List<int>>();

        //private void UpdateColorPhieuThuePhong()
        //{
        //    ChuyenPhieuThuePhongThanhDinh();

        //    ToMau(_arrDinh);
        //}

        //private void ChuyenPhieuThuePhongThanhDinh()
        //{
        //    for (int i = 0; i < _cachePhieuThue.Count; i++)
        //        for (int j = 0; j < _cachePhieuThue[i].Count; j++)
        //        {
        //            Dinh dinh = new Dinh();
        //            dinh.X = i;
        //            dinh.Y = j;
        //            dinh.Bac = 0;                                               //khởi tạo bậc của đỉnh
        //            dinh.Color = 0;                                             //khởi tạo _color = 0; tức chưa được tô màu
        //            _arrDinh.Add(dinh);
        //        }

        //    //cập nhật bậc của đỉnh
        //    CapNhatDanhSachDinhKe();
        //    for (int i = 0; i < _arrDinh.Count; i++)
        //    {
        //        _arrDinh[i].Bac = _arrDinhKe[i].Count;
        //    }
        //}

        //private void CapNhatDanhSachDinhKe()
        //{
        //    for (int i = 0; i < _arrDinh.Count; i++)
        //    {
        //        List<int> dsDinhKeCuaDinh = new List<int>();
        //        for (int j = 0; j < _arrDinh.Count; j++)
        //        {
        //            if (La2DinhKe(_arrDinh[i], _arrDinh[j]))
        //            {
        //                dsDinhKeCuaDinh.Add(j);
        //            }
        //        }
        //        _arrDinhKe.Add(dsDinhKeCuaDinh);
        //    }
        //}

        //private bool La2DinhKe(Dinh dinh, Dinh dinh_2)
        //{
        //    //2 phòng kề nhau
        //    if (dinh.X == dinh_2.X || dinh.X == dinh_2.X - 1 || dinh.X == dinh_2.X + 1)
        //    {
        //          //2 phiếu thuê phòng có ngày thuê lồng nhau
        //          DateTime ngayBatDauPT1 = _cachePhieuThue[dinh.X][dinh.Y].NgayThue;
        //          DateTime ngayKetThucPT1 = _cachePhieuThue[dinh.X][dinh.Y].NgayThue.AddDays(_cachePhieuThue[dinh.X][dinh.Y].SoNgayThue);
        //          DateTime ngayBatDauPT2 = _cachePhieuThue[dinh_2.X][dinh_2.Y].NgayThue;
        //          DateTime ngayKetThucPT2 = _cachePhieuThue[dinh_2.X][dinh_2.Y].NgayThue.AddDays(_cachePhieuThue[dinh_2.X][dinh_2.Y].SoNgayThue);
        //          if (ngayBatDauPT1.CompareTo(ngayBatDauPT2) <= 0 && ngayKetThucPT1.CompareTo(ngayBatDauPT2) >= 0 ||
        //              ngayBatDauPT2.CompareTo(ngayBatDauPT1) <= 0 && ngayKetThucPT2.CompareTo(ngayBatDauPT1) >= 0)
        //          {
        //              return true;
        //          }
        //          return false;
        //    }
        //}

        //private void ToMau(List<Dinh> dsDinh)
        //{
        //      //sắp xếp các đỉnh theo thứ tự giảm dần của bậc
        //      SapXepDinh();
        //      int color = 1;
        //      while (TinhSoDinhChuaDuocToMau())
        //      {
        //          //xét lần lượt các đỉnh (đã sắp xếp)
        //          for (i = 0; i < _arrDinh.Count; i++)
        //          {
        //              //nếu không có đỉnh nào kề nó có màu color,
        //              //bool coTheToMau = false;
        //              for (j = 0; j < _arrDinhKe[i].Count; j++)
        //              {
        //                  if (_arrDinh[_arrDinhKe[i][j]].Color == color)
        //                  {
        //                      coTheToMau = false;
        //                      break;
        //                  }
        //                  coTheToMau = true;
        //              }
        //              if (coTheToMau)
        //              {
        //                  //tô màu cho nó là color
        //                  _arrDinh[i].Color = color;
        //                  //loại bỏ đỉnh này ra khỏi danh sách đỉnh cần tô màu
        //                  _arrDinh.RemoveAt(i);
        //              }
        //      //  }
        //      //  color = color + 1;
        //      }
        //}

        //private void SapXepDinh()
        //{
        //    for (i = 0; i < _arrDinh.Count - 1; i++)
        //        for (j = i + 1; j < _arrDinh.Count; j++)
        //        {
        //            if (_arrDinh[i]._bac < _arrDinh[j]._bac)
        //            {
        //                Dinh temp = new Dinh();
        //                temp = _arrDinh[i];
        //                _arrDinh[i] = _arrDinh[j];
        //                _arrDinh[j] = temp;

        //                List<Dinh> dinhKe_temp = new List<Dinh>();
        //                dinh_temp = _arrDinhKe[i];
        //                _arrDinhKe[i] = _arrDinhKe[j];
        //                _arrDinhKe[j] = dinhKe_temp;
        //            }
        //        }
        //}

        //private int TinhSoDinhChuaDuocToMau()
        //{
        //    int soDinhChuaDuocToMau = 0;
        //    for (i = 0; i < _arrDinh.Count; i++)
        //    {
        //        if (_arrDinh[i].Mau == 0)
        //            soDinhChuaDuocToMau++;
        //    }
        //    return soDinhChuaDuocToMau;
        //}
        //#endregion

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
            ///////////////////////0812604             
            Dinh calculator = new Dinh();
            List<PHIEUTHUE> dsPhieuTemp = new List<PHIEUTHUE>();

            for (int i = 0; i < _cachePhieuThue.Count; i++)
                for (int j = 0; j < _cachePhieuThue[i].Count; j++)
                {
                    dsPhieuTemp.Add(_cachePhieuThue[i][j]);
                }

            List<int>  dsMauTo = calculator.TinhMau(dsPhieuTemp);
            ///////////////////////

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
                            //e.CellStyle.BackColor = Color.Pink;

                            /////////////////////////0812604
                            int index_temp = _cachePhieuThue[e.RowIndex].IndexOf(phieu);
                            int index_temp2 = e.RowIndex;
                            int index_temp_base = 0;
                            index_temp2--;
                            while (index_temp2 != -1)
                            {
                                index_temp_base += _cachePhieuThue[index_temp2].Count;
                                index_temp2--;
                            }
                            index_temp_base += index_temp;
                            int color_temp = dsMauTo[index_temp_base];

                            if (index_temp_base % 3 == 0)
                                e.CellStyle.BackColor = Color.FromArgb(255, color_temp, 0, 0);
                            if (index_temp_base % 3 == 1)
                                e.CellStyle.BackColor = Color.FromArgb(255, 0, color_temp, 0);
                            if (index_temp_base % 3 == 2)
                                e.CellStyle.BackColor = Color.FromArgb(255, 0, 0, color_temp);
                            //////////////////////////
                        }
                        if (phieu.NgayThue.Day < (e.ColumnIndex + 1))
                        {
                            if ((e.ColumnIndex + 1) <= phieu.NgayThue.Day + phieu.SoNgayThue - 1)
                            {
                                e.AdvancedBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
                                //e.CellStyle.BackColor = Color.Pink;

                                /////////////////////////0812604
                                int index_temp = _cachePhieuThue[e.RowIndex].IndexOf(phieu);
                                int index_temp2 = e.RowIndex;
                                int index_temp_base = 0;
                                index_temp2--;
                                while (index_temp2 != -1)
                                {
                                    index_temp_base += _cachePhieuThue[index_temp2].Count;
                                    index_temp2--;
                                }
                                index_temp_base += index_temp;
                                int color_temp = dsMauTo[index_temp_base];

                                if (index_temp_base % 3 == 0)
                                    e.CellStyle.BackColor = Color.FromArgb(255, color_temp, 0, 0);
                                if (index_temp_base % 3 == 1)
                                    e.CellStyle.BackColor = Color.FromArgb(255, 0, color_temp, 0);
                                if (index_temp_base % 3 == 2)
                                    e.CellStyle.BackColor = Color.FromArgb(255, 0, 0, color_temp);
                                //////////////////////////

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
        /// <summary>
        /// 0812005////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgTheHienPhieuThuePhong_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            _rowdown = e.RowIndex;
            _coldown = e.ColumnIndex;
        }

        private void dtgTheHienPhieuThuePhong_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            _rowup = e.RowIndex;
            _colup = e.ColumnIndex;
            if (kiemtra(_rowup, _rowdown))
            {
                _ngaythue = DateTime.Parse(dtgTheHienPhieuThuePhong.Columns[_coldown].Name);
                _kethuc = DateTime.Parse(dtgTheHienPhieuThuePhong.Columns[_colup].Name);

            }
            else
            {
                MessageBox.Show(" chon sai");
                return;
            }
            frmReservation a = new frmReservation();
            a.ShowDialog();
        }
        /// <summary>
        /// 0812005-kiểm tra xem có chọn ngày hợp lệ hay không//////////////////////////
        /// </summary>
        /// <param name="rowdown"> </param>
        /// <param name="rowup"></param>
        /// <returns></returns>
        private bool kiemtra(int rowdown, int rowup)
        {
            if (rowdown == rowup)
                return true;
            return false;

        }
    }

    #region class Dinh (0812604)
    /// <summary>
    /// 0812604
    /// </summary>
    class Dinh
    {
        int index = 0;
        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        int _bac = 0;

        public int Bac
        {
            get { return _bac; }
            set { _bac = value; }
        }

        int _color = 0;

        public int Color
        {
            get { return _color; }
            set { _color = value; }
        }

        // danh sách màu
        List<int> dsMau = new List<int>();

        public List<int> DsMau
        {
            get { return dsMau; }
            set { dsMau = value; }
        }

        //danh sách đỉnh
        List<Dinh> dsDinh = new List<Dinh>();

        internal List<Dinh> DsDinh
        {
            get { return dsDinh; }
            set { dsDinh = value; }
        }

        // danh sách đỉnh kể của từng đỉnh
        List<List<Dinh>> dsDinhKe = new List<List<Dinh>>();

        internal List<List<Dinh>> DsDinhKe
        {
            get { return dsDinhKe; }
            set { dsDinhKe = value; }
        }

        public void ToMau(List<Dinh> dsDinh)
        {
            int i = 0;
            int j = 0;

            // sắp xếp các đỉnh theo thứ tự giảm dần của bậc
            // đồng thời sắp lại mảng danh sách kề
            for (i = 0; i < dsDinh.Count - 1; i++)
                for (j = i + 1; j < dsDinh.Count; j++)
                {
                    if (dsDinh[i]._bac < dsDinh[j]._bac)
                    {
                        Dinh temp = new Dinh();
                        temp = dsDinh[i];
                        dsDinh[i] = dsDinh[j];
                        dsDinh[j] = temp;

                        List<Dinh> dinh_temp = new List<Dinh>();
                        dinh_temp = dsDinhKe[i];
                        dsDinhKe[i] = dsDinhKe[j];
                        dsDinhKe[j] = dinh_temp;
                    }
                }

            // tô màu
            i = 0;
            int k = 0;
            bool condinh = true; // còn đỉnh chưa tô màu
            int color = 1;       // màu đầu tiên để tô

            while (condinh == true)
            {
                if (dsDinhKe.Count != 0)
                {
                    //neu khong co dinh ke nao thi danh mau tu do
                    if (dsDinhKe[k].Count == 0)
                    {
                        dsDinh[i]._color = color;

                        // cap nhat mau trong danh sach cac dinh ke
                        for (int m = 0; m < dsDinhKe.Count; m++)
                        {
                            for (int n = 0; n < dsDinhKe[m].Count; n++)
                            {
                                if (dsDinhKe[m][n].index == dsDinh[i].index)
                                    dsDinhKe[m][n]._color = color;
                            }
                        }
                    }

                    else
                    {
                        for (j = 0; j < dsDinhKe[k].Count; j++)
                        {
                            if (dsDinhKe[k][j]._color == color)
                            {
                                j = -1;
                                color++;
                            }
                            else if (j == dsDinhKe[k].Count - 1)
                            {
                                dsDinh[i]._color = color;

                                // cap nhat mau trong danh sach cac dinh ke
                                for (int m = 0; m < dsDinhKe.Count; m++)
                                {
                                    for (int n = 0; n < dsDinhKe[m].Count; n++)
                                    {
                                        if (dsDinhKe[m][n].index == dsDinh[i].index)
                                            dsDinhKe[m][n]._color = color;
                                    }
                                }
                            }
                        }
                    }
                    k++;
                    if (k == dsDinhKe.Count)
                        break;
                    color = 1;

                    for (i = 0; i < dsDinh.Count; i++)
                    {
                        if (dsDinh[i]._color == 0)
                        {
                            condinh = true;
                            break;
                        }
                        else if (i == dsDinh.Count - 1)
                            condinh = false;
                    }
                }
                else
                    condinh = false;
            }
        }

        // tạo danh sách đỉnh từ danh sách các thẻ thuê phòng
        public void TaoDSDinh(List<PHIEUTHUE> dsPhieu)
        {
            for (int i = 0; i < dsPhieu.Count; i++)
            {
                Dinh temp = new Dinh();
                temp.index = i;

                dsDinh.Add(temp);
            }
        }

        // tính bậc cho đỉnh - phiếu thuê phòng
        public void TinhBac(List<PHIEUTHUE> dsPhieu)
        {
            for (int i = 0; i < dsPhieu.Count - 1; i++)
                for (int j = i + 1; j < dsPhieu.Count; j++)
                {
                    if (LaLienKe(dsPhieu[i], dsPhieu[j]))
                    {
                        dsDinh[i]._bac++;
                        dsDinh[j]._bac++;
                    }
                }
        }

        // xem phiếu này có liền kề phiếu kia hay không
        public bool LaLienKe(PHIEUTHUE phieu1, PHIEUTHUE phieu2)
        {
            string lastchar1 = phieu1.MaPhong.Substring(phieu1.MaPhong.Length - 3);
            string lastchar2 = phieu2.MaPhong.Substring(phieu2.MaPhong.Length - 3);

            // nếu cùng phòng
            if (phieu1.MaPhong == phieu2.MaPhong)
            {
                if (phieu1.NgayThue.AddDays(phieu1.SoNgayThue + 1) == phieu2.NgayThue ||
                    phieu2.NgayThue.AddDays(phieu2.SoNgayThue + 1) == phieu1.NgayThue)
                    return true;
            }

            // nếu khác phòng và 2 phòng có mã số gần nhau           
            //else if (int.Parse(lastchar1) - int.Parse(lastchar2) == 1 ||
            //    int.Parse(lastchar1) - int.Parse(lastchar2) == -1)
            else
            {
                if (phieu1.NgayThue == phieu2.NgayThue ||
                    phieu1.NgayThue.AddDays(phieu1.SoNgayThue) == phieu2.NgayThue.AddDays(phieu2.SoNgayThue))
                    return true;

                if (phieu1.NgayThue < phieu2.NgayThue &&
                    phieu1.NgayThue.AddDays(phieu1.SoNgayThue) > phieu2.NgayThue)
                    return true;

                if (phieu1.NgayThue > phieu2.NgayThue &&
                    phieu2.NgayThue.AddDays(phieu2.SoNgayThue) > phieu1.NgayThue)
                    return true;
            }

            return false;
        }

        // tạo danh sách các đỉnh kề cho từng đỉnh
        public void TaoDSDinhKe(List<PHIEUTHUE> dsPhieu)
        {
            for (int i = 0; i < dsPhieu.Count; i++)
            {
                List<Dinh> dsTemp = new List<Dinh>();

                for (int j = 0; j < dsPhieu.Count; j++)
                {
                    if (LaLienKe(dsPhieu[i], dsPhieu[j]) && j != i)
                    {
                        dsTemp.Add(dsDinh[j]);
                    }
                }

                dsDinhKe.Add(dsTemp);
            }
        }

        // tính màu dựa vào thông số _color của đỉnh
        // hàm này làm luôn tất cả các bước để cho ra mảng màu cuối cùng

        public List<int> TinhMau(List<PHIEUTHUE> dsPhieu)
        {
            TaoDSDinh(dsPhieu);
            TinhBac(dsPhieu);
            TaoDSDinhKe(dsPhieu);
            ToMau(dsDinh);

            // mảng lưu tạm màu (int) của các đỉnh
            List<int> dsTemp = new List<int>();

            for (int i = 0; i < dsDinh.Count; i++)
            {
                int temp = dsDinh[i]._color;
                dsTemp.Add(temp);
            }

            // tính số lượng màu
            for (int i = 0; i < dsTemp.Count - 1; i++)
            {
                for (int j = i + 1; j < dsTemp.Count; j++)
                {
                    if (dsTemp[j] == dsTemp[i])
                        dsTemp.RemoveAt(j);
                }
            }

            // khoảng cách giữa các màu
            if (dsTemp.Count == 0)
                return null;

            int range = 255 / dsTemp.Count;

            for (int i = 0; i < dsDinh.Count; i++)
            {
                int color = dsDinh[i]._color * range;

                dsMau.Add(color);
            }
            dsMau.Add(0);

            // sap xep lai dsMau theo index ban dau, luc chua sap xep theo bac
            for (int i = 0; i < dsDinh.Count; i++)
            {
                int color = 0;

                color = dsMau[i];
                dsMau[i] = dsMau[dsDinh[i].index];
                dsMau[dsDinh[i].index] = color;
            }

            return dsMau;
        }
    }
    #endregion
}
