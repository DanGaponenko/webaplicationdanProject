using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace webaplicationdanProject.ASP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string message;
        public int s;

        string fileName = General.FileName;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                s = this.Updatename();
                if (s > 0)
                {
                    message = "update success";
                    Response.Redirect("mainASP.aspx");
                }
                else
                {
                    message = "update failed";
                }
            }
        }

        private int Updatename()
        {
            int success = -1;

            string username = Request.Form["username"].ToString();

            string password = Request.Form["password"].ToString();


            if (username != null && password != null)// && date != null)
            {
                string sql = "UPDATE  UsersTbl SET Uname = '" + username + "' WHERE Password= '" + password + "'"; ;

                //string sql = "INSERT INTO UsersTbl (Uname,Password,Mail) VALUES('" + username + "','" + password + "','" + email + "')";

                Helper.DoQuery(fileName, sql);

                success = 1;
            }

            return success;
        }
    }
}