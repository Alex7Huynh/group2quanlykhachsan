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
    public partial class frmCheckOut : Form
    {
        public frmCheckOut()
        {
            InitializeComponent();
        }

        private void rdoTenPhong_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void frmCheckOut_Load(object sender, EventArgs e)
        {
            
        }

        private void rdoTraPhongDon_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdoTraPhongDoan_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCMND2.Text.Trim() == "")
                {
                    throw new Exception("Bạn chưa nhập số CMND/PassPort");
                }
                string soGiayTo = txtCMND2.Text.Trim();
                string maKhach = KHACHHANGBUS.LayKhachTheoSoGiayToChinhXac(soGiayTo).MaKH;
                List<NhomDTO> dsNhom = NhomBUS.LayDSNhomTheoMaKhach(maKhach);
                List<PHIEUTHUE> dsPt = new List<PHIEUTHUE>();
                foreach (NhomDTO nhom in dsNhom)
                {
                    dsPt = BUS.PHIEUTHUEBUS.LayDSPhieuThueTheoMaNhom(nhom.MaNhom);
                }
                string thanhTien = PHIEUTHUEBUS.TinhTien(dsPt);
                txtThanhTien.Text = thanhTien;
                PHIEUTHUEBUS.TraPhong(dsPt);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
