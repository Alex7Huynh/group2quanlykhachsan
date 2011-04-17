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
            string MP=txtMP.Text.Trim();
            string TP =txtTen.Text.Trim();
            string LP =cmbLoai.Text.Trim();
            string GC =txtGhiChu.Text.Trim();
            string TT = txtTT.Text.Trim();
            if (MP == "")
                MessageBox.Show("Xin Vui long nhap ma phong");
            else
            {
                for (int i = 0; i < phg.Count; i++)
                {
                    if (string.Compare(MP, phg[i].MaPhong, true) == 0)
                    {
                        temp = 1;
                        break;
                    }
                }
                for (int i = 0; i < dsmphg.Count; i++)
                {
                    if (string.Compare(MP, dsmphg[i].MaPhong, true) == 0)
                    {
                        temp = 2;
                        break;
                    }
                }
                if (temp == 1) MessageBox.Show("Ma Phong Da Ton Tai");
                else if (temp == 2) MessageBox.Show("Ma Phong da co trong danh sach");
                else
                {
                    dataGridView1.Rows.Add(MP, TP, LP, GC);
                    PHONG temp1 = new PHONG();
                    temp1.MaPhong = MP;
                    temp1.TenPhong = TP;
                    temp1.MaLoaiPhong = LP;
                    temp1.GhiChu = GC;
                    temp1.TinhTrang = TT;
                    dsmphg.Add(temp1);
                    btnXoa.Enabled = true;
                    btnOK.Enabled = true;
                }
            }
        }

        private void ThemPhong_Load(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnOK.Enabled = false;
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
                dataGridView1.Rows.RemoveAt(0);
                dsmphg.RemoveAt(0);
            }
            finally
            {
                if (dataGridView1.Rows.Count == 1)
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
            for (int i = 0; i < dsmphg.Count; i++)
            {
                
                PHONGBUS.ThemPhong(dsmphg[i]);
            }

            dsmphg.RemoveRange(0, dsmphg.Count);
            dataGridView1.Rows.Clear();
            btnOK.Enabled = false;
            btnXoa.Enabled = false;
        }
    }
}
