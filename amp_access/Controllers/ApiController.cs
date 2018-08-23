using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Collections.Specialized;

namespace amp_access
{
	public class ApiController : Controller
	{
        public ActionResult AmpAuthorization()
		{
			string json = "";
            Helper.AddCORSAllow(HttpContext);

            string rid = Request["rid"] ?? "";
            string url = Request["url"] ?? "";
            string rf  = Request["ref"] ?? "";
            string ub  = Request["_"] ?? "";

            if(Session[rid] != null)
                json = "{ \"error\": false, \"access\": true, \"subscriber\": true }";
            else
                json = "{ \"error\": true, \"access\": false, \"subscriber\": false }";
			
			return Content(json, "application/json", System.Text.Encoding.UTF8);
		}


        public ActionResult AmpPingback()
		{
			string json = "";
            Helper.AddCORSAllow(HttpContext);
			
			return Content(json, "application/json", System.Text.Encoding.UTF8);
		}

        public ActionResult Logout()
		{
            Helper.AddCORSAllow(HttpContext);

            // 쿠키를 통해 처리
            //string rid = Request["rid"] ?? "";
            //string url = Request["url"] ?? "";

            Session.Clear();

            string url = "/";

            if(Request.Headers["Referer"] != null)
                url = Request.Headers["Referer"].ToString();

            return Redirect(url);
		}

        
	}
}
