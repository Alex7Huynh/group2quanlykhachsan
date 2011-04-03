using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using G2_QLKS.WebService;

namespace G2_QLKS
{
    public class WebServiceLoader
    {
        private static WebService.WebService1SoapClient ws = new WebService1SoapClient();

        public static WebService.WebService1SoapClient Ws
        {
            get { return WebServiceLoader.ws; }
        }
    }
}
