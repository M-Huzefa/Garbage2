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
            //Set the Page index.
            Session["pageSize"] = (StudentGridData.PageSize);
            Session["newPage"] = (e.NewPageIndex);
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

            //remove the selected row
            removeList.RemoveAt(Convert.ToInt32(Session["pageSize"])*Convert.ToInt32(Session["newPage"]) + e.RowIndex);
            
            Session["Detail"] = removeList;
            BindData();
        }

        protected void RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //Retrieve the table from the session object.
            List<Student> updatelist = (List<Student>)Session["Detail"];

            //Update the values.
            Student updatingRow = updatelist[Convert.ToInt32(Session["pageSize"]) * Convert.ToInt32(Session["newPage"]) + e.RowIndex];
            updatingRow.ID = Convert.ToInt32(e.NewValues["ID"]);
            updatingRow.RollNo = Convert.ToInt32(e.NewValues["RollNo"]);
            updatingRow.Name = e.NewValues["Name"].ToString();
            updatingRow.Salary = e.NewValues["Salary"].ToString();
            updatingRow.Address = e.NewValues["Address"].ToString();
            
            Session["Detail"] = updatelist;
            label.Text = "Row has been updated";

            //Reset the edit index.
            StudentGridData.EditIndex = -1;

            //Bind data to the GridView control.
            BindData();
        }

        protected void RowSelecting(object sender, EventArgs e)
        {
            int sel = StudentGridData.selec;
        }

        //protected void RowCreated(Object sender, GridViewCommandEventArgs e)
        //{
        //    List<Student> insertRow = (List<Student>)Session["Detail"];
        //    Student creatingRow = insertRow[Convert.ToInt32(Session["pageSize"]) * Convert.ToInt32(Session["newPage"]) + Convert.ToInt32(e.CommandArgument)];
        //    creatingRow.ID = Convert.ToInt32(e.CommandSource);
        //    Session["Detail"] = creatingRow;

        //    //Reset the edit index.
        //    StudentGridData.EditIndex = -1;

        //    //Bind data to the GridView control.
        //    BindData();
        //}
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
