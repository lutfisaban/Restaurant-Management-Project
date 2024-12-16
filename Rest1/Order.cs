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
    public partial class Orders : Form
    {
        Foods c = new Foods();

        public Orders(bool isAdmin)
        {
            InitializeComponent();
            c.Foodss(Total);
            this.Paint += new System.Windows.Forms.PaintEventHandler(Orders_Paint);

            History.Visible = isAdmin;
            Database.Visible = isAdmin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            c.Save_Client(client);
            client = null;
            listView1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.Clear(listView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {
                int index = listView1.Items.IndexOf(eachItem);
                c.Delete_Item(listView1, eachItem, index);
            }
        }

        private void History_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
        }

        private void Database_Click(object sender, EventArgs e)
        {
            Foods_Data foods_Data = new Foods_Data();
            foods_Data.Show();
        }

        private void Category_1_Click(object sender, EventArgs e)
        {
            c.Change(this);
            c.ShowFoodButtons(this,  listView1, flowLayoutPanel1, 1);
        }

        private void Category_2_Click(object sender, EventArgs e)
        {
            c.Change(this);
            c.ShowFoodButtons(this, listView1, flowLayoutPanel1, 2);
        }

        private void Category_3_Click(object sender, EventArgs e)
        {
            c.Change(this);
            c.ShowFoodButtons(this, listView1, flowLayoutPanel1, 3);
        }

        private void Category_4_Click(object sender, EventArgs e)
        {
            c.Change(this);
            c.ShowFoodButtons(this, listView1, flowLayoutPanel1, 4);
        }

        private void Category_5_Click(object sender, EventArgs e)
        {
            c.Change(this);
            c.ShowFoodButtons(this, listView1, flowLayoutPanel1, 5);
        }

        private void Category_6_Click(object sender, EventArgs e)
        {
            c.Change(this);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g;

            g = e.Graphics;

            Pen myPen = new Pen(Color.Chocolate);
            myPen.Width = 3;
            g.DrawLine(myPen, 12, 622, 480, 622);
        }

        private void Orders_Paint(object sender, PaintEventArgs e) { }

    }
}
