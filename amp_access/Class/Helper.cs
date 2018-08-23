using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace amp_access
{
    public class Helper
    {
        public static void AddCORSAllow(HttpContextBase hcb)
        {
            hcb.Response.AppendHeader("AMP-Access-Control-Allow-Source-Origin", string.Format("{0}://{1}", hcb.Request.Url.Scheme, hcb.Request.Url.Authority));
        }

    }
}