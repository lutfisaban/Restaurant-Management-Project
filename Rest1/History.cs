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
using System.Collections;

namespace Rest1
{
    public partial class History : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\Data\\Selling_Database.accdb");

        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            SellingP();
        }

        private void SellingP()
        {
            ArrayList totals = new ArrayList();
            ArrayList dates = new ArrayList();

            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = ("Select * from SellingP");
            OleDbDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                ListViewItem item = new ListViewItem();
                
                item.Text = read["SellingID"].ToString();
                item.SubItems.Add(read["Total"].ToString());
                item.SubItems.Add("TL");
                item.SubItems.Add(read["Datee"].ToString());

                totals.Add(read["Total"].ToString());
                dates.Add(read["Datee"].ToString());

                listView1.Items.Add(item);
            }
            conn.Close();

            var a = chart1.Series.Add("1");
            var b = chart1.Series.Add("2");
            var c = chart1.Series.Add("3");
            var d = chart1.Series.Add("4");
            var e = chart1.Series.Add("5");

            a.Points.AddXY("", totals[totals.Count - 5]);
            b.Points.AddXY("Last 5 Selling", totals[totals.Count - 4]);
            c.Points.AddXY("Last 5 Selling", totals[totals.Count - 3]);
            d.Points.AddXY("Last 5 Selling", totals[totals.Count - 2]);
            e.Points.AddXY("Last 5 Selling", totals[totals.Count - 1]);


        }
        private void get_process()
        {
            string selected = listView1.SelectedItems[0].Text.ToString();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = ("Select * from Items WHERE SellingID = '" + selected + "'");
            OleDbDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                ListViewItem item = new ListViewItem();

                item.Text = read["Name"].ToString();
                item.SubItems.Add(read["Price"].ToString());
                item.SubItems.Add("TL");
                listView2.Items.Add(item);
            }
            conn.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            if (listView1.SelectedItems.Count > 0) get_process();
        }

    }
}