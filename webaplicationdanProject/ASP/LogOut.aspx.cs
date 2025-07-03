using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webaplicationdanProject.ASP
{
    public partial class LogOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["username"] = "visitor";
            Session["admin"] = 0;
            Response.Redirect("mainASP.aspx");
        }
    }
}