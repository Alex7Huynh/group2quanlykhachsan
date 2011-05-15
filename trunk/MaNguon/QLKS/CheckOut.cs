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
    public partial class frmCheckOut : Form
    {
        public frmCheckOut()
        {
            InitializeComponent();
        }

        private void rdoTenPhong_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTenPhong.Checked)
            {
                txtTenPhong.ReadOnly = false;
                txtCMND1.ReadOnly = true;
                gbThanhTien.Enabled = false;
            }
            else
            {
                txtTenPhong.ReadOnly = true;
                txtCMND1.ReadOnly = false;
            }
        }

        private void frmCheckOut_Load(object sender, EventArgs e)
        {
            rdoTraPhongDon.Checked = true;
            rdoTenPhong.Checked = true;
        }

        private void rdoTraPhongDon_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTraPhongDon.Checked == true)
            {
                rdoTraPhongDoan.Checked = false;
                gbTraPhongDoan.Enabled = false;
            }
        }

        private void rdoTraPhongDoan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTraPhongDoan.Checked == true)
            {
                rdoTraPhongDon.Checked = false;
                gbTraPhongDon.Enabled = false;
            }
        }

        
    }
}
