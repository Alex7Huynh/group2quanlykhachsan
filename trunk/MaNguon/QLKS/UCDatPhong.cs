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
        private List<PHONG> _arrPhong;

        private List<LOAIPHONG> _arrLoaiPhong;

        private int _currentLoaiPhong = 0;

        private void LoadDanhSachLoaiPhong()
        {
            _arrLoaiPhong = PHONGBUS.LayDSLoaiPhong().ToList();
            _currentLoaiPhong = 0;
            UpdateDanhSachPhong();
        }

        private void UpdateDanhSachPhong()
        {
            LoadDanhSachPhong(PHONGBUS.LayDSPhongTheoLoaiPhong(_arrLoaiPhong[_currentLoaiPhong]).ToList());
            txtLoaiPhong.Text = _arrLoaiPhong[_currentLoaiPhong].TenLoaiPhong;
        }

        public void LoadDanhSachPhong(List<PHONG> dsPhong)
        {
            _arrPhong = dsPhong;

            ucXemPhieuThuePhong.RemoveAll();
            for (int i = 0; i < _arrPhong.Count; i++)
            {
                ucXemPhieuThuePhong.AddPhong(_arrPhong[i]);
            }
        }

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
