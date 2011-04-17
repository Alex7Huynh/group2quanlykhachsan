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
    public partial class UCDatPhong : UserControl
    {
        /// <summary>
        /// 0812005 thêm thuộc tinh static va property
        /// </summary>
        private static List<PHONG> _arrPhong;
        public static List<PHONG> ArrPhong
        {
            get { return UCDatPhong._arrPhong; }
            set { UCDatPhong._arrPhong = value; }
        }

        private static List<LOAIPHONG> _arrLoaiPhong;

        public static List<LOAIPHONG> ArrLoaiPhong
        {
            get { return UCDatPhong._arrLoaiPhong; }
            set { UCDatPhong._arrLoaiPhong = value; }
        }

        private static int _currentLoaiPhong = 0;
        public static int CurrentLoaiPhong
        {
            get { return UCDatPhong._currentLoaiPhong; }
            set { UCDatPhong._currentLoaiPhong = value; }
        }
        /// <summary>
        /// lay danh sanh loai phong
        /// </summary>
        private void LoadDanhSachLoaiPhong()
        {
            _arrLoaiPhong = PHONGBUS.LayDSLoaiPhong().ToList();
            _currentLoaiPhong = 0;
            UpdateDanhSachPhong();
        }
        /// <summary>
        /// cap nhat lai danh sach phong
        /// </summary>
        private void UpdateDanhSachPhong()
        {
            if (0 < _currentLoaiPhong && _currentLoaiPhong < _arrLoaiPhong.Count)
            {
                LoadDanhSachPhong(PHONGBUS.LayDSPhongTheoLoaiPhong(_arrLoaiPhong[_currentLoaiPhong]).ToList());
                txtLoaiPhong.Text = _arrLoaiPhong[_currentLoaiPhong].TenLoaiPhong;
            }
        }
        /// <summary>
        /// lay danh danh phong
        /// </summary>
        /// <param name="dsPhong"></param>
        public void LoadDanhSachPhong(List<PHONG> dsPhong)
        {
            _arrPhong =  dsPhong;
            this.sortDSPhong(_arrPhong);
            ucXemPhieuThuePhong.RemoveAll();
            for (int i = 0; i < _arrPhong.Count; i++)
            {
                ucXemPhieuThuePhong.AddPhong(_arrPhong[i]);
            }

        }
        /// <summary>
        /// 0812005- sap xep lai ds phong
        /// </summary>
        /// <param name="dsPhong"></param>
        private void sortDSPhong(List<PHONG> dsPhong)
        {
            int _iSoPhong;
            _iSoPhong = dsPhong.Count;
           for(int i=0;i<_iSoPhong-1;i++)
               for (int j = i; j < _iSoPhong; j++)
               {
                   if (dsPhong[i].TenPhong.CompareTo(dsPhong[j].TenPhong) > 0)
                   {
                       PHONG temp = dsPhong[i];
                       dsPhong[i] = dsPhong[j];
                       dsPhong[j] = temp;
                   }                  

               }
        }
        /// <summary>
        /// 
        /// </summary>
        private void UpdateDateTime()
        {
            DateTime beginDate = GetFirstDayOfMonth(mclCalendar.SelectionStart);
            DateTime endDate = GetLastDayOfMonth(mclCalendar.SelectionStart);
            ucXemPhieuThuePhong.AddDateRange(beginDate, endDate);
        }

        public DateTime GetFirstDayOfMonth(DateTime dateTime)
        {
           return new DateTime(dateTime.Year, dateTime.Month, 1);
        }

        public DateTime GetLastDayOfMonth(DateTime dateTime)
        {
           DateTime firstDayOfTheMonth = new DateTime(dateTime.Year, dateTime.Month, 1);
           return firstDayOfTheMonth.AddMonths(1).AddDays(-1);
        }

        public UCDatPhong()
        {
            InitializeComponent();
            UpdateDateTime();
            LoadDanhSachLoaiPhong();
        }

        private void mclCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateDateTime();
        }

        private void btnNextLoaiPhong_Click(object sender, EventArgs e)
        {
            _currentLoaiPhong = (++_currentLoaiPhong) % _arrLoaiPhong.Count;
            UpdateDanhSachPhong();
        }

        private void btnPreviousLoaiPhong_Click(object sender, EventArgs e)
        {
            if (_currentLoaiPhong == 0)
            {
                _currentLoaiPhong = _arrLoaiPhong.Count;
            }
            _currentLoaiPhong = (--_currentLoaiPhong) % _arrLoaiPhong.Count;
            UpdateDanhSachPhong();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            Form frm = new frmReservation();
            frm.ShowDialog();
        }
    }
}
