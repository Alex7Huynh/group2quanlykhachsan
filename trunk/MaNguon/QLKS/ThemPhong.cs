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
                if (1 == temp) MessageBox.Show("Ma Phong Da Ton Tai");
                else if (2 == temp) MessageBox.Show("Ma Phong da co trong danh sach");
                else if (PHONGBUS.KiemTraLoaiPhong(loaiPhong))
                {
                    dataGridView1.Rows.Add(maPhong, tenPhong, loaiPhong, ghiChu);
                    PHONG phong1 = new PHONG();
                    phong1.MaPhong = maPhong;
                    phong1.TenPhong = tenPhong;
                    phong1.MaLoaiPhong = loaiPhong;
                    phong1.GhiChu = ghiChu;
                    phong1.TinhTrang = tinhTrang;
                    dsmphg.Add(phong1);
                    btnXoa.Enabled = true;
                    btnOK.Enabled = true;
                }
                else MessageBox.Show("Mã loại phòng không có trong CSDL");
           }
        }

        private void ThemPhong_Load(object sender, EventArgs e)
        {
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
