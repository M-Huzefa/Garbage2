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
            Student stdlist = new Student();
            StudentGridData.DataSource = stdlist.ListGenerator();
            StudentGridData.DataBind();
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
                studentDetail.Add(new Student(1, "huzefa", "main bazar"));
                studentDetail.Add(new Student(2, "huzefa", "main bazar"));
                studentDetail.Add(new Student(3, "huzefa", "main bazar"));
                studentDetail.Add(new Student(4, "huzefa", "main bazar"));
                studentDetail.Add(new Student(5, "huzefa", "main bazar"));
                studentDetail.Add(new Student(6, "huzefa", "main bazar"));
                studentDetail.Add(new Student(7, "huzefa", "main bazar"));
                studentDetail.Add(new Student(8, "huzefa", "main bazar"));
                studentDetail.Add(new Student(9, "huzefa", "main bazar"));
                studentDetail.Add(new Student(10, "huzefa", "main bazar"));
                return studentDetail;
            }
        }
}