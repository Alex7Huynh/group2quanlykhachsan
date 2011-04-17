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
    public partial class frmBaoCaoDoanhThu : Form
    {
        public frmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int thang = int.Parse(cmb.Text.Trim());
            List<PHONG> dsphg = new List<PHONG>();
            dsphg =PHONGBUS.LayDSPhong();

            int[] arrDoanhThu = new int[dsphg.Count] ;
            arrDoanhThu = PHONGBUS.LapBaoCaoDoanhThu(thang);

            List<int> dstb = new List<int>();
            dstb = PHONGBUS.layDSThietBiThang(thang);
            dataGridView1.Rows.Clear();
            for(int i=0; i<dsphg.Count;i++)
                dataGridView1.Rows.Add(i+1, dsphg[i].MaPhong, arrDoanhThu[i], dstb[i]);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {

        }
    }
}
