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
        // Dành cho di chuyển
        Point startPoint = new Point();
        public Point StartPoint
        {
            get { return startPoint; }
            set { startPoint = value; }
        }

        public Form ParentForm;

        private void PB_MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = new Point(e.X, e.Y);
        }

        // Hàm di chuyển menu
        public void MoveForm(Point distance)
        {
            this.Location = new Point(this.Location.X + distance.X, this.Location.Y + distance.Y);
        }

        private void PB_MainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MoveForm(new Point(e.X - StartPoint.X, e.Y - StartPoint.Y));
        }

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
                PHONG phong = new PHONG();
                phong.MaPhong = cmbMP.Text.Trim();
                phong.TenPhong = txtTP.Text.Trim();
                phong.MaLoaiPhong =txtLP.Text.Trim();
                phong.TinhTrang= txtTT.Text.Trim();
                phong.GhiChu=txtGC.Text.Trim();  
                if (PHONGBUS.KiemTraPhong(phong))
                {
                    PHONGBUS.CapNhatPhong(phong);
                    MessageBox.Show("Da Sua Xong");
                }
                else MessageBox.Show("That Bai");
            }
            else MessageBox.Show("xin chon phong muon sua");
        }

        /// <summary>
        /// 0812604 - giaodien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_ThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BT_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManDinhDatPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentForm.Visible = true;
            ParentForm.Location = this.Location;
        }

        private void BT_Thoat_MouseLeave(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X + 1, button_temp.Location.Y + 1);
            button_temp.Size = new Size(button_temp.Size.Width - 2, button_temp.Size.Height - 2);
            button_temp.Image = null;
        }

        private void BT_Thoat_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonExitFocus;
        }

        private void BT_ThuNho_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonMinimizeFocus;
        }

        private void btnHuyBo_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonQuayLaiFocus;
        }

        private void btnSua_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonFixFocus;
        }
    }
}
