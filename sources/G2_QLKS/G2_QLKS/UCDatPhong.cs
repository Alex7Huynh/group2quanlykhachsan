using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using G2_QLKS.WebService;

namespace G2_QLKS
{
    public partial class UCDatPhong : UserControl
    {
        private List<PHONG> _arrPhong;

        public void LoadDanhSachPhong(List<PHONG> dsPhong)
        {
            _arrPhong = dsPhong;

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
        }

        private void mclCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateDateTime();
        }
    }
}
