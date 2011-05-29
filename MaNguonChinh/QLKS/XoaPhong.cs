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
        /// <summary>
        /// Điểm bắt được khi có sự kiện MousePressed
        /// </summary>
        Point startPoint = new Point();
        public Point StartPoint
        {
            get { return startPoint; }
            set { startPoint = value; }
        }

        /// <summary>
        /// Lưu lại form gọi hiển thị màn hình này
        /// </summary>
        public Form ParentForm;

        /// <summary>
        /// Hàm xử lý sự kiện MouseDown để lấy điểm bắt đầu di chuyển màn hình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PB_MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = new Point(e.X, e.Y);
        }

        /// <summary>
        /// Hàm di chuyển màn hình
        /// </summary>
        /// <param name="distance"></param>
        public void MoveForm(Point distance)
        {
            this.Location = new Point(this.Location.X + distance.X, this.Location.Y + distance.Y);
        }

        /// <summary>
        /// Hàm xử lý sự kiện MouseMove để cập nhật vị trí màn hình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            int index =0;
            try
            {
                index = dtg1.CurrentRow.Index;
            }
            catch
            {
                index = -1;
            }
            finally
            {
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
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            ReLoad();
        }

        /// <summary>
        /// Hàm xử lý sự kiện Paint của gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        
        /// <summary>
        /// Hàm xử lý sự kiện click của nút Thu nhỏ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_ThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Hàm xử lý sự kiện click của nút Thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Hàm xử lý sự kiện FormClosing của màn hình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XoaPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentForm.Visible = true;
            ParentForm.Location = this.Location;
        }

        /// <summary>
        /// Hàm xử lý sự kiện MouseEnter của nút Thu nhỏ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_ThuNho_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonMinimizeFocus;
        }

        /// <summary>
        /// Hàm xử lý sự kiện MouseEnter của nút Thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_Thoat_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonExitFocus;
        }

        /// <summary>
        /// Hàm xử lý sự kiện MouseLeave của nút Thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_Thoat_MouseLeave(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X + 1, button_temp.Location.Y + 1);
            button_temp.Size = new Size(button_temp.Size.Width - 2, button_temp.Size.Height - 2);
            button_temp.Image = null;
        }

        /// <summary>
        /// Hàm xử lý sự kiện MouseEnter của nút Thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonQuayLaiFocus;
        }

        /// <summary>
        /// Hàm xử lý sự kiện MouseEnter của nút Xoá
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonXoaFocus;
        }

        private void dtg1_SelectionChanged(object sender, EventArgs e)
        {
            int index = 0;
            try
            {

                if ((dtg1.Rows.Count > 1) && (index == dtg1.Rows.Count - 1))
                {
                    dtg1.CurrentRow.Selected = false;
                    index = 0;
                }
                else index = dtg1.CurrentCell.RowIndex;
            }
            catch
            {
                index = 0;
            }
            finally
            {
                dtg1.Rows[index].Selected = true;
            }
        }
    }
}
