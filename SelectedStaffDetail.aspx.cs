using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridView
{
    public partial class SelectedStaffDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {//Getting object stored in session and display it in <p> tags

            Staff viewObj = (Staff)Session["selectedRow"];
            id.InnerText = "ID: " + viewObj.ID.ToString();
            rollno.InnerText = "EmpNo: " + viewObj.RollNo.ToString();
            name.InnerText = "ID: " + viewObj.Name;
            salary.InnerText = "ID: " + viewObj.Salary;
            address.InnerText = "ID: " + viewObj.Address;
        }
    }
}