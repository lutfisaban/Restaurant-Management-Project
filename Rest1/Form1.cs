using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rest1
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\Data\\Usernames.accdb");

        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void Login_Click_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = ("Select * From Usernames WHERE Username = '" + textBox1.Text.ToString() + "'");
                cmd.Connection = conn;
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["Password"].ToString() == textBox2.Text.ToString())
                    {
                        OpenOrdersForm(true);
                        conn.Close();
                        break;
                    }
                    else
                    {
                        Invalid.Text = "Username or password is Wrong";
                        textBox1.Focus();
                        textBox1.SelectAll();
                        conn.Close();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Invalid.Text = "Username or password is Wrong";
                textBox1.Focus();
                textBox1.SelectAll();
                conn.Close();
            }
        }

        private void OnGuestButtonPress(object sender, EventArgs e)
        {
            OpenOrdersForm(false);
        }

        private void OpenOrdersForm(bool isAdmin)
        {
            Orders ordersForm = new Orders(isAdmin);
            this.Hide();
            ordersForm.Show();
        }
    }
}
