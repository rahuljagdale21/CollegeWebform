using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

namespace college
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\RAHUL\source\repos\college\college\App_Data\keerti.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Name, Address, Gender, Age, Contact;
            Name = TextBox1.Text;
            Address = TextBox2.Text;
            Gender = RadioButtonList1.Text;
            Age = TextBox3.Text;
            Contact = TextBox4.Text;

            int a;
            Int64 c;

            a = Convert.ToInt32(Age);
            c = Convert.ToInt64(Contact);

            Label1.Text = Name + " " + Address + " " + Gender + " " + Age + " " + Contact;


            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into vikrant values('" + Name + "','" + Address + "','" + Gender + "','" + a + "','" + c + "')";
            cmd.ExecuteNonQuery();
            con.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            RadioButtonList1.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            Label1.Text = "";
        }
    }
}