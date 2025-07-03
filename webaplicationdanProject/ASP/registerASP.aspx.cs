using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace webaplicationdanProject.Html
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        public string message;
        public int s;

        string fileName = General.FileName;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                s = this.insert();
                if (s > 0)
                {
                    message = "Register success";
                }
                else
                {
                    message = "Register failed";
                }
            }
        }

        private int insert()
        {
            int success = -1;

            string username = Request.Form["username"].ToString();

            string password = Request.Form["password"].ToString();

            string email = Request.Form["email"].ToString();

            DateTime date = DateTime.Parse(Request.Form["date"].ToString());
            string d = date.ToString("dd/MM/yyyy");
            

            if (username != null && password != null && email != null && date != null)
            {
                string sql = "INSERT INTO UsersTbl (Uname,Password,Mail,Birthday) VALUES('" + username + "','" + password + "','" + email + "','" + d + "')";

                //string sql = "INSERT INTO UsersTbl (Uname,Password,Mail) VALUES('" + username + "','" + password + "','" + email + "')";

                Helper.DoQuery(fileName, sql);

                success = 1;
            }

            return success;
        }
    }
}