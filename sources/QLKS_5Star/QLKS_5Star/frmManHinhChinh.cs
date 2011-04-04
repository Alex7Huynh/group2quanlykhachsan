using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKS_5Star
{
    public partial class frmManHinhChinh : Form
    {
        public frmManHinhChinh()
        {
            InitializeComponent();
        }

        private void btn_themPhong_Click(object sender, EventArgs e)
        {
            DatPhong form = new DatPhong();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
