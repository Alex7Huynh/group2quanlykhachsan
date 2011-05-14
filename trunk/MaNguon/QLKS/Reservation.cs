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
    public partial class frmReservation : Form
    {
        List<LOAIPHONG> _danhSachLoaiPhong;
        private PHIEUTHUE _phieuThue;

        private DateTime _endDate;

        private DateTime _beginDate;

        public PHIEUTHUE GetPhieuThue()
        {
            return _phieuThue;
        }

        ////////////
        //// 0812033 - bien keo tha the hien co phai dat phong do keo tha(chọn phong truc quan) hay khong
        private bool _keoTha;
        private string _maPhongDuocDat; // so phong duoc dat do keo tha
        public frmReservation(bool keoTha, string maPhong)
        {
            InitializeComponent();
            _keoTha = keoTha;
            _maPhongDuocDat = maPhong;
            _phieuThue = new PHIEUTHUE();
        }
        ////////////////////////

        private void frmReservation_Load(object sender, EventArgs e)
        {
            ////////////////
            ////0812005- load 
            ////////////////
            _danhSachLoaiPhong = PHONGBUS.LayDSLoaiPhong();
            cboLoaiPhong.DataSource = _danhSachLoaiPhong.ToList();
            cboLoaiPhong.DisplayMember = "TenLoaiPhong";
            cboLoaiPhong.ValueMember = "MaLoaiPhong";
            LOAIPHONG a = UCDatPhong.ArrLoaiPhong[UCDatPhong.CurrentLoaiPhong];
             cboLoaiPhong.SelectedValue = a.MaLoaiPhong;
            dtpBeginDate.Value = UCXemPhieuThuePhong.Ngaythue;
            dtpEndDate.Value = UCXemPhieuThuePhong.Kethuc;

            // transparent image
            Bitmap temp = new Bitmap(PB_Image.BackgroundImage);
            temp.MakeTransparent(Color.White);
            PB_Image.BackgroundImage = temp;
        }

        private void cboLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = ((LOAIPHONG)cboLoaiPhong.Items[cboLoaiPhong.SelectedIndex]).DonGia.ToString();
        }

        private void dtpBeginDate_ValueChanged(object sender, EventArgs e)
        {
            _beginDate = dtpBeginDate.Value;
            UpdateDuration();
        }

        private void UpdateDuration()
        {
            int differenceInDays = 0;
            if (_endDate >= _beginDate)
            {
                TimeSpan ts = _endDate - _beginDate;
                differenceInDays = ts.Days + 1;// tôi nghĩ nên cộng thêm một 
            }
            else
            {
                TimeSpan ts = _beginDate - _endDate;
                differenceInDays = ts.Days*-1 - 2;
            }
            txtDuration.Text = differenceInDays.ToString();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            _endDate = dtpEndDate.Value;
            UpdateDuration();
        }

        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            _phieuThue.MaPhong = ((PHONG)cboLoaiPhong.Items[cboLoaiPhong.SelectedIndex]).MaPhong;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        { 
            //0812005
            if (DateTime.Compare(dtpBeginDate.Value.Date, DateTime.Now.Date) < 0)
            {
                MessageBox.Show(" Ngày Bắt đầu thuê không hợp lệ, vui lòng chọn ngày khác");
                dtpBeginDate.Focus();
                return;
            }
            if (DateTime.Compare(dtpEndDate.Value.Date, DateTime.Now.Date) < 0)
            {
                MessageBox.Show(" Ngày kết thúc thuê không hợp lệ, vui lòng chọn ngày khác");
                dtpEndDate.Focus();
                return;
            }
            /*if (CheckInputValue())
            {
                SetInputValue();
                //PHIEUTHUEBUS.ToiUuPhieuThue((LOAIPHONG)cboLoaiPhong.Items[cboLoaiPhong.SelectedIndex]);
                // cho nay can 1 bien ben UCXemphieuthuephong keoTha kieu bool, neu dat phong do keo tha thi them phieu thue lun ko can toi uu
                string phongDuocDat = "";
                if (_keoTha)
                {
                    _phieuThue.MaPhong += _soPhongDuocDat.ToString("000");
                    try
                    {
                        phongDuocDat = PHIEUTHUEBUS.ThemPhieuThue(_phieuThue);
                        if (phongDuocDat != string.Empty)
                        {
                            MessageBox.Show("Da dat phong " + _phieuThue.MaPhong + " thanh cong");
                        }
                        else
                            MessageBox.Show("Khong co phong trong trong thoi gian ban muon thue, vui long dat phong vao ngay khac!");
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        phongDuocDat = PHIEUTHUEBUS.DatPhieuThue(_phieuThue, _danhSachLoaiPhong[cboLoaiPhong.SelectedIndex].MaLoaiPhong);
                        if (phongDuocDat != string.Empty)
                        {
                            MessageBox.Show("Da dat phong " + phongDuocDat.Substring(2, 4) + " thanh cong");
                            //UCXemPhieuThuePhong.
                        }
                        else
                        {
                            MessageBox.Show("Khong co phong trong trong thoi gian ban muon thue, vui long dat phong vao ngay khac!");
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin nhập vào!");
            }*/

            ////0812033
            try
            {
                CheckInputValue();
                SetInputValue();
                //PHIEUTHUEBUS.ToiUuPhieuThue((LOAIPHONG)cboLoaiPhong.Items[cboLoaiPhong.SelectedIndex]);
                // cho nay can 1 bien ben UCXemphieuthuephong keoTha kieu bool, neu dat phong do keo tha thi them phieu thue lun ko can toi uu
                string phongDuocDat = "";
                if (_keoTha)
                {
                    _phieuThue.MaPhong = _maPhongDuocDat;
                    try
                    {
                        phongDuocDat = PHIEUTHUEBUS.ThemPhieuThue(_phieuThue);
                        if (phongDuocDat != string.Empty)
                        {
                            MessageBox.Show("Da dat phong " + _phieuThue.MaPhong + " thanh cong");
                        }
                        else
                            MessageBox.Show("Khong co phong trong trong thoi gian ban muon thue, vui long dat phong vao ngay khac!");
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        phongDuocDat = PHIEUTHUEBUS.DatPhieuThue(_phieuThue, _danhSachLoaiPhong[cboLoaiPhong.SelectedIndex].MaLoaiPhong);
                        if (phongDuocDat != string.Empty)
                        {
                            MessageBox.Show("Da dat phong " + phongDuocDat.Substring(2, 4) + " thanh cong");
                            //UCXemPhieuThuePhong.
                        }
                        else
                        {
                            MessageBox.Show("Khong co phong trong trong thoi gian ban muon thue, vui long dat phong vao ngay khac!");
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            ////end 0812033
        }

        private void SetInputValue()
        {
            
            _phieuThue.MaPhieuThue = "";            //sau nay them
            ////0812033
            _phieuThue.MaPhong = _danhSachLoaiPhong[cboLoaiPhong.SelectedIndex].MaLoaiPhong;
            if (txtTen.Text == "")
            {
                _phieuThue.TenKhachHangDaiDien = " ";
            }
            else
                _phieuThue.TenKhachHangDaiDien = txtTen.Text;
            
            /////////////
            _phieuThue.NgayThue = _beginDate.Date;
            _phieuThue.SoNgayThue = int.Parse(txtDuration.Text);
        }

        private void CheckInputValue()
        {
           /* if (int.Parse(txtDuration.Text) >= 0)
            {
                return true;
            }
            return false;*/
            if (int.Parse(txtDuration.Text) < 0)
            {
                throw new Exception("Ngày đặt phòng không lớn hơn ngày trả.");
            }
        }
    }
}
