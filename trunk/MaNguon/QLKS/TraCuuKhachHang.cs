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
    public partial class TraCuuKhachHang : Form
    {
        public TraCuuKhachHang()
        {
            InitializeComponent();
        }

        private void rbtnMaKH_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMaKH.Checked)
                tbMaKH.Enabled = true;
            else
                tbMaKH.Enabled = false;
        }

        private void rbtnHoTen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnHoTen.Checked)
                tbHoTen.Enabled = true;
            else
                tbHoTen.Enabled = false;
        }

        private void rbtnLoaiKH_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnLoaiKH.Checked)
                cbLoaiKH.Enabled = true;
            else
                cbLoaiKH.Enabled = false;
        }

        private void rbtnSoGiayTo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSoGiayTo.Checked)
                tbSoGiayTo.Enabled = true;
            else
                tbSoGiayTo.Enabled = false;
        }

        private void rbtnDiaChi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDiaChi.Checked)
                tbDiaChi.Enabled = true;
            else
                tbDiaChi.Enabled = false;
        }

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
        }
    }
}
