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
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDanhSachPhieuThue.Rows.Clear();
                List<NhomDTO> dsNhom = BUS.NhomBUS.LayDSNhomTheoMaKhach(BUS.KHACHHANGBUS.LayKhachTheoSoGiayToChinhXac(txtCMND.Text).MaKH);

                foreach (NhomDTO nhom in dsNhom)
                {
                    List<PHIEUTHUE> dsPt = BUS.PHIEUTHUEBUS.LayDSPhieuThueTheoMaNhom(nhom.MaNhom);
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
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachPhieuThue.SelectedRows.Count == 1)
            {
                if (dgvDanhSachPhieuThue.SelectedRows[0].Cells[1] != null && BUS.PHIEUTHUEBUS.CheckinPhieuThue(dgvDanhSachPhieuThue.SelectedRows[0].Cells[1].Value.ToString()))
                    MessageBox.Show("Checkin thành công");
                else
                    MessageBox.Show("Checkin thất bại");
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
                MessageBox.Show("Checkin tất cả thành công");
            else
                MessageBox.Show("Checkin tất cả thất bại");
        }
        #endregion

        private void btnTim_MouseLeave(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X + 1, button_temp.Location.Y + 1);
            button_temp.Size = new Size(button_temp.Size.Width - 2, button_temp.Size.Height - 2);
            button_temp.Image = null;
        }

        private void btnTim_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonSearchFocus;
        }

        private void btnNhanPhong_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonNhanPhongFocus;
        }

        private void btnNhanHet_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonNhanHetFocus;
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
