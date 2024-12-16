using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Rest1
{
    public partial class Foods_Data : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\Data\\Foods_Database.accdb");
        public Foods_Data()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Delete_Foods();
            View_Foods();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            Add_Foods();
            View_Foods();
        }
        private void View_Foods()
        {
            listView1.Items.Clear();

            conn.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = conn;
            try
            {
                command.CommandText = ("Select * from " + comboBox1.Text.ToString());
                OleDbDataReader read = command.ExecuteReader();

                while (read.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = read["Name"].ToString();
                    lvi.SubItems.Add(read["Price"].ToString());
                    listView1.Items.Add(lvi);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select a Category");
                conn.Close();
            }
        }
    
        private void Add_Foods()
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = ("INSERT INTO "+ comboBox1.Text.ToString() + " (Name,Price) VALUES ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "')");
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void Delete_Foods()
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;

            foreach(ListViewItem item in listView1.SelectedItems)
            {
                cmd.CommandText = ("DELETE FROM "+ comboBox1.Text.ToString() + " WHERE Name = '" + item.Text.ToString() + "'");
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        private void View_Food_Click(object sender, EventArgs e)
        {
            View_Foods();
        }
    }
}
