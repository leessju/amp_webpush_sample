using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace amp_access
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {

            }
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            string rid = Request["rid"] ?? "";
            string url = Request["url"] ?? "";
            
            if(txtUserID.Text.Equals("test") && txtUserID.Text.Equals("test"))
            {
                Session[rid] = rid;
            }
            else
            {
                Session.Clear();
            }

            Response.Write("<script>window.close();</script>");
        }
    }
}