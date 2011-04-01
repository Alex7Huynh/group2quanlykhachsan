using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace G2_QLKS
{
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {
            InitializeComponent();
        }

        private void ManHinhChinh_Load(object sender, EventArgs e)
        {

        }





        // Nhấn Button chức năng Điều chỉnh danh mục phòng
        private void simpleButton_DieuChinhDanhMucPhong_Click(object sender, EventArgs e)
        {
            DieuChinhDanhMucPhong frmDieuChinhDanhMucPhong = new DieuChinhDanhMucPhong();
            frmDieuChinhDanhMucPhong.Show();
        }





        // Nhấn Button chức năng Đặt phòng
        private void simpleButton_DatPhong_Click(object sender, EventArgs e)
        {

        }




        // Chọn Menu Help -> About
        private void toolStripMenuItem_About_Click(object sender, EventArgs e)
        {
            AboutBox dlgAbout = new AboutBox();
            dlgAbout.ShowDialog();
        }





        // Chọn Menu Help -> Help
        private void toolStripMenuItem_HelpDiaglog_Click(object sender, EventArgs e)
        {

        }





        // Nhấn Button Trước trên Toolbar
        private void toolStripButton_Truoc_Click(object sender, EventArgs e)
        {

        }





        // Nhấn Button Sau trên Toolbar
        private void toolStripButton_Sau_Click(object sender, EventArgs e)
        {

        }





        // Chọn Menu Exit 
        private void toolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }





        // Chọn Menu View  -> Toolbar 
        // Coder : Trần Duy Việt
        private void toolStripMenuItem_ViewToolbar_Click(object sender, EventArgs e)
        {
            if (toolStrip_ToolBarChinh.Visible == true)
            {
                toolStripMenuItem_ViewToolbar.Checked = false;
                toolStrip_ToolBarChinh.Visible = false;
            }
            else
            {
                toolStripMenuItem_ViewToolbar.Checked = true;
                toolStrip_ToolBarChinh.Visible = true;
            }
        }




        // Chọn Menu View -> Thanh chức năng
        // Coder : Trần Duy Việt
        private void toolStripMenuItem_ViewThanhChucNang_Click(object sender, EventArgs e)
        {
            if (navBarControl.Visible == true)
            {
                toolStripMenuItem_ViewThanhChucNang.Checked = false;
                navBarControl.Visible = false;
            }
            else
            {
                toolStripMenuItem_ViewThanhChucNang.Checked = true;
                navBarControl.Visible = true;
            }
        }

        


     

       

        

        


       

        
    }
}
