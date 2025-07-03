using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webaplicationdanProject.Html
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        public string msg;
        public int s;

        string fileName = General.FileName;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)//הסבר נוסף יבוא
            {
                string name = Request.Form["username"].ToString();//לשנות
                string pass = Request.Form["password"].ToString();//לצורך זיהוי 

                if (name != null && pass != null)

                {
                    string loginsql = "SELECT * FROM UsersTbl WHERE Uname = '" + name + "' AND Password = '" + pass + "'";
                    if (Helper.IsExist(fileName, loginsql))
                    {
                        DataTable table = Helper.ExecuteDataTable(fileName, loginsql);
                        int length = table.Rows.Count;
                        if (length == 0)
                        {
                            msg = "אין נרשמים";
                            Response.Redirect("loginASP.aspx");
                        }
                        else
                        {
                            // msg = "welcome " + fname;
                            Session["username"] = table.Rows[0]["Uname"].ToString();//לדייק מול הבסיס נתונים 
                            Session["admin"] = table.Rows[0]["Admin"].ToString();
                            if (Session["admin"].ToString() == "1")
                            {
                                msg = "welcome administrator " + Session["username"].ToString();
                            }
                            else
                            {
                                msg = "welcome " + Session["username"].ToString();
                            }
                            Response.Redirect("mainASP.aspx");
                        }
                    }
                }
            }
        }
    }
}