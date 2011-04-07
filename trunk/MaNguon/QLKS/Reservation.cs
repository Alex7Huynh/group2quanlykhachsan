using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QLKS
{
    public partial class frmReservation : Form
    {
        private PHIEUTHUE _phieuThue;

        private DateTime _endDate;

        private DateTime _beginDate;

        public PHIEUTHUE GetPhieuThue()
        {
            return _phieuThue;
        }

        public frmReservation()
        {
            InitializeComponent();
            _phieuThue = new PHIEUTHUE();
        }

        private void frmReservation_Load(object sender, EventArgs e)
        {
            cboLoaiPhong.DataSource = PHONGBUS.LayDSLoaiPhong().ToList();
            cboLoaiPhong.DisplayMember = "TenLoaiPhong";
        }

        private void cboLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = ((LOAIPHONG)cboLoaiPhong.Items[cboLoaiPhong.SelectedIndex]).DonGia.ToString();
        }

        private void dtpBeginDate_ValueChanged(object sender, EventArgs e)
        {
            _beginDate = dtpBeginDate.Value;
            UpdateDuration();
        }

        private void UpdateDuration()
        {
            TimeSpan ts = _endDate - _beginDate;
            int differenceInDays = ts.Days;
            txtDuration.Text = differenceInDays.ToString();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            _endDate = dtpEndDate.Value;
            UpdateDuration();
        }

        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            _phieuThue.MaPhong = ((PHONG)cboLoaiPhong.Items[cboLoaiPhong.SelectedIndex]).MaPhong;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckInputValue())
            {
                SetInputValue();
            }
            else
            {
                MessageBox.Show("Invalid information!");
            }
            PHIEUTHUEBUS.ToiUuPhieuThue((LOAIPHONG)cboLoaiPhong.Items[cboLoaiPhong.SelectedIndex]);
            if (PHIEUTHUEBUS.ThemPhieu(_phieuThue))
            {
                MessageBox.Show("Da dat phong thanh cong");
            }
            else
            {
                MessageBox.Show("Khong co phong trong trong thoi gian ban muon thue, vui long dat phong vao ngay khac!");
            }
        }

        private void SetInputValue()
        {
            _phieuThue.MaPhieuThue = "";            //sau nay them
            _phieuThue.MaPhong = "";                //sau nay them
            _phieuThue.NgayThue = _beginDate;
            _phieuThue.SoNgayThue = int.Parse(txtDuration.Text);
        }

        private bool CheckInputValue()
        {
            if (int.Parse(txtDuration.Text) >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
