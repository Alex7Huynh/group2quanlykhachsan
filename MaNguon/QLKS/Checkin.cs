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
        #region 0812388
        /// <summary>
        /// Hàm tìm danh sách thiếu thêu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTim_Click(object sender, EventArgs e)
        {
            KhoiTaoDanhSachPhieuThue();
            
        }

        /// <summary>
        /// Hàm khởi tạo danh sách phiếu thuê
        /// </summary>
        private void KhoiTaoDanhSachPhieuThue()
        {
            dgvDanhSachPhieuThue.Rows.Clear();
            try
            {
                dgvDanhSachPhieuThue.Rows.Clear();
                List<NhomDTO> dsNhom = BUS.NhomBUS.LayDSNhomTheoMaKhach(BUS.KHACHHANGBUS.LayKhachTheoSoGiayToChinhXac(txtCMND.Text).MaKH);

                foreach (NhomDTO nhom in dsNhom)
                {
                    List<PHIEUTHUE> dsPt = BUS.PHIEUTHUEBUS.LayDSPhieuThueChuaCheckinTheoMaNhom(nhom.MaNhom);
                    foreach (PHIEUTHUE pt in dsPt)
                    {
                        dgvDanhSachPhieuThue.Rows.Add(pt.MaPhong, pt.MaPhieuThue, pt.NgayThue, pt.SoNgayThue, pt.TenKhachHangDaiDien);
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Sự kiện thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Sự kiện nhận phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDanhSachPhieuThue.SelectedRows.Count == 1)
                {
                    if (dgvDanhSachPhieuThue.SelectedRows[0].Cells[1] != null && BUS.PHIEUTHUEBUS.CheckinPhieuThue(dgvDanhSachPhieuThue.SelectedRows[0].Cells[1].Value.ToString()))
                    {
                        MessageBox.Show("Checkin thành công");
                        KhoiTaoDanhSachPhieuThue();
                    }
                    else
                        MessageBox.Show("Checkin thất bại");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Phiếu thuê không hợp lệ");
            }
            
        }


       

        private void btnNhanHet_Click(object sender, EventArgs e)
        {
            bool kiemTra = true;
            foreach (DataGridViewRow dgr in dgvDanhSachPhieuThue.Rows)
            {
                if (dgr.Cells[1].Value != null)
                    kiemTra = BUS.PHIEUTHUEBUS.CheckinPhieuThue(dgr.Cells[1].Value.ToString());
            }
            if (kiemTra)
            {
                MessageBox.Show("Checkin tất cả thành công");
                KhoiTaoDanhSachPhieuThue();
            }
            else
                MessageBox.Show("Checkin tất cả thất bại");
        }
        #endregion

        /// <summary>
        /// Sự kiện thoát chuột
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTim_MouseLeave(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X + 1, button_temp.Location.Y + 1);
            button_temp.Size = new Size(button_temp.Size.Width - 2, button_temp.Size.Height - 2);
            button_temp.Image = null;
        }

        /// <summary>
        /// Sự kiện bắt chuột
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTim_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonSearchFocus;
        }

        /// <summary>
        /// Sự kiện nhấn butoon đặt phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNhanPhong_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonNhanPhongFocus;
        }

        /// <summary>
        /// Sự kiện khi enter button Nhận Hết
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNhanHet_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonNhanHetFocus;
        }

        /// <summary>
        /// Sự kiện khi nhấn button Thoát
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
        /// Sự kiện thay đổi trong datagrid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDanhSachPhieuThue_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhSachPhieuThue.SelectedRows.Count == 0 || (dgvDanhSachPhieuThue.SelectedRows.Count == 1 && dgvDanhSachPhieuThue.SelectedRows[0].Cells[0].Value == null))
            {
                btnNhanHet.Enabled = false;
                btnNhanPhong.Enabled = false;
            }
            else
            {
                btnNhanHet.Enabled = true;
                btnNhanPhong.Enabled = true;
            }
        }
    }
}
