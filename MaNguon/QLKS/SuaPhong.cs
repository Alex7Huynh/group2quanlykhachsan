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
    public partial class SuaPhong : Form
    {
        public SuaPhong()
        {
            InitializeComponent();
        }

        private void SuaPhong_Load(object sender, EventArgs e)
        {
            List<PHONG> dsphg = PHONGBUS.LayDSPhong();
            cmbMP.Items.Clear();
            for (int index = 0; index < dsphg.Count; index++)
                cmbMP.Items.Add(dsphg[index].MaPhong);
        }

        private void cmbMP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMP.Text != string.Empty)
            {
                PHONG phong = PHONGBUS.LayPhongTheoMa(cmbMP.Text);
                txtTP.Text = phong.TenPhong;
                txtLP.Text = phong.MaLoaiPhong;
                txtTT.Text = phong.TinhTrang;
                txtGC.Text = phong.GhiChu;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cmbMP.Text != string.Empty)
            {
                string loaiPhong = txtLP.Text;
                if (PHONGBUS.KiemTraLoaiPhong(loaiPhong))
                {
                    PHONGBUS.CapNhatPhong(cmbMP.Text, txtTP.Text, loaiPhong
                        , txtTT.Text, txtGC.Text);
                    MessageBox.Show("Da Sua Xong");
                }
                else MessageBox.Show("Ma Loai Phong Khong ton tai");
            }
            else MessageBox.Show("xin chon phong muon sua");
        }
       
    }
}
