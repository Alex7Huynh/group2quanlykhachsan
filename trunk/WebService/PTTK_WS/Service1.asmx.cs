using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using System.Collections.Generic;
using DTO;
using BUS;

namespace PTTK_WS
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
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
        public static bool ptbToiUuPhieuThue()
        {
            //tối ưu các phiếu thuê phòng ở đây.
            return true;
        }
        [WebMethod]
        public static bool ptbThemPhieu(PHIEUTHUE phieu)
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
