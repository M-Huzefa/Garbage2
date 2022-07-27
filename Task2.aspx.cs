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
                List<Student> studentList = new Student().ListGenerator();
                Session["Detail"] = studentList;
                BindData();
            }
        }

        void BindData()
        { 
            // Set the data source and bind to the Data Grid control.
            StudentGridData.DataSource = Session["Detail"];
            StudentGridData.DataBind();
        }

        protected void PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            StudentGridData.PageIndex = e.NewPageIndex;
            //Bind data to the GridView control.
            BindData();
        }

        protected void RowEditing(object sender, GridViewEditEventArgs e)
        {
            //Set the edit index.
            StudentGridData.EditIndex = e.NewEditIndex;
            //Bind data to the GridView control.
            BindData();
        }

        protected void RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Reset the edit index.
            StudentGridData.EditIndex = -1;
            //Bind data to the GridView control.
            BindData();
        }

        protected void RowDeleted(Object sender, GridViewDeleteEventArgs e)
        {
            //Retrieve the table from the session object.
            List<Student> removeList = (List<Student>)Session["Detail"];

            //removeList the selected row
            removeList.RemoveAt(e.RowIndex);
            Session["Detail"] = removeList;
            BindData();
        }

        protected void RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //Retrieve the table from the session object.
            List<Student> updatelist = (List<Student>)Session["Detail"];

            //Update the values.
            GridViewRow row = StudentGridData.Rows[e.RowIndex];
            //updatelist[e.RowIndex.DataItemIndex] .Rows[row.DataItemIndex]["Id"] = ((TextBox)(row.Cells[1].Controls[0])).Text;
            //updatelist.Rows[row.DataItemIndex]["Description"] = ((TextBox)(row.Cells[2].Controls[0])).Text;
            //updatelist.Rows[row.DataItemIndex]["IsComplete"] = ((CheckBox)(row.Cells[3].Controls[0])).Checked;

            //Reset the edit index.
            StudentGridData.EditIndex = -1;

            //Bind data to the GridView control.
            BindData();
        }
    }
    class Student
    {
        public int ID { get; set; }
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
        public string Address { get; set; }

        public Student() { }

        public Student(int id, int rollNo, string name, string salary, string address)
        {
            ID = id;
            RollNo = rollNo;
            Name = name;
            Salary = salary;
            Address = address;
        }
        public List<Student> ListGenerator()
        {
            List<Student> studentDetail = new List<Student>();
            string[] names = { "huzefa", "HMH", "Huz", "Daim", "Junaid", "Dry", "Ahmad", "Jinnah", "Ahsan", "Ali", "huzefa", "HMH", "Huz", "Daim", "Junaid", "Dry", "Ahmad", "Jinnah", "Ahsan", "Ali", "huzefa", "HMH", "Huz", "Daim", "Junaid", "Dry", "Ahmad", "Jinnah", "Ahsan", "Ali" };
            string[] addresses = { "faisalabad", "main bazar", "madni town", "lahore", "gujrat", "gujranwala", "samanabad", "lalamusa", "islamabad", "sadiqabad", "faisalabad", "main bazar", "madni town", "lahore", "gujrat", "gujranwala", "samanabad", "lalamusa", "islamabad", "sadiqabad", "faisalabad", "main bazar", "madni town", "lahore", "gujrat", "gujranwala", "samanabad", "lalamusa", "islamabad", "sadiqabad" };
            Random random = new Random();
            for (int count = 0; count < names.Length; count++)
            {
                //string rollNo = count.ToString() + random.Next(1, 100).ToString();
                studentDetail.Add(new Student(Convert.ToInt32((count + 1).ToString() + random.Next(1, 100).ToString()), Convert.ToInt32((count).ToString() + random.Next(101, 200).ToString()), names[count], "$" + random.Next(3000, 7000).ToString(), addresses[count]));
            }
            
            return studentDetail;
        }
    }
}