using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using G2_QLKS.WebService;

namespace G2_QLKS
{
    public class WebServiceLoader
    {

        private static WebServiceQLKSSoapClient ws = new WebServiceQLKSSoapClient();

        public static WebService.WebServiceQLKSSoapClient Ws
        {
            get { return WebServiceLoader.ws; }
        }
    }
}
