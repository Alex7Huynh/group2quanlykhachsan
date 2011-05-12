using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLKS
{
    public partial class XoaPhong : Form
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

        public XoaPhong()
        {
            InitializeComponent();
        }
        private List<PHONG> dsphg = new List<PHONG>();
        private void XoaPhong_Load(object sender, EventArgs e)
        {
            ReLoad();

            //0812604 giao dien
        }
        private void ReLoad()
        {
            dtg1.Rows.Clear();
            dsphg = PHONGBUS.LayDSPhong();
            for (int index = 0; index < dsphg.Count; index++)
                if (string.Compare(dsphg[index].DaXoa, "0", true) == 0)
                    dtg1.Rows.Add(dsphg[index].MaPhong,
                        dsphg[index].TenPhong,
                        dsphg[index].MaLoaiPhong,
                        dsphg[index].GhiChu,
                        dsphg[index].TinhTrang);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dtg1.CurrentRow.Index;
            if (index >= 0)
            {
                DialogResult result;
                try
                {
                    string MaPhong = dtg1.Rows[index].Cells[0].Value.ToString();
                    result = MessageBox.Show("BAN CO CHAC LA XOA PHONG NAY", "Canh Bao", MessageBoxButtons.YesNo);
                    if ((result == DialogResult.Yes) && (MaPhong != string.Empty))
                    {
                        PHONGBUS.Xoa(MaPhong);
                        MessageBox.Show("Da Xoa Phong");
                        ReLoad();
                    }
                }
                catch
                {
                    MessageBox.Show("Khong Co Phong de xoa");
                }
            }
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            ReLoad();
        }

        //0812604-giao dien
        private void dtg1_Paint(object sender, PaintEventArgs e)
        {
            for (int index = 0; index < dtg1.Columns.Count; index++)
            {
                dtg1.Columns[index].HeaderCell.Style.ForeColor = Color.White;
                dtg1.Columns[index].HeaderCell.Style.BackColor = Color.Black;
                dtg1.Columns[index].HeaderCell.Style.Font = new Font("Consolas", 10, FontStyle.Bold);
            }

            for (int index = 0; index < dtg1.Rows.Count; index++)
            {
                dtg1.Rows[index].HeaderCell.Style.ForeColor = Color.White;
                dtg1.Rows[index].HeaderCell.Style.BackColor = Color.Black;
                dtg1.Rows[index].Height = 30;
            } 
        }
        
        private void BT_ThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BT_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XoaPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentForm.Visible = true;
            ParentForm.Location = this.Location;
        }

        private void BT_ThuNho_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = Properties.Resources.ButtonMinimizeFocus;
        }

        private void BT_Thoat_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = Properties.Resources.ButtonExitFocus;
        }

        private void BT_Thoat_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Image = null;
        }

        private void btnThoat_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = Properties.Resources.ButtonQuayLaiFocus;
        }

        private void btnXoa_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Image = Properties.Resources.ButtonXoaFocus;
        }
    }
}
