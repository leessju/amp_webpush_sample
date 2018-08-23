using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace amp_access
{
    public partial class Default : System.Web.UI.Page
    {
        public string domain = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            domain = string.Format("{0}://{1}", Request.Url.Scheme, Request.Url.Authority);
            

        }
    }
}