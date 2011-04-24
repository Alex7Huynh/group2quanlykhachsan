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
    public partial class ThemPhong : Form
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

        public ThemPhong()
        {
            InitializeComponent();
        }
        private List<PHONG> dsmphg = new List<PHONG>();
        private void btnThem_Click(object sender, EventArgs e)
        {
            List<PHONG> phg = new List<PHONG>();
            phg = PHONGBUS.LayDSPhong();
            int temp = 0;
            string maPhong=txtMP.Text.Trim();
            string tenPhong =txtTen.Text.Trim();
            string loaiPhong =cmbLoai.Text.Trim();
            string ghiChu =txtGhiChu.Text.Trim();
            string tinhTrang = txtTT.Text.Trim();
            if (maPhong == "")
                MessageBox.Show("Xin Vui long nhap ma phong");
            else
            {
                for (int index = 0; index < phg.Count; index++)
                {
                    if (string.Compare(maPhong, phg[index].MaPhong, true) == 0)
                    {
                        temp = 1;
                        break;
                    }
                }
                for (int index = 0; index < dsmphg.Count; index++)
                {
                    if (string.Compare(maPhong, dsmphg[index].MaPhong, true) == 0)
                    {
                        temp = 2;
                        break;
                    }
                }
                
                if (PHONGBUS.KiemTraMaPhongHopLe(maPhong))
                {
                    PHONG phong1 = new PHONG();
                    phong1.MaPhong = maPhong;
                    phong1.TenPhong = tenPhong;
                    phong1.MaLoaiPhong = loaiPhong;
                    phong1.GhiChu = ghiChu;
                    phong1.TinhTrang = tinhTrang;

                    ThemPhongVaoDanhSach(temp, phong1);
                }
                else MessageBox.Show("Ma Phong Khong Hop Le");
           }
        }
        private void ThemPhongVaoDanhSach(int temp,PHONG phg)
        {
            if (1 == temp) MessageBox.Show("Ma Phong Da Ton Tai");
            else if (2 == temp) MessageBox.Show("Ma Phong da co trong danh sach");
            else if (PHONGBUS.KiemTraLoaiPhong(phg.MaLoaiPhong))
            {
                dataGridView1.Rows.Add(phg.MaPhong, phg.TenPhong, phg.MaLoaiPhong, phg.GhiChu,phg.TinhTrang);
                dsmphg.Add(phg);
                btnXoa.Enabled = true;
                btnOK.Enabled = true;
            }
            else MessageBox.Show("Mã loại phòng không có trong CSDL");
        }
        private void ThemPhong_Load(object sender, EventArgs e)
        {
            //giao dien
            LB_TinhTrang.BackColor = Color.FromArgb(234, 146, 6);
            LB_TenPhong.BackColor = Color.FromArgb(234, 146, 6);
            LB_GhiChu.BackColor = Color.FromArgb(234, 146, 6);
            //
            btnXoa.Enabled = false;
            btnOK.Enabled = false;
            List<LOAIPHONG> dsloai = new List<LOAIPHONG>();
            dsloai = PHONGBUS.LayDSLoaiPhong().ToList();
            if (0 == dsloai.Count)
                MessageBox.Show("không có loại phòng trong cơ sở dữ liệu");
            else
            {
                cmbLoai.Text = dsloai[0].MaLoaiPhong;
                for (int index = 0; index < dsloai.Count; ++index)
                    cmbLoai.Items.Add(dsloai[index].MaLoaiPhong);
            }
            txtMP.TabIndex = 0;
            txtMP.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(index);
                dsmphg.RemoveAt(index);
            }
            catch
            {
                MessageBox.Show("không thể thực hiện"); 
            }
            finally
            {
                if (1 == dataGridView1.Rows.Count)
                {
                    btnXoa.Enabled = false;
                    btnOK.Enabled = false;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < dsmphg.Count; index++)
            {
                
                PHONGBUS.ThemPhong(dsmphg[index]);
            }

            dsmphg.RemoveRange(0, dsmphg.Count);
            dataGridView1.Rows.Clear();
            btnOK.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void BT_ThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BT_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentForm.Visible = true;
            ParentForm.Location = this.Location;
        }

        private void btnXoa_Enter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.GreenYellow;
        }

        private void btnXoa_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.RoyalBlue;
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {

            for (int index = 0; index < dataGridView1.Columns.Count; index++)
            {
                dataGridView1.Columns[index].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[index].HeaderCell.Style.BackColor = Color.Black;
                dataGridView1.Columns[index].HeaderCell.Style.Font = new Font("Consolas", 10, FontStyle.Bold);
            }

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                dataGridView1.Rows[index].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Rows[index].HeaderCell.Style.BackColor = Color.Black;
                dataGridView1.Rows[index].Height = 30;
            }            
        }

        private void txtMP_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.RoyalBlue;
        }

        private void cmbLoai_Enter(object sender, EventArgs e)
        {
            ((ComboBox)sender).BackColor = Color.RoyalBlue;
        }

        private void cmbLoai_Leave(object sender, EventArgs e)
        {
            ((ComboBox)sender).BackColor = Color.OliveDrab;
        }

        private void txtMP_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.OliveDrab;
        }

        private void BT_ThuNho_Enter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Black;
        }

        private void BT_ThuNho_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.OliveDrab;
        }

        private void BT_Thoat_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.DarkRed;
        }
    }
}
