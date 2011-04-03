using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BUS;
using DTO;

namespace PTTK_WS
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        //PHONGBUS
        [WebMethod]
        public List<PHONG> pbLayDSPhong()
        {
            return PHONGBUS.LayDSPhong();
        }

        [WebMethod]
        public List<PHONG> pbLayDSPhongTheoLoaiPhong(LOAIPHONG loaiPhong)
        {
            return PHONGBUS.LayDSPhongTheoLoaiPhong(loaiPhong);
        }

        [WebMethod]
        public List<LOAIPHONG> pbLayDSLoaiPhong()
        {
            return PHONGBUS.LayDSLoaiPhong();
        }

        [WebMethod]
        public void pbThemPhong(PHONG phong)
        {
            PHONGBUS.ThemPhong(phong);
        }

        [WebMethod]
        public void pbXoaPhong(string MP)
        {
            PHONGBUS.XoaPhong(MP);
        }
        //PHIEUTHUEBUS
        [WebMethod]
        public bool ptbToiUuPhieuThue()
        {
            //tối ưu các phiếu thuê phòng ở đây.
            return PHIEUTHUEBUS.ptbToiUuPhieuThue();
        }
        [WebMethod]
        public bool ptbThemPhieu(PHIEUTHUE phieu)
        {
            return PHIEUTHUEBUS.ThemPhieu(phieu);
        }
        [WebMethod]
        public List<PHIEUTHUE> ptbLayDSPhieuThueTheoPhong(PHONG phong)
        {
            return PHIEUTHUEBUS.LayDSPhieuThueTheoPhong(phong);
        }
        //KHACHHANGBUS
        [WebMethod]
        public List<KHACHHANG> khbLayDSKhach()
        {
            return KHACHHANGBUS.LayDSKhach();
        }
        //HOADONBUS
        [WebMethod]
        public List<HOADON> hdblayDSHoaDon()
        {
            return HOADONBUS.layDSHoaDon();
        }
    }
}
