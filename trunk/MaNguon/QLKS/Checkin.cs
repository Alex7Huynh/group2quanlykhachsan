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
    public partial class frmCheckin : Form
    {
        List<PHIEUTHUE> phieuThue = new List<PHIEUTHUE>();
        PHIEUTHUE ptCapNhat = new PHIEUTHUE();
        public frmCheckin()
        {
            InitializeComponent();

        }
        #region 0812388
        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvDanhSachPhieuThue.Rows.Clear();
            List<NhomDTO> dsNhom = BUS.NhomBUS.LayDSNhomTheoMaKhach(BUS.KHACHHANGBUS.LayKhachTheoSoGiayToChinhXac(txtCMND.Text).MaKH);
           
            foreach (NhomDTO nhom in dsNhom)
            {
                List<PHIEUTHUE> dsPt = BUS.PHIEUTHUEBUS.LayDSPhieuThueTheoMaNhom(nhom.MaNhom);
                foreach (PHIEUTHUE pt in dsPt)
                {
                    dgvDanhSachPhieuThue.Rows.Add(pt.MaPhong, pt.MaPhieuThue, pt.NgayThue, pt.SoNgayThue, pt.TenKhachHangDaiDien);
                }
            }
        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachPhieuThue.SelectedRows.Count == 1)
            {
                if (dgvDanhSachPhieuThue.SelectedRows[0].Cells[1] != null && BUS.PHIEUTHUEBUS.CheckinPhieuThue(dgvDanhSachPhieuThue.SelectedRows[0].Cells[1].Value.ToString()))
                    MessageBox.Show("Checkin thành công");
                else
                    MessageBox.Show("Checkin thất bại");
            }
        }


       

        private void btnNhanHet_Click(object sender, EventArgs e)
        {
            bool kiemTra = true;
            foreach (DataGridViewRow dgr in dgvDanhSachPhieuThue.Rows)
            {
                if (dgr.Cells[1].Value != null)
                    kiemTra = BUS.PHIEUTHUEBUS.CheckinPhieuThue(dgr.Cells[1].Value.ToString());
            }
            if (kiemTra)
                MessageBox.Show("Checkin tất cả thành công");
            else
                MessageBox.Show("Checkin tất cả thất bại");
        }
        #endregion
    }
}
