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
    public partial class frmCheckOut : Form
    {

        public frmCheckOut()
        {
            InitializeComponent();
        }

        private void rdoTenPhong_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void frmCheckOut_Load(object sender, EventArgs e)
        {
            string maPhieuThue ="";
            if (UCXemPhieuThuePhong.ColorOfCurrentCell != Color.White)
            {
                maPhieuThue = UCXemPhieuThuePhong.ContentOfCurrentCell;
            
                List<PHIEUTHUE> dsPhieuThue = PHIEUTHUEBUS.LayPhieuThueTheoMa(maPhieuThue);
                if (dsPhieuThue == null)
                    return;

                foreach (PHIEUTHUE phieuThue in dsPhieuThue)
                {
                    if (!phieuThue.DaThanhToan)
                    {
                        int dongia = PHONGBUS.LayDonGiaTheoMa(phieuThue.MaPhong);
                        int thanhtien = dongia * phieuThue.SoNgayThue;
                        dgvDanhSachPhieuThue.Rows.Add(phieuThue.MaPhieuThue, phieuThue.TenKhachHangDaiDien, phieuThue.MaPhong,
                                                      phieuThue.NgayThue.ToString("dd/mm/yyyy"), phieuThue.SoNgayThue,
                                                      dongia, thanhtien);
                    }
                }
            }
        }

        private void rdoTraPhongDon_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdoTraPhongDoan_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            //Bình
            /*try
            {
                if (txtCMND2.Text.Trim() == "")
                {
                    throw new Exception("Bạn chưa nhập số CMND/PassPort");
                }
                string soGiayTo = txtCMND2.Text.Trim();
                string maKhach = KHACHHANGBUS.LayKhachTheoSoGiayToChinhXac(soGiayTo).MaKH;
                List<NhomDTO> dsNhom = NhomBUS.LayDSNhomTheoMaKhach(maKhach);
                List<PHIEUTHUE> dsPt = new List<PHIEUTHUE>();
                foreach (NhomDTO nhom in dsNhom)
                {
                    dsPt = BUS.PHIEUTHUEBUS.LayDSPhieuThueTheoMaNhom(nhom.MaNhom);
                }
                string thanhTien = PHIEUTHUEBUS.TinhTien(dsPt);
                txtThanhTien.Text = thanhTien;
                PHIEUTHUEBUS.TraPhong(dsPt);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

            DialogResult dlr = MessageBox.Show("Bạn có thật sự muốn trả " + dgvDanhSachPhieuThue.SelectedRows.Count.ToString() + " phòng hay không?", "Thông báo", MessageBoxButtons.YesNo);

            if (dlr == DialogResult.No)
                return;
            
            //Phú
            foreach (DataGridViewRow dgvr in dgvDanhSachPhieuThue.SelectedRows)
            {
                try
                {
                    HOADON hd = new HOADON();
                    hd.MaHoaDon = BUS.HOADONBUS.LayMaHoaDon();
                    hd.MaPhieuThue = dgvr.Cells[0].Value.ToString();
                    hd.NgayThanhToan = DateTime.Now;
                    if (kh != null)
                        hd.TenKhachHangThanhToan = kh.HoTen;
                    else
                        hd.TenKhachHangThanhToan = "";
                    hd.Thanhtien = int.Parse(txtTongTien.Text);

                    if (BUS.HOADONBUS.ThemHoaDonMoi(hd))
                    {
                        BUS.PHIEUTHUEBUS.CheckOutPhieuThue(dgvr.Cells[0].Value.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Thêm hóa đơn mới thất bại");
                        break;
                    }
                }
                catch (System.Exception ex)
                {
                    // Chổ này không xử lý vì exception này chỉ xảy ra khi người dùng có chọn dòng trống
                }
            }
            MessageBox.Show("Trả phòng thành công");
            KhoiTaoDanhSachPhieuThue();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        KHACHHANG kh;
        private void btnTim_Click(object sender, EventArgs e)
        {
            
            // Phú
            dgvDanhSachPhieuThue.Rows.Clear();
            kh = BUS.KHACHHANGBUS.LayKhachTheoSoGiayToChinhXac(txtCMND2.Text);
            if (kh == null)
            {
                MessageBox.Show("Không tìm được khách hàng nào có số giấy tờ tùy thân tương ứng");
                return;
            }
            KhoiTaoDanhSachPhieuThue();
        }

        private void KhoiTaoDanhSachPhieuThue()
        {
            try
            {
                dgvDanhSachPhieuThue.Rows.Clear();
                if (kh != null)
                {
                    
                    List<NhomDTO> dsNhom = BUS.NhomBUS.LayDSNhomTheoMaKhach(kh.MaKH);

                    foreach (NhomDTO nhom in dsNhom)
                    {
                        List<PHIEUTHUE> dsPhieuThue = BUS.PHIEUTHUEBUS.LayDSPhieuThueTheoMaNhom(nhom.MaNhom);

                        if (dsPhieuThue.Count == 0)
                        {
                            MessageBox.Show("Không tìm được phiếu thuê nào tương ứng!" + "\n" + "Có thể khách hàng này đã trả phòng rồi.");
                            return;
                        }

                        foreach (PHIEUTHUE phieuthue in dsPhieuThue)
                        {
                            if (!phieuthue.DaThanhToan)
                            {
                                int dongia = BUS.PHONGBUS.LayDonGiaTheoMa(phieuthue.MaPhong);
                                int thanhtien = dongia * phieuthue.SoNgayThue;
                                dgvDanhSachPhieuThue.Rows.Add(phieuthue.MaPhieuThue, phieuthue.TenKhachHangDaiDien, phieuthue.MaPhong, phieuthue.NgayThue.ToString("dd/mm/yyyy"), phieuthue.SoNgayThue, dongia, thanhtien);
                            }
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDanhSachPhieuThue_SelectionChanged(object sender, EventArgs e)
        {
            
            int tongtien = 0;

            /*if (kh == null || dgvDanhSachPhieuThue.SelectedRows.Count == 0 || (dgvDanhSachPhieuThue.SelectedRows.Count == 1 && dgvDanhSachPhieuThue.SelectedRows[0].Cells[0].Value == null))
                btnTraPhong.Enabled = false;
            else
                btnTraPhong.Enabled = true;*/

            foreach (DataGridViewRow dgvr in dgvDanhSachPhieuThue.SelectedRows)
            {
                try
                {
                    tongtien += int.Parse(dgvr.Cells[6].Value.ToString());
                }
                catch (System.Exception ex)
                {
                    // Chổ này không xử lý vì exception này chỉ xảy ra khi người dùng có chọn dòng trống
                }
            }
            txtTongTien.Text = tongtien.ToString();
        }

        private void btnTim_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonSearchFocus;
        }

        private void btnTim_MouseLeave(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X + 1, button_temp.Location.Y + 1);
            button_temp.Size = new Size(button_temp.Size.Width - 2, button_temp.Size.Height - 2);
            button_temp.Image = null;
        }

        private void btnTraPhong_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonTraPhongFocus;
        }

        private void btnThoat_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonQuayLaiFocus;
        }

        
    }
}
