using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void access_Click(object sender, EventArgs e)
        {
            
            if(user.Text=="" || pass.Text=="")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlCeConnection con = new SqlCeConnection();
                con.ConnectionString = "Data Source=|DataDirectory|\\Database1.sdf;Persist Security Info=False;";
                SqlCeCommand cmd = new SqlCeCommand("Select * from Profesor where Usuario=@username and Contraseña=@password",con);
                cmd.Parameters.AddWithValue("@username",user.Text);
                cmd.Parameters.AddWithValue("@password", pass.Text);
                con.Open();
                SqlCeDataAdapter adapt = new SqlCeDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    Principal prin = new Principal();
                    prin.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void form1_FormClosing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
    }
}
