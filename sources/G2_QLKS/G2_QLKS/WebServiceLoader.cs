using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using G2_QLKS.WebService;

namespace G2_QLKS
{
    public class WebServiceLoader
    {
        private static WebService.Service1SoapClient ws = new Service1SoapClient();

        public static WebService.Service1SoapClient Ws
        {
            get { return WebServiceLoader.ws; }
        }
    }
}
