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
    public partial class frmBaoCaoDoanhThu : Form
    {
        // Dành cho di chuyển
        Point startPoint = new Point();
        public Point StartPoint
        {
            get { return startPoint; }
            set { startPoint = value; }
        }

        public Form ParentForm;

        // Hàm di chuyển menu
        private void PB_MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = new Point(e.X, e.Y);
        }

        public void MoveForm(Point distance)
        {
            this.Location = new Point(this.Location.X + distance.X, this.Location.Y + distance.Y);
        }

        private void PB_MainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MoveForm(new Point(e.X - StartPoint.X, e.Y - StartPoint.Y));
        }

        public frmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int thang = int.Parse(cmb.Text.Trim());
            List<PHONG> dsphg = new List<PHONG>();
            dsphg =PHONGBUS.LayDSPhong();

            int[] arrDoanhThu = new int[dsphg.Count] ;
            arrDoanhThu = PHONGBUS.LapBaoCaoDoanhThu(thang);

            List<int> dstb = new List<int>();
            dstb = PHONGBUS.layDSThietBiThang(thang);
            dataGridView1.Rows.Clear();
            for(int i=0; i<dsphg.Count;i++)
                dataGridView1.Rows.Add(i+1, dsphg[i].MaPhong, arrDoanhThu[i], dstb[i]);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {

        }


        private void BT_ThuNho_MouseLeave(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X + 1, button_temp.Location.Y + 1);
            button_temp.Size = new Size(button_temp.Size.Width - 2, button_temp.Size.Height - 2);
            button_temp.Image = null;
        }

        private void BT_ThuNho_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonMinimizeFocus;
        }

        private void BT_Thoat_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonExitFocus;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonXacNhanFocus;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonQuayLaiFocus;
        }

        private void frmBaoCaoDoanhThu_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentForm.Visible = true;
            ParentForm.Location = this.Location;
        }

        private void BT_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_ThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
