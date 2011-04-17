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
        public frmCheckin()
        {
            InitializeComponent();
            List<PHIEUTHUE> phieuThue = new List<PHIEUTHUE>();
            PHONG phong = new PHONG();
            phong.TinhTrang = "free";
            phieuThue = PHIEUTHUEBUS.LayDSPhieuThueTheoTinhTrangPhong(phong);
            for (int i = 0; i < phieuThue.Count; i++)
            {
                comboBox1.Items.Add(phieuThue[i].MaPhong);
            }
        }

        public void KhoiTaoComboBox()
        {
            List<PHIEUTHUE> phieuThue = new List<PHIEUTHUE>();
            PHONG phong = new PHONG();
            phong.TinhTrang = "free";
            phieuThue = PHIEUTHUEBUS.LayDSPhieuThueTheoTinhTrangPhong(phong);
            for (int i = 0; i < phieuThue.Count; i++)
            {
                comboBox1.Items.Add(phieuThue[i].MaPhong);
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
                dataGridView1.Rows.Add(phieuThue[i].MaPhong, phieuThue[i].MaPhieuThue, phieuThue[i].NgayThue, phieuThue[i].SoNgayThue,phieuThue[i].TenKhachHangDaiDien);
                dataGridView1.Rows[dataGridView1.RowCount - 1].Tag = phieuThue[i];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PHONG phong = new PHONG();
                phong.MaPhong = comboBox1.SelectedItem.ToString();
                phong.TinhTrang = "checkin";//Thuoc tinh can update trong tinh trang phong
                bool b = PHONGBUS.UpdateTinhTrangPhong(phong);
                if (true == b)
                {
                    MessageBox.Show("Check in thành công");
                    dataGridView1.Rows.Clear();
                    comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                    comboBox1.Refresh();
                    comboBox1.Items.Clear();
                    KhoiTaoComboBox();
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa chọn phòng");
            }
        }
    }
}
