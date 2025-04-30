using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webaplicationdanProject.ASP
{
    public partial class DeleteUser : System.Web.UI.Page
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
                    message = "delete success";
                    Response.Redirect("mainASP.aspx");
                }
                else
                {
                    message = "delete failed";
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
                string sql = "DELETE FROM UsersTbl WHERE Password= '" + password + "' AND Uname= '" + username + "'";

                //string sql = "INSERT INTO UsersTbl (Uname,Password,Mail) VALUES('" + username + "','" + password + "','" + email + "')";

                Helper.DoQuery(fileName, sql);

                success = 1;
            }

            return success;
        }
    }
}