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
    public partial class TiepNhanDatPhong : Form
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

        private void frmManDinhDatPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentForm.Visible = true;
            ParentForm.Location = this.Location;
        }

        List<LOAIPHONG> dsLoaiPhong = new List<LOAIPHONG>();
        List<LOAIKHACH> dsLoaiKhach = new List<LOAIKHACH>();
        public TiepNhanDatPhong()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TiepNhanDatPhong_Load(object sender, EventArgs e)
        {
            //load danh sach loai phong
            try
            {
                dsLoaiPhong = PHONGBUS.LayDSLoaiPhong();
                List<string> str_dsLoaiPhong = new List<string>();
                for (int i = 0; i < dsLoaiPhong.Count; i++)
                {
                    str_dsLoaiPhong.Add(dsLoaiPhong[i].TenLoaiPhong);
                }
                cmbLoaiPhong.DataSource = str_dsLoaiPhong;
                //load danh sach loai khach hang
                dsLoaiKhach = LOAIKHACHBUS.layDSLoaiKhach();
                List<string> str_dsLoaiKhacHang = new List<string>();
                for (int i = 0; i < dsLoaiKhach.Count; i++)
                {
                    str_dsLoaiKhacHang.Add(dsLoaiKhach[i].TenLoaiKH);
                }
                cmbLoaiKhacHang.DataSource = str_dsLoaiKhacHang;
                txtSoNgay.Text = "1";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            // lấy các giá trị của các control
            // lấy khach hang
            KHACHHANG khachHangDaiDien = new KHACHHANG();
            PHIEUTHUE phieuThue = new PHIEUTHUE();
            try
            {
                try
                {
                    khachHangDaiDien.MaKH = KHACHHANGBUS.TuDongLayMaKhachHang();
                    if (txtTenKhachHang.Text == "")
                    {
                        throw new Exception("Chưa nhập tên khách hàng");
                    }
                    khachHangDaiDien.HoTen = txtTenKhachHang.Text.Trim();
                    khachHangDaiDien.DiaChi = txtDiaChi.Text.Trim();
                    if (txtCMND_PassPort.Text == "")
                    {
                        throw new Exception("Chưa nhập CMND/Passport");
                    }
                    khachHangDaiDien.SoGiayTo = txtCMND_PassPort.Text.Trim();
                    khachHangDaiDien.MaLoaiKH = dsLoaiKhach[cmbLoaiKhacHang.SelectedIndex].MaLoaiKH;
                    phieuThue.NgayThue = dtpNgayThue.Value.Date;
                }
                catch
                {
                    throw new Exception("Lỗi đọc dự liệu");
                }

                //tao nhom moi
                NhomDTO nhom = new NhomDTO();
                int maNhom = NhomBUS.TuDongLayMaNhom();


                if (maNhom <= 0)
                {
                    throw new Exception("Không lấy mã nhóm được");
                }
                nhom.MaNhom = maNhom;
                nhom.MaKhacHang = khachHangDaiDien.MaKH;

                // lay thong tin dat phong

                phieuThue.TenKhachHangDaiDien = khachHangDaiDien.HoTen;
                phieuThue.MaNhom = nhom.MaNhom;
                try
                {
                    phieuThue.SoNgayThue = int.Parse(txtSoNgay.Text.Trim());
                }
                catch (System.Exception ex)
                {
                    throw new Exception("Có lỗi ở textbox số ngày");
                }
                phieuThue.MaPhong = dsLoaiPhong[cmbLoaiPhong.SelectedIndex].MaLoaiPhong;
                int soNguoi = 0;
                try
                {
                    soNguoi = int.Parse(txtSoNguoi.Text.Trim());
                }
                catch
                {
                    throw new Exception("số người không phải là số hoặc quá nhiều");
                }
                if (soNguoi < 0)
                    throw new Exception("số người không được âm");
                int soNguoiLucDau = soNguoi;
                // goi ham kiem tra
                try
                {
                    List<string> dsPhieuThueDuocDat = new List<string>();
                    List<string> dsPhongDatDuoc = PHIEUTHUEBUS.KiemTra(phieuThue, ref soNguoi, ref dsPhieuThueDuocDat);
                    DialogResult result;
                    if (dsLoaiPhong.Count > 0)
                    {
                        if (soNguoi <= 0)
                        {
                            result = MessageBox.Show("Phiếu thuê có thể được đặt. Bạn có muốn đặt phiếu thuê này không?", "Thông Báo", MessageBoxButtons.YesNo);
                        }
                        else if (soNguoi != soNguoiLucDau)
                        {
                            result = MessageBox.Show("Phiếu thuê chỉ được đặt cho " + (soNguoiLucDau - soNguoi).ToString() + "người. Xin vui lòng chọn loại phòng khác cho số khách còn lại. Bạn có muốn đặt phiếu thuê này không?", "Thông Báo", MessageBoxButtons.YesNo);
                        }
                        else
                        {
                            result = MessageBox.Show("Loại phòng " + phieuThue.MaPhong + " không còn phòng trống! Vui lòng chọn loại phòng khác.");
                        }
                        if (result == DialogResult.Yes)
                        {
                            KHACHHANGBUS.ThemKhachHang(khachHangDaiDien);
                            NhomBUS.ThemNhom(nhom);
                        }
                        else if (result == DialogResult.No)
                        {
                            PHIEUTHUEBUS.XoaPhieuThue(dsPhieuThueDuocDat);
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BT_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_ThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void BT_ThuNho_MouseLeave(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X + 1, button_temp.Location.Y + 1);
            button_temp.Size = new Size(button_temp.Size.Width - 2, button_temp.Size.Height - 2);
            button_temp.Image = null;
        }

        private void btnDatPhong_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonDatPhongFocus;
        }

        private void btnThoat_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonQuayLaiFocus;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgayThue_ValueChanged(object sender, EventArgs e)
        {
            int soNgayThue = 0;
            try
            {
                soNgayThue = int.Parse(txtSoNgay.Text.Trim());
                if (soNgayThue < 1)
                {
                    throw new Exception();
                }
                DateTime ngayTra = dtpNgayThue.Value.AddDays(soNgayThue);
                txtNgayTra.Text = ngayTra.ToShortDateString();
            }
            catch
            {
            	MessageBox.Show("Lỗi ở số ngày");
            }
        }

        private void txtSoNgay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSoNgay_Leave(object sender, EventArgs e)
        {
            int soNgayThue = 0;
            try
            {
                soNgayThue = int.Parse(txtSoNgay.Text.Trim());
                if (soNgayThue < 1)
                {
                    throw new Exception();
                }
                DateTime ngayTra = dtpNgayThue.Value.AddDays(soNgayThue);
                txtNgayTra.Text = ngayTra.ToShortDateString();
            }
            catch
            {
                MessageBox.Show("Lỗi ở số ngày");
            }
        }

        private void txtSoNgay_ModifiedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
