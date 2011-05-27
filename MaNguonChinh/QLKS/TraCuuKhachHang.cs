/*!
 * \file TraCuuKhachHang.cs
 * \brief Thực hiện việc tra cứu khách hàng
 * \author Trần Tấn Kiệt 0812251, Phạm Đăng Khoa 0812234
 * \date 10/5/2011
*/


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
    // <summary>
    /// Quản lý giao diện Tra Cứu Khách Hàng
    /// /author Trần Tấn Kiệt 0812251, Phạm Đăng Khoa 0812234
    /// </summary>
    public partial class TraCuuKhachHang : Form
    {
        // Dành cho di chuyển
        Point startPoint = new Point();

        /// <summary>
        /// Dành cho di chuyển
        /// </summary>
        public Point StartPoint
        {
            get { return startPoint; }
            set { startPoint = value; }
        }

        /// <summary>
        /// Tham chiếu đến Form Cha (MainMenu)
        /// </summary>
        public Form ParentForm;

        /// <summary>
        /// Hàm di chuyển menu
        /// </summary>
        /// <param name="sender">đối tượng gọi</param>
        /// <param name="e">Tham số chuột</param>
        private void PB_MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = new Point(e.X, e.Y);
        }

        /// <summary>
        /// Di chuyển form
        /// </summary>
        /// <param name="distance">khoảng cách cần di chuyển</param>
        public void MoveForm(Point distance)
        {
            this.Location = new Point(this.Location.X + distance.X, this.Location.Y + distance.Y);
        }

        private void PB_MainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MoveForm(new Point(e.X - StartPoint.X, e.Y - StartPoint.Y));
        }

        /// <summary>
        /// Lấy danh sách loại khách để tra cứu
        /// </summary>
        public TraCuuKhachHang()
        {
            InitializeComponent();
            List<LOAIKHACH> dsLoaiKH = new List<LOAIKHACH>();
            try
            {
                dsLoaiKH = LOAIKHACHBUS.layDSLoaiKhach();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi truy xuất dữ liệu\n" + ex.ToString());
            }
            for (int i = 0; i < dsLoaiKH.Count; i++)
            {
                cbLoaiKH.Items.Add(dsLoaiKH[i].TenLoaiKH);
            }
        }
        /// <summary>
        /// Sự kiện thay đổi trong radioButton MaKH
        /// </summary>
        /// <author> 0812251 - Trần Tấn Kiệt</author>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnMaKH_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMaKH.Checked)
                tbMaKH.Enabled = true;
            else
                tbMaKH.Enabled = false;
        }

        /// <summary>
        /// Sự kiện thay đổi trong radioButton HoTen
        /// </summary>
        /// <author> 0812234 - Phạm Đăng Khoa</author>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void rbtnHoTen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnHoTen.Checked)
                tbHoTen.Enabled = true;
            else
                tbHoTen.Enabled = false;
        }

        /// <summary>
        /// Sự kiện thay đổi trong radioButton LoaiKH
        /// </summary>
        ///<author> 0812234 - Phạm Đăng Khoa</author>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void rbtnLoaiKH_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnLoaiKH.Checked)
                cbLoaiKH.Enabled = true;
            else
                cbLoaiKH.Enabled = false;
        }

        /// <summary>
        /// Sự kiện thay đổi trong radioButton SoGiayTo
        /// </summary>
        /// <author> 0812251 - Trần Tấn Kiệt</author>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void rbtnSoGiayTo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSoGiayTo.Checked)
                tbSoGiayTo.Enabled = true;
            else
                tbSoGiayTo.Enabled = false;
        }

        /// <summary>
        /// Sự kiện thay đổi trong radioButton DiaChi
        /// </summary>
        /// <author> 0812251 - Trần Tấn Kiệt</author>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void rbtnDiaChi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDiaChi.Checked)
                tbDiaChi.Enabled = true;
            else
                tbDiaChi.Enabled = false;
        }

        /// <summary>
        /// Thưc hiện việc tra cứu khi ấn nút Tra Cứu
        /// </summary>
        /// <param name="sender">đối tượng gọi thực hiện</param>
        /// <param name="e">tham số của sự kiện click</param>
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            dataGrid_ThongTinKH.Rows.Clear();
            //Nếu tra cứu theo mã khách hàng
            if (tbMaKH.Enabled)
            {
                if (tbMaKH.Text != "")
                {
                    List<KHACHHANG> dsKH = new List<KHACHHANG>();
                    try
                    {
                        dsKH = KHACHHANGBUS.LayDSKhachTheoMaKH(tbMaKH.Text.Trim());
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Quá trình truy vấn xuất hiện lỗi:\n" + ex.ToString());
                    }
                    if (dsKH.Count == 0)
                        MessageBox.Show("Không tìm thấy mã phòng này");
                    else
                        for (int i = 0; i < dsKH.Count; i++)
                            dataGrid_ThongTinKH.Rows.Add(dsKH[i].MaKH, dsKH[i].HoTen, dsKH[i].MaLoaiKH, dsKH[i].SoGiayTo, dsKH[i].DiaChi);
                    return;
                }
            }
            //Nếu tra cứu theo họ tên khách hàng
            if (tbHoTen.Enabled)
            {
                if (tbHoTen.Text != "")
                {
                    List<KHACHHANG> dsKH = new List<KHACHHANG>();
                    try
                    {
                        dsKH = KHACHHANGBUS.LayDSKhachTheoHoTen(tbHoTen.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Quá trình truy vấn xuất hiện lỗi:\n" + ex.ToString());
                    }
                    if (dsKH.Count == 0)
                        MessageBox.Show("Không tìm thấy khách hàng có tên này");
                    else
                        for (int i = 0; i < dsKH.Count; i++)
                            dataGrid_ThongTinKH.Rows.Add(dsKH[i].MaKH, dsKH[i].HoTen, dsKH[i].MaLoaiKH, dsKH[i].SoGiayTo, dsKH[i].DiaChi);
                    return;
                }
            }

            //Nếu tra cứu theo số giấy tờ của khách hàng
            if (tbSoGiayTo.Enabled)
            {
                if (tbSoGiayTo.Text != "")
                {
                    List<KHACHHANG> dsKH = new List<KHACHHANG>();
                    try
                    {
                        dsKH = KHACHHANGBUS.LayDSKhachTheoSoGiayTo(tbSoGiayTo.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Quá trình truy vấn xuất hiện lỗi:\n" + ex.ToString());
                    }
                    if (dsKH.Count == 0)
                        MessageBox.Show("Không tìm thấy khách hàng có số giấy tờ này");
                    else
                        for (int i = 0; i < dsKH.Count; i++)
                            dataGrid_ThongTinKH.Rows.Add(dsKH[i].MaKH, dsKH[i].HoTen, dsKH[i].MaLoaiKH, dsKH[i].SoGiayTo, dsKH[i].DiaChi);
                    return;
                }
            }

            //Nếu tra cứu theo địa chỉ của khách hàng
            if (tbDiaChi.Enabled)
            {
                if (tbDiaChi.Text != "")
                {
                    List<KHACHHANG> dsKH = new List<KHACHHANG>();
                    try
                    {
                        dsKH = KHACHHANGBUS.LayDSKhachTheoDiaChi(tbDiaChi.Text.Trim());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Quá trình truy vấn xuất hiện lỗi:\n" + ex.ToString());
                    }
                    if (dsKH.Count == 0)
                        MessageBox.Show("Không tìm thấy khách hàng có địa chỉ này");
                    else
                        for (int i = 0; i < dsKH.Count; i++)
                            dataGrid_ThongTinKH.Rows.Add(dsKH[i].MaKH, dsKH[i].HoTen, dsKH[i].MaLoaiKH, dsKH[i].SoGiayTo, dsKH[i].DiaChi);
                    return;
                }
            }

            //Nếu tra cứu theo loại khách hàng
            if (cbLoaiKH.Enabled)
            {
                if (cbLoaiKH.Text != "")
                {
                    List<KHACHHANG> dsKH = new List<KHACHHANG>();
                    try
                    {
                        dsKH = KHACHHANGBUS.LayDSKhachTheoLoaiKH(cbLoaiKH.SelectedItem.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Quá trình truy vấn xuất hiện lỗi:\n" + ex.ToString());
                    }
                    if (dsKH.Count == 0)
                        MessageBox.Show("Không tìm thấy khách hàng của loại khách hàng này");
                    else
                        for (int i = 0; i < dsKH.Count; i++)
                            dataGrid_ThongTinKH.Rows.Add(dsKH[i].MaKH, dsKH[i].HoTen, dsKH[i].MaLoaiKH, dsKH[i].SoGiayTo, dsKH[i].DiaChi);
                    return;
                }
            }
        }

        /// <summary>
        /// 0812604 - giao dien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGrid_ThongTinKH_Paint(object sender, PaintEventArgs e)
        {
            for (int index = 0; index < dataGrid_ThongTinKH.Columns.Count; index++)
            {
                dataGrid_ThongTinKH.Columns[index].HeaderCell.Style.ForeColor = Color.White;
                dataGrid_ThongTinKH.Columns[index].HeaderCell.Style.BackColor = Color.Black;
                dataGrid_ThongTinKH.Columns[index].HeaderCell.Style.Font = new Font("Consolas", 9, FontStyle.Bold);
            }

            for (int index = 0; index < dataGrid_ThongTinKH.Rows.Count; index++)
            {
                dataGrid_ThongTinKH.Rows[index].HeaderCell.Style.ForeColor = Color.White;
                dataGrid_ThongTinKH.Rows[index].HeaderCell.Style.BackColor = Color.Black;
                dataGrid_ThongTinKH.Rows[index].Height = 30;
            }
        }
        
        private void TraCuuPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentForm.Visible = true;
            ParentForm.Location = this.Location;
        }

        private void BT_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Thu nhỏ form Tra Cứu Khách Hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_ThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Thoát khỏi giao diện Tra Cứu Khách Hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnTraCuu_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonSearchFocus;
        }

        private void btnQuayLai_MouseEnter(object sender, EventArgs e)
        {
            Button button_temp = (Button)sender;
            button_temp.Location = new Point(button_temp.Location.X - 1, button_temp.Location.Y - 1);
            button_temp.Size = new Size(button_temp.Size.Width + 2, button_temp.Size.Height + 2);
            button_temp.Image = Properties.Resources.ButtonQuayLaiFocus;
        }
    }
}
