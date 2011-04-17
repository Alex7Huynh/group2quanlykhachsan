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
            KhoiTaoComboBox();
        }

        public void KhoiTaoComboBox()
        {
            List<PHIEUTHUE> phieuThue = new List<PHIEUTHUE>();
            PHONG phong = new PHONG();
            phong.TinhTrang = "checkin";
            phieuThue = PHIEUTHUEBUS.LayDSPhieuThueTheoTinhTrangPhong(phong);
            for (int i = 0; i < phieuThue.Count; i++)
            {
                comboBox1.Items.Add(phieuThue[i].MaPhong);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PHONG phong = new PHONG();
                phong.MaPhong = comboBox1.SelectedItem.ToString();
                phong.TinhTrang = "free";
                bool b = PHONGBUS.UpdateTinhTrangPhong(phong);
                if (true == b)
                {
                    int SoNgayO = PHIEUTHUEBUS.layTongSoNgayThue(phong);
                    int DonGia = PHONGBUS.LayDonGiaTheoPhong(phong);
                    long TongTien = SoNgayO * DonGia;
                    textBox1.Text = TongTien.ToString()+"USD";
                    MessageBox.Show("Check out thành công");
                    dataGridView1.Rows.Clear();
                    //CheckOut ck = new CheckOut();
                    comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                    comboBox1.Items.Clear();
                    KhoiTaoComboBox();

                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check out thất bại hoàn toàn");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PHONG phong = new PHONG();
            phong.MaPhong = comboBox1.SelectedItem.ToString();
            // MessageBox.Show(phong.MaPhong);
            List<PHIEUTHUE> phieuThue = new List<PHIEUTHUE>();
            phieuThue = PHIEUTHUEBUS.LayDSPhieuThueTheoPhong(phong);
            for (int i = 0; i < phieuThue.Count; i++)
            {
                dataGridView1.Rows.Add(phieuThue[i].MaPhong, phieuThue[i].MaPhieuThue, phieuThue[i].NgayThue, phieuThue[i].SoNgayThue, phieuThue[i].TenKhachHangDaiDien);
                dataGridView1.Rows[dataGridView1.RowCount - 1].Tag = phieuThue[i];
            }
            
         
        }
    }
}
