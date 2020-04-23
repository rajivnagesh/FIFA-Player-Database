using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FIFA_MANAGEMENT_SYSTEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;



        private string getUsername()
        {
            //fetch data from the database
            con.Open();
            String syntax = "SELECT value From systemTable where Property='UserName'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            string temp = dr[0].ToString();
            con.Close();
            return temp;



            

        }


        private string getPassword()
        {
            //fetch data from the database
            con.Open();
            String syntax = "SELECT value From systemTable where Property='Password'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            string temp = dr[0].ToString();
            con.Close();
            return temp;





        }


        private void Button1_Click(object sender, EventArgs e)
        {
           
            String Uname=getUsername(), Upass=getPassword(), name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;
            if(name.Equals(Uname) && pass.Equals(Upass))
            {
                //login
                //MessageBox.Show("Login Success");
                AppBody obj = new AppBody();
                this.Hide();
                obj.Show();

            }
            else
            {
                //dont login
                MessageBox.Show("Wrong Credentials");
            }

        }
    }
}
