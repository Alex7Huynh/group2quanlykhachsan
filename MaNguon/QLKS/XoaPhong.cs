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
    public partial class XoaPhong : Form
    {
        public XoaPhong()
        {
            InitializeComponent();
        }
        private List<PHONG> dsphg = new List<PHONG>();
        private void XoaPhong_Load(object sender, EventArgs e)
        {
            ReLoad();
        }
        private void ReLoad()
        {
            dtg1.Rows.Clear();
            dsphg = PHONGBUS.LayDSPhong();
            for (int i = 0; i < dsphg.Count; i++)
                if (string.Compare(dsphg[i].DaXoa, "0", true) == 0)
                    dtg1.Rows.Add(dsphg[i].MaPhong,
                        dsphg[i].TenPhong,
                        dsphg[i].MaLoaiPhong,
                        dsphg[i].GhiChu,
                        dsphg[i].TinhTrang);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int index = dtg1.CurrentRow.Index;
            if (index >= 0)
            {
                DialogResult result;
                try
                {
                    string MaPhong = dtg1.Rows[index].Cells[0].Value.ToString();
                    result = MessageBox.Show("BAN CO CHAC LA XOA PHONG NAY", "Canh Bao", MessageBoxButtons.YesNo);
                    if ((result == DialogResult.Yes) && (MaPhong != string.Empty))
                    {
                        PHONGBUS.Xoa(MaPhong);
                        MessageBox.Show("Da Xoa Phong");
                        ReLoad();
                    }
                }
                catch
                {
                    MessageBox.Show("Khong Co Phong de xoa");
                }
            }
        }

        private void dtg1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void dtg1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            ReLoad();
        }
    }
}
