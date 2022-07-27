using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridView
{
    public partial class Task1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Student stdlist = new Student();
            StudentGridData.DataSource = stdlist.ListGenerator();
            StudentGridData.DataBind();
        }
    }

    class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Student() { }

        public Student(int rollNo, string name, string address)
        {
            RollNo = rollNo;
            Name = name;
            Address = address;
        }

        public List<Student> ListGenerator()
        {
            List<Student> studentDetail = new List<Student>();
            
            string[] names = { "huzefa", "HMH", "Huz", "Daim", "Junaid", "Dry", "Ahmad", "Jinnah", "Ahsan", "Ali" };
            string[] addresses = { "faisalabad", "main bazar", "madni town", "lahore", "gujrat", "gujranwala", "samanabad", "lalamusa", "islamabad", "sadiqabad" };
            
            Random random = new Random();

            for(int count = 0; count < 10; count++)
            {
                //string rollNo = count.ToString() + random.Next(1, 100).ToString();
                studentDetail.Add(new Student(Convert.ToInt32((count+1).ToString() + random.Next(1, 100).ToString()), names[count], addresses[count]));
            }
            return studentDetail;
        }
    }
}
