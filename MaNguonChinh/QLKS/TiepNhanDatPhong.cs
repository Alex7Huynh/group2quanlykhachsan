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

        /// <summary>
        /// Hàm xử lý sự kiện FormClosing của màn hình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmManDinhDatPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentForm.Visible = true;
            ParentForm.Location = this.Location;
        }

        List<LOAIPHONG> dsLoaiPhong = new List<LOAIPHONG>();
        List<LOAIKHACH> dsLoaiKhach = new List<LOAIKHACH>();
        ////////////
        //// 0812033 - bien keo tha the hien co phai dat phong do keo tha(chọn phong truc quan) hay khong
        private bool _keoTha;
        private string _maPhongDuocDat; // so phong duoc dat do keo tha
        public TiepNhanDatPhong(bool keoTha, string maPhong)
        {
            InitializeComponent();
            _keoTha = keoTha;
            _maPhongDuocDat = maPhong;
        }
        ////////////////////////

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TiepNhanDatPhong_Load(object sender, EventArgs e)
        {
            //load danh sach loai phong
            try
            {
                txtSoNgay.Text = "1";
                KhoiTaoDanhSachLoaiPhong();
                KhoiTaoDanhSachLoaiKhachHang();
                NhapLieuKhiKeoTha();
                TinhNgayTraPhong();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// nhập liệu cho các dữ liệu form khi đặt phòng từ sơ đồ phiếu thuê
        /// </summary>
        private void NhapLieuKhiKeoTha()
        {
            if (_keoTha)
            {
                LOAIPHONG a = UCDatPhong.ArrLoaiPhong[UCDatPhong.CurrentLoaiPhong];
                cmbLoaiPhong.Text = a.MaLoaiPhong;
                dtpNgayThue.Value = UCXemPhieuThuePhong.Ngaythue;
                int soNgayThue = UCXemPhieuThuePhong.Kethuc.DayOfYear - UCXemPhieuThuePhong.Ngaythue.DayOfYear;
                txtSoNgay.Text = (soNgayThue + 1).ToString();
            }
        }
        /// <summary>
        /// Khởi tạo danh sách loại khách hàng cho combobox loại khách hàng
        /// </summary>
        private void KhoiTaoDanhSachLoaiKhachHang()
        {
            dsLoaiKhach = LOAIKHACHBUS.layDSLoaiKhach();
            List<string> str_dsLoaiKhacHang = new List<string>();
            for (int i = 0; i < dsLoaiKhach.Count; i++)
            {
                str_dsLoaiKhacHang.Add(dsLoaiKhach[i].TenLoaiKH);
            }
            cmbLoaiKhacHang.DataSource = str_dsLoaiKhacHang;
        }
        /// <summary>
        /// Khởi tạo danh sách loại phòng cho combobox loại phòng
        /// </summary>
        private void KhoiTaoDanhSachLoaiPhong()
        {
            dsLoaiPhong = PHONGBUS.LayDSLoaiPhong();
            List<string> str_dsLoaiPhong = new List<string>();
            for (int i = 0; i < dsLoaiPhong.Count; i++)
            {
                str_dsLoaiPhong.Add(dsLoaiPhong[i].TenLoaiPhong);
            }
            cmbLoaiPhong.DataSource = str_dsLoaiPhong;
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
            NhomDTO nhom = new NhomDTO();
            int soNguoi = 0;
            int soNguoiLucDau = 0;
            try
            {
                // lay thong tin khach hang
                LayThongTinKhachHang(ref khachHangDaiDien);
                //tao nhom moi
                TaoNhomMoi(khachHangDaiDien, ref nhom);
                // lay thong tin dat phong
                LayThongTinDatPhong(khachHangDaiDien, ref phieuThue, nhom, ref soNguoi, ref soNguoiLucDau);
                if (_keoTha)
                {
                    DatPhongTrucTiep(khachHangDaiDien, phieuThue, nhom);
                }
                else
                {
                    DatPhongCoKiemTra(khachHangDaiDien, phieuThue, nhom, soNguoi, soNguoiLucDau);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Lấy thông tin đặt phòng từ form nhập liệu
        /// </summary>
        /// <param name="khachHangDaiDien">khách hàng đại diện</param>
        /// <param name="phieuThue">phiếu thuê</param>
        /// <param name="nhom">nhóm mới cho phiếu thuê</param>
        /// <param name="soNguoi">số người thuê</param>
        /// <param name="soNguoiLucDau">biến tạm giữ giá trị số người</param>
        private void LayThongTinDatPhong(KHACHHANG khachHangDaiDien, ref PHIEUTHUE phieuThue, NhomDTO nhom, ref int soNguoi, ref int soNguoiLucDau)
        {
            phieuThue.TenKhachHangDaiDien = khachHangDaiDien.HoTen;
            phieuThue.MaNhom = nhom.MaNhom;
            phieuThue.NgayThue = dtpNgayThue.Value.Date;
            try
            {
                phieuThue.SoNgayThue = int.Parse(txtSoNgay.Text.Trim());
            }
            catch (System.Exception ex)
            {
                throw new Exception("Có lỗi ở textbox số ngày");
            }
            phieuThue.MaPhong = dsLoaiPhong[cmbLoaiPhong.SelectedIndex].MaLoaiPhong;
            soNguoi = 0;
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
            soNguoiLucDau = soNguoi;
        }
        /// <summary>
        /// tạo nhóm mới cho phiếu thuê mới
        /// </summary>
        /// <param name="khachHangDaiDien">khách hàng đại diện</param>
        /// <param name="nhom">biến giữ thông tin nhóm</param>
        private static void TaoNhomMoi(KHACHHANG khachHangDaiDien,ref NhomDTO nhom)
        {
            int maNhom = NhomBUS.TuDongLayMaNhom();
            if (maNhom <= 0)
            {
                throw new Exception("Không lấy mã nhóm được");
            }
            nhom.MaNhom = maNhom;
            nhom.MaKhacHang = khachHangDaiDien.MaKH;
        }
        /// <summary>
        /// Lấy thông tin khách hàng từ form nhập liệu
        /// </summary>
        /// <param name="khachHangDaiDien"> biến giữ thông tin khách hàng </param>
        private void LayThongTinKhachHang(ref KHACHHANG khachHangDaiDien)
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
            }
            catch
            {
                throw new Exception("Lỗi đọc dự liệu");
            }
        }
        /// <summary>
        /// Đặt phòng dựa vào sự kiểm tra có phòng trống hay không
        /// </summary>
        /// <param name="khachHangDaiDien"> khách hàng đại diện thuê phòng</param>
        /// <param name="phieuThue">phiếu thuê đang xét</param>
        /// <param name="nhom"> nhóm mới cho phiếu thuê</param>
        /// <param name="soNguoi">số người thuê</param>
        /// <param name="soNguoiLucDau">biến tạm giữ giá trị số người</param>
        private void DatPhongCoKiemTra(KHACHHANG khachHangDaiDien, PHIEUTHUE phieuThue, NhomDTO nhom, int soNguoi, int soNguoiLucDau)
        {
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
        /// <summary>
        /// dặt phòng trực tiếp 
        /// </summary>
        /// <param name="khachHangDaiDien"> khách hàng đại diện thuê phòng</param>
        /// <param name="phieuThue">phiếu thuê đang xét</param>
        /// <param name="nhom"> nhóm mới cho phiếu thuê</param>
        private void DatPhongTrucTiep(KHACHHANG khachHangDaiDien, PHIEUTHUE phieuThue, NhomDTO nhom)
        {
            phieuThue.MaPhong = _maPhongDuocDat;
            try
            {
                string phongDuocDat = "";
                phongDuocDat = PHIEUTHUEBUS.ThemPhieuThue(phieuThue);
                if (phongDuocDat != string.Empty)
                {
                    DialogResult rs = MessageBox.Show("Bạn có muốn đặt phòng " + phieuThue.MaPhong + " không?", "Thông Báo", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        KHACHHANGBUS.ThemKhachHang(khachHangDaiDien);
                        NhomBUS.ThemNhom(nhom);
                        MessageBox.Show("Đặt phòng " + phieuThue.MaPhong + " thành công");
                    }
                    else
                    {
                        PHIEUTHUEBUS.XoaPhieuThue(phongDuocDat);
                    }
                }
                else
                    MessageBox.Show("Khong co phong trong trong thoi gian ban muon thue, vui long dat phong vao ngay khac!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        /// Hàm xử lý sự kiện click của nút Thu nhỏ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_ThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
        /// Hàm xử lý sự kiện MouseLeave của nút thu nhỏ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_ThuNho_MouseLeave(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X + 1, button_temp.Location.Y + 1);
            button_temp.Size = new Size(button_temp.Size.Width - 2, button_temp.Size.Height - 2);
            button_temp.Image = null;
        }

        /// <summary>
        /// Hàm xử lý sự kiện MouseEnter của nút Đặt phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDatPhong_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonDatPhongFocus;
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

        private void dtpNgayThue_ValueChanged(object sender, EventArgs e)
        {
            TinhNgayTraPhong();
        }

        private void txtSoNgay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSoNgay_Leave(object sender, EventArgs e)
        {
            
        }
        private void TinhNgayTraPhong()
        {
            int soNgayThue = 0;
            try
            {
                if (txtSoNgay.Text.Trim()!="")
                {
                    soNgayThue = int.Parse(txtSoNgay.Text.Trim());
                    if (soNgayThue < 1)
                    {
                        throw new Exception();
                    }
                    DateTime ngayTra = dtpNgayThue.Value.AddDays(soNgayThue);
                    txtNgayTra.Text = ngayTra.ToShortDateString();
                }
                
            }
            catch
            {
                MessageBox.Show("Lỗi ở số ngày");
            }
        }
        private void txtSoNgay_ModifiedChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSoNgay_KeyUp(object sender, KeyEventArgs e)
        {
            TinhNgayTraPhong();
        }
    }
}
