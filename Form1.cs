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
using System.Runtime.Remoting.Messaging;


namespace WindowCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textpass.Text == textcpass.Text)
            {
                string gen = "";
                if(male.Checked == true)
                {
                    gen = male.Text;
                }
                else
                {
                    gen = female.Text;
                }
                SqlConnection con = new SqlConnection("Data Source = DESKTOP-CN59SUH ; Database = EmployeeDB ; user id = sa ; password = 1234");
                con.Open();
                string Q = @"INSERT INTO [dbo].[DETAILS]
                       ([ID]
                       ,[NAME]
                       ,[EMAIL]
                       ,[PASSWORD]
                       ,[MOBILE_NO]
                       ,[GENDER]
                       ,[DESIGNATION]
                       ,[SALARY])
                 VALUES ('" + textid.Text + "','" + textname.Text + "','" + textemail.Text + "','" + textpass.Text + "','" + textpn.Text + "','" + gen + "','" + textdesig.Text + "','" + textsalaey.Text + "')";
                SqlCommand cmd = new SqlCommand(Q, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Details Entered Succesfully...");
                SqlConnection con1 = new SqlConnection("Data Source = DESKTOP-CN59SUH ; Database = EmployeeDB ; user id = sa ; password = 1234");
                string Q1 = @"SELECT [ID]
                          ,[NAME]
                          ,[EMAIL]
                          ,[PASSWORD]
                          ,[MOBILE_NO]
                          ,[GENDER]
                          ,[DESIGNATION]
                          ,[SALARY]
                      FROM [dbo].[DETAILS]";
                SqlCommand cmd1 = new SqlCommand(Q1, con1);
                SqlDataAdapter ada = new SqlDataAdapter(cmd1);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                textid.Text = "";
                textname.Text = "";
                textemail.Text = "";
                textpass.Text = "";
                textcpass.Text = "";
                textpn.Text = "";
                gen = "";
                textdesig.Text = "";
                textsalaey.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDBDataSet1.DETAILS' table. You can move, or remove it, as needed.
            this.dETAILSTableAdapter1.Fill(this.employeeDBDataSet1.DETAILS);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textpass.Text == textcpass.Text)
            {
                string gen = "";
                if (male.Checked == true)
                {
                    gen = male.Text;
                }
                else
                {
                    gen = female.Text;
                }
                SqlConnection con = new SqlConnection("Data Source = DESKTOP-CN59SUH; Database = EmployeeDB ; user id = sa ; password = 1234");
                con.Open();
                string Q = $"UPDATE [dbo].[DETAILS]  SET [ID] = '{textid.Text}' ,[NAME] = '{textname.Text}' ,[EMAIL] = '{textemail.Text}' ,[PASSWORD] = '{textpass.Text}'  ,[MOBILE_NO] = '{textpn.Text}' ,[GENDER] = '{gen}'  ,[DESIGNATION] = '{textdesig.Text}' ,[SALARY] = '{textsalaey.Text}' WHERE [ID] = '{textid.Text}'";
                SqlCommand cmd = new SqlCommand(Q, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Updated Succesfully...");
                SqlConnection con1 = new SqlConnection("Data Source = DESKTOP-CN59SUH ; Database = EmployeeDB ; user id = sa ; password = 1234");
                string Q1 = @"SELECT [ID]
                          ,[NAME]
                          ,[EMAIL]
                          ,[PASSWORD]
                          ,[MOBILE_NO]
                          ,[GENDER]
                          ,[DESIGNATION]
                          ,[SALARY]
                      FROM [dbo].[DETAILS]";
                SqlCommand cmd1 = new SqlCommand(Q1, con1);
                SqlDataAdapter ada = new SqlDataAdapter(cmd1);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                textid.Text = "";
                textname.Text = "";
                textemail.Text = "";
                textpass.Text = "";
                textcpass.Text = "";
                textpn.Text = "";
                gen = "";
                textdesig.Text = "";
                textsalaey.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-CN59SUH; Database = EmployeeDB ; user id = sa ; password = 1234");
            con.Open();
            string Q = $"DELETE FROM [dbo].[DETAILS]  WHERE [ID] = '{textid.Text}'";
            SqlCommand cmd = new SqlCommand(Q, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted Succesfully...");
            SqlConnection con1 = new SqlConnection("Data Source = DESKTOP-CN59SUH ; Database = EmployeeDB ; user id = sa ; password = 1234");
            string Q1 = @"SELECT [ID]
                          ,[NAME]
                          ,[EMAIL]
                          ,[PASSWORD]
                          ,[MOBILE_NO]
                          ,[GENDER]
                          ,[DESIGNATION]
                          ,[SALARY]
                      FROM [dbo].[DETAILS]";
            SqlCommand cmd1 = new SqlCommand(Q1, con1);
            SqlDataAdapter ada = new SqlDataAdapter(cmd1);
            DataSet ds = new DataSet();
            ada.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            textid.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textid.Text = "";
            textname.Text = "";
            textemail.Text = "";
            textpass.Text = "";
            textcpass.Text = "";
            textpn.Text = "";
            textdesig.Text = "";
            textsalaey.Text = "";
        }
    }
}
