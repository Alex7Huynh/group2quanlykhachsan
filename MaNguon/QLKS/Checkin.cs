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

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                ptCapNhat = PHIEUTHUEBUS.LayPhieuThueTheoMa(comboBox1.SelectedValue.ToString())[0];
                PHIEUTHUEBUS.UpdateCheckin(ptCapNhat, true);
                MessageBox.Show("check in thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                phieuThue = PHIEUTHUEBUS.LayDSPhieuThueChuaCheckin();
                comboBox1.DataSource = phieuThue;
                comboBox1.DisplayMember = "tenKhachHangDaiDien";
                comboBox1.ValueMember = "maPhieuThue";
                comboBox1.SelectedIndex = 1;           }
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex > -1)
                    dataGridView1.DataSource = PHIEUTHUEBUS.LayPhieuThueTheoMa(comboBox1.SelectedValue.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCheckin_Load(object sender, EventArgs e)
        {
            phieuThue = PHIEUTHUEBUS.LayDSPhieuThueChuaCheckin();
            comboBox1.DataSource = phieuThue; 
            comboBox1.DisplayMember = "tenKhachHangDaiDien";
            comboBox1.ValueMember = "maPhieuThue";
            comboBox1.SelectedIndex = 1;
        }
    }
}
