using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webaplicationdanProject
{
    public partial class master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"].ToString() == "1")//מנהל
            {
                delete.Style.Add("display", "block");
                update.Style.Add("display", "block");
                register.Style.Add("display", "none");
                login.Style.Add("display", "none");
                p1.Style.Add("display", "block");
                p2.Style.Add("display", "block");
                p3.Style.Add("display", "block");
                list.Style.Add("display", "block");
                search.Style.Add("display", "block");
                main.Style.Add("display", "block");
            }
            else if (Session["userName"].ToString() != "visitor")//רשום
            {
                delete.Style.Add("display", "block");
                update.Style.Add("display", "block");
                register.Style.Add("display", "none");
                login.Style.Add("display", "none");
                p1.Style.Add("display", "block");
                p2.Style.Add("display", "block");
                p3.Style.Add("display", "block");
                list.Style.Add("display", "none");
                search.Style.Add("display", "none");
                main.Style.Add("display", "block");
            }
            else//אורח
            {
                delete.Style.Add("display", "none");
                update.Style.Add("display", "none");
                register.Style.Add("display", "block");
                login.Style.Add("display", "block");
                p1.Style.Add("display", "block");
                p2.Style.Add("display", "none");
                p3.Style.Add("display", "none");
                list.Style.Add("display", "none");
                search.Style.Add("display", "none");
                main.Style.Add("display", "block");
            }
        }
    }
}