using System;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.Data;
using System.IO;

namespace Rest1
{
    public class Foods
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\Data\\Foods_Database.accdb");
        private static ArrayList Food_Names = new ArrayList();
        private static ArrayList Food_Price = new ArrayList();
        private static ArrayList Food_Names_Client = new ArrayList();
        private static ArrayList Food_Price_Client = new ArrayList();
        Button[] buttons = new Button[100];
        Label Totall;

        public void Foodss(Label total)
        {
            Totall = total;
        }
        public void Change(Form f)
        {
            for (int i = 0; i < Food_Names.Count; i++)
            {
                f.Controls.Remove(buttons[i]);
            }
            Food_Names.Clear();
            Food_Price.Clear();
        }
        public void ShowFoodButtons(Form f, ListView LV1,FlowLayoutPanel flowLayoutPanel, int ii)
        {
            conn.Open();
            OleDbCommand AccessCommand = new OleDbCommand();
            AccessCommand.Connection = conn;
            AccessCommand.CommandText = ("Select * from Category_" + ii.ToString());
            OleDbDataReader read = AccessCommand.ExecuteReader();

            while (read.Read())
            {
                Food_Names.Add(read["Name"].ToString());
                Food_Price.Add(read["Price"].ToString());
            }
            conn.Close();

            int Width = 77;
            int Height = 77;
            int Space = 6;
            int BoR = flowLayoutPanel.Size.Width/(Width+Space) + 1;
            int First_Space_X = (flowLayoutPanel.Size.Width - BoR * (Width+Space))/2;
            int First_Space_Y = (flowLayoutPanel.Size.Height - BoR * (Height + Space)) / 2;

            for (int j = 0; j < ((Food_Names.Count / BoR) +1); j++)
            {
                for (int i = 0; i < BoR; i++)
                {
                    if (i + j * BoR == Food_Names.Count)
                        break;
                    int index = i + j * BoR; 

                    Button button1 = new Button();
                    button1.Click += new EventHandler((sender, e) => B_Click(sender, e, LV1, index));
                    button1.Text = Food_Names[index].ToString();
                    button1.Location = new Point(flowLayoutPanel.Location.X + (Width+Space) * i,
                        flowLayoutPanel.Location.Y + (Height + Space) * j);
                    button1.Size = new Size(Width, Height);
                    button1.FlatStyle = FlatStyle.Flat;
                    button1.BackColor = Color.Goldenrod;
                    button1.ForeColor = Color.White;
                    button1.FlatAppearance.BorderSize = 0;
                    f.Controls.Add(button1);
                    button1.BringToFront();
                    buttons[index] = button1;

                    //PictureBox pics = new PictureBox();
                    //pics.Location = new Point(20 + 100 * i, 20 + 100 * j);
                    //pics.Name = "pic";
                    //pics.Size = new Size(90, 50);
                    //pics.ImageLocation = "..\\..\\Data\\Images\\" + index.ToString() + ".png";
                    //f.Controls.Add(pics);
                }
            }
        }

        public void Add_Item(ListView LV1, int index)
        {
            ListViewItem addNew = new ListViewItem();
            addNew.Text = (Food_Names[index].ToString());
            addNew.SubItems.Add(Food_Price[index].ToString());
            addNew.SubItems.Add("TL");
            addNew.Font = new System.Drawing.Font("Times New Roman", 15, System.Drawing.FontStyle.Regular);
            addNew.ForeColor = Color.Chocolate;
            Food_Names_Client.Add(Food_Names[index].ToString());
            Food_Price_Client.Add(Food_Price[index].ToString());
            LV1.Items.Add(addNew);
            Total();
        }

        protected void B_Click(object sender, EventArgs e, ListView LV1, int index)
        {
            Button button = sender as Button;
            Add_Item(LV1, index);
        }

        public void Save_Client(Client client)
        {
            client.Add_Client(Food_Names_Client, Food_Price_Client, Total());
            client.Save_Database();
            Food_Names_Client.Clear();
            Food_Price_Client.Clear();
            Total();
        }

        public void Delete_Item(ListView LV1, ListViewItem index, int i)
        {
            LV1.Items.Remove(index);
            Food_Names_Client.RemoveAt(i);
            Food_Price_Client.RemoveAt(i);
            Total();
        }

        public void Clear(ListView LV1)
        {
            LV1.Items.Clear();
            Food_Names_Client.Clear();
            Food_Price_Client.Clear();
            Total();
        }

        public int Total()
        {
            int sum = 0;
            foreach(string i in Food_Price_Client)
            {
                sum += Convert.ToInt32(i.ToString());
            }
            Totall.Text = sum.ToString();
            return sum;
        }


        public Foods()
        {
        }
    }
}