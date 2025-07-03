using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webaplicationdanProject.ASP
{
    public partial class searchASP : System.Web.UI.Page
    {
        public string msg;
        public int s;

        string fileName = General.FileName;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)//הסבר נוסף יבוא
            {
                string month = Request.Form["month"].ToString();//לשנות

                if (month != null)

                {
                    string arg = "%" + "/" + month + "/" + "%";
                    string loginsql = "SELECT * FROM UsersTbl WHERE Birthday like '" + arg + "'";
                    
                    
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
                         GetMyData(table, length);
                            //Response.Redirect("mainASP.aspx");
                        }
                    
                }
            }
        }

        private void GetMyData(DataTable table, int length)
        {
            msg = "<table border='2'  class='tables'> <tr>";
            msg += "<td> firstname</td>";
            msg += "<td> mail</td>";
            msg += "<td> password </td>";                          //  msg += "<td> update user </td>";
            msg += "</tr>";
            for (int i = 0; i < length; i++)
            {
                msg += "<tr>";
                msg += "<td>" + table.Rows[i]["Uname"].ToString() + "</td> ";
                msg += "<td>" + table.Rows[i]["Mail"].ToString() + "</td> ";
                msg += "<td>" + table.Rows[i]["Password"].ToString() + "</td> ";
                msg += "</tr>";
            }
            msg += "</table>";
        }
    }
}