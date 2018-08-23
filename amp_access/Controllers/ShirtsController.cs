using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace amp_access.Controllers
{
    public class ShirtsController : Controller
    {
        public ActionResult Test()
		{
			string json = "{ \"items\": [{ \"title\": \"AMP YouTube Channel\", \"url\": \"https://www.youtube.com/channel/UCXPBsjgKKG2HqsKBhWA4uQw\" }, { \"title\": \"AMPproject.org\", \"url\": \"https://www.ampproject.org/\" }, { \"title\": \"AMP By Example\", \"url\": \"https://ampbyexample.com/\" }, { \"title\": \"AMP Start\", \"url\": \"https://ampstart.com/\" } ]}";
            Helper.AddCORSAllow(HttpContext);			
			return Content(json, "application/json", System.Text.Encoding.UTF8);
		}

        public ActionResult SizesAndPrices()
		{
            Helper.AddCORSAllow(HttpContext);

            string sku = Request["sku"] ?? "";
            //string json = "{ \"1001\": { \"sizes\": { \"XS\": 8.99, \"S\": 9.99 }}, \"1002\": { \"sizes\": { \"S\": 10.99, \"M\": 12.99, \"L\": 14.99 }}, \"1010\": { \"sizes\": { \"L\": 11.99, \"XL\": 13.99 } }, \"1014\": { \"sizes\": { \"M\": 7.99, \"L\": 9.99, \"XL\": 11.99 } },\"1015\": { \"sizes\": {\"XS\": 8.99,\"S\": 10.99,\"L\": 15.99}},\"1016\": {\"sizes\": { \"S\": 8.99,\"L\": 14.99, \"XL\": 11.99}}, \"1021\": {\"sizes\": {\"XS\": 8.99,\"S\": 9.99,\"M\": 12.99}},\"1030\": {\"sizes\": { \"M\": 10.99,\"L\": 11.99}}}";

            DataTable dt = new DataTable();
            DataRow dr = null;
            dt.Columns.Add("sku", typeof(string));
            dt.Columns.Add("size", typeof(string));

            dr = dt.NewRow();
            dr["sku"] = "1001";
            dr["size"] = "{ \"sizes\": { \"XS\": 8.99, \"S\": 9.99 }}";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["sku"] = "1002";
            dr["size"] = "{ \"sizes\": { \"S\": 10.99, \"M\": 12.99, \"L\": 14.99 }}";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["sku"] = "1010";
            dr["size"] = "{ \"sizes\": { \"L\": 11.99, \"XL\": 13.99 }}";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["sku"] = "1014";
            dr["size"] = "{ \"sizes\": { \"M\": 7.99, \"L\": 9.99, \"XL\": 11.99 }}";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["sku"] = "1015";
            dr["size"] = "{ \"sizes\": {\"XS\": 8.99,\"S\": 10.99,\"L\": 15.99}}";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["sku"] = "1016";
            dr["size"] = "{\"sizes\": { \"S\": 8.99,\"L\": 14.99, \"XL\": 11.99}}";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["sku"] = "1021";
            dr["size"] = "{\"sizes\": {\"XS\": 8.99,\"S\": 9.99,\"M\": 12.99}}";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["sku"] = "1030";
            dr["size"] = "{\"sizes\": { \"M\": 10.99,\"L\": 11.99}}";
            dt.Rows.Add(dr);

            DataRow[] drC = dt.Select(string.Format("sku = '{0}'" , sku));

            if(drC.Length > 0)
            {
                return Content(drC[0]["size"].ToString(), "application/json", System.Text.Encoding.UTF8);
            }
            
			return Content("{}", "application/json", System.Text.Encoding.UTF8);

		}

        public ActionResult AddToCart()
		{
            if(Request.Params["color"] != null && Request.Params["size"] != null && Request.Params["quantity"] != null)
            {
                HttpContext.Response.StatusCode = 200;
                string json = "{\"color\":\"" + Request.Params["color"].ToString() + "\",\"size\":\"" + Request.Params["size"].ToString() + "\",\"quantity\":\"" + Request.Params["quantity"].ToString() + "\"}";
                return Content(json, "application/json", System.Text.Encoding.UTF8);
            }
            
            HttpContext.Response.StatusCode = 400;
            return Content("{'error': 'Please select a size.'}", "application/json", System.Text.Encoding.UTF8);
        }

    }
}