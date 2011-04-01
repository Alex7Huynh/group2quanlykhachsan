using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace G2_QLKS
{
    public partial class DieuChinhDanhMucPhong : Form
    {
        public DieuChinhDanhMucPhong()
        {
            InitializeComponent();
        }


        // Nhấn Hủy bỏ
        private void simpleButton_HuyBo_Click(object sender, EventArgs e)
        {
            Close();
        }





        // Nhấn Xác nhận
        // Cập nhật cơ sở dữ liệu và đóng form
        private void simpleButton_XacNhan_Click(object sender, EventArgs e)
        {

        }






        // Nhấn button Xóa phòng
        // Xóa các phòng có mã phòng trùng với mã phòng người dùng nhập trong Datagridview 
        private void simpleButton_XoaPhong_Click(object sender, EventArgs e)
        {

        }





        // Nhấn button Thêm phòng
        // Thêm vào CSDL các phòng người dùng nhập trong Datagridview 
        private void simpleButton_ThemPhong_Click(object sender, EventArgs e)
        {

        }

        
    }
}
