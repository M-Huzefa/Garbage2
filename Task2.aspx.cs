using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridView
{
    public partial class Task2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Staff> StaffList = new Staff().ListGenerator();
                Session["Detail"] = StaffList;
                Session["pageSize"] = (StaffGridData.PageSize);
                BindData();
            }

            Session["newPage"] = StaffGridData.PageIndex;
        }

        void BindData()
        {
            // Set the data source and bind to the Data Grid control.
            StaffGridData.DataSource = Session["Detail"];
            StaffGridData.DataBind();
        }

        protected void PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //Set the Page index.
            Session["newPage"] = (e.NewPageIndex);
            StaffGridData.PageIndex = e.NewPageIndex;

            //Bind data to the GridView control.
            BindData();
        }

        protected void RowEditing(object sender, GridViewEditEventArgs e)
        {
            //Set the edit index.
            StaffGridData.EditIndex = e.NewEditIndex;

            //Bind data to the GridView control.
            BindData();
        }

        protected void RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Reset the edit index.
            StaffGridData.EditIndex = -1;

            //Bind data to the GridView control.
            BindData();
        }

        protected void RowDeleted(Object sender, GridViewDeleteEventArgs e)
        {
            //Retrieve the table from the session object. 
            List<Staff> removeList = (List<Staff>)Session["Detail"];

            //remove the selected row
            removeList.RemoveAt(Convert.ToInt32(Session["pageSize"]) * Convert.ToInt32(Session["newPage"]) + e.RowIndex);

            Session["Detail"] = removeList;

            //Bind data to the GridView control.
            BindData();

            label.Text = "Row has been deleted";
        }

        protected void RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //Retrieve the table from the session object.
            List<Staff> updatelist = (List<Staff>)Session["Detail"];

            //Update the values.
            Staff updatingRow = updatelist[Convert.ToInt32(Session["pageSize"]) * Convert.ToInt32(Session["newPage"]) + e.RowIndex];
            updatingRow.ID = Convert.ToInt32(e.NewValues["ID"]);
            updatingRow.RollNo = Convert.ToInt32(e.NewValues["RollNo"]);
            updatingRow.Name = e.NewValues["Name"].ToString();
            updatingRow.Salary = e.NewValues["Salary"].ToString();
            updatingRow.Address = e.NewValues["Address"].ToString();

            Session["Detail"] = updatelist;
            
            //Reset the edit index.
            StaffGridData.EditIndex = -1;

            //Bind data to the GridView control.
            BindData();

            label.Text = "Row has been updated";
        }

        protected void onselectedindexchanging(Object sender, GridViewSelectEventArgs e)
        {
            //Retrieve the table from the session object.
            List<Staff> newRow = (List<Staff>)Session["Detail"];

            Staff selectedRow = newRow[Convert.ToInt32(Session["pageSize"]) * Convert.ToInt32(Session["newPage"]) + e.NewSelectedIndex];

            Session["selectedRow"] = selectedRow;

            Response.Redirect("SelectedStaffDetail.aspx");

        }

        protected void SearchResults(object sender, EventArgs e)
        {
            //Searches for all the objects where the name matches query & displays them on new page 

            string query = textbox.Text;
            List<Staff> searchResults = new List<Staff> { new Staff() };
            List<Staff> list = (List<Staff>)Session["Detail"];

            foreach (Staff obj in list)
            {
                if (obj.Name == query)
                {
                    searchResults.Add(obj);
                }
            }

            Session["search"] = searchResults;
            Response.Redirect("SearchResults.aspx");
        }
    }

    class Staff
    {
        public int ID { get; set; }
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
        public string Address { get; set; }

        public Staff() { }

        public Staff(int id, int rollNo, string name, string salary, string address)
        {
            ID = id;
            RollNo = rollNo;
            Name = name;
            Salary = salary;
            Address = address;
        }
        public List<Staff> ListGenerator()
        {
            List<Staff> StaffDetail = new List<Staff>();
            string[] names = { "huzefa", "HMH", "Huz", "Daim", "Junaid", "Dry", "Ahmad", "Jinnah", "Ahsan", "Ali", "huzefa", "HMH", "Huz", "Daim", "Junaid", "Dry", "Ahmad", "Jinnah", "Ahsan", "Ali", "huzefa", "HMH", "Huz", "Daim", "Junaid", "Dry", "Ahmad", "Jinnah", "Ahsan", "Ali" };
            string[] addresses = { "faisalabad", "main bazar", "madni town", "lahore", "gujrat", "gujranwala", "samanabad", "lalamusa", "islamabad", "sadiqabad", "faisalabad", "main bazar", "madni town", "lahore", "gujrat", "gujranwala", "samanabad", "lalamusa", "islamabad", "sadiqabad", "faisalabad", "main bazar", "madni town", "lahore", "gujrat", "gujranwala", "samanabad", "lalamusa", "islamabad", "sadiqabad" };
            Random random = new Random();
            for (int count = 0; count < names.Length; count++)
            {
                //string rollNo = count.ToString() + random.Next(1, 100).ToString();
                StaffDetail.Add(new Staff(Convert.ToInt32((count + 1).ToString() + random.Next(1, 100).ToString()), Convert.ToInt32((count).ToString() + random.Next(101, 200).ToString()), names[count], "$" + random.Next(3000, 7000).ToString(), addresses[count]));
            }

            return StaffDetail;
        }
    }
}