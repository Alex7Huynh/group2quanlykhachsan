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
    public partial class frmCheckin : Form
    {
        List<PHIEUTHUE> phieuThue = new List<PHIEUTHUE>();
        PHIEUTHUE ptCapNhat = new PHIEUTHUE();
        public frmCheckin()
        {
            InitializeComponent();
            
        }                      

        
    }
}
