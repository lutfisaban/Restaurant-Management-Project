using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;
using System.Data.OleDb;

namespace Rest1
{
    public class Client
    {
        static ArrayList Names = new ArrayList();
        static ArrayList Prices = new ArrayList();
        static int Total;
        OleDbConnection conn1 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\Data\\Selling_Database.accdb");

        public void Add_Client(ArrayList names, ArrayList prices, int total)
        {
            Names = names;
            Prices = prices;
            Total = total;
        }

        public void Save_Database()
        {
            /*string saved = "";
            for (int i = 0; i < Names.Count; i++)
            {
                saved += Names[i].ToString() + "\n";
            }
            MessageBox.Show(saved);*/

            DateTime dd = DateTime.Now;
            string id = dd.ToString("ddMMHHmmss");

            if ((Names.Count > 0) && (Prices.Count > 0))
            {
                conn1.Open();
                string Command_Text1 = "INSERT INTO SellingP (SellingID,Datee,Total) VALUES " +
                    "('" +  id + "','" + dd.ToString() + "','" + Total.ToString() +  "')";
                OleDbCommand AccessCommand1 = new OleDbCommand(Command_Text1, conn1);
                AccessCommand1.ExecuteNonQuery();
                
                for(int i = 0; i < Names.Count; i++)
                {
                    string Command_Text2 = "INSERT INTO Items (Name,Price,SellingID) VALUES" +
                    "('" + Names[i].ToString() + "','" + Prices[i].ToString() + "','" + id + "')";
                    OleDbCommand AccessCommand2 = new OleDbCommand(Command_Text2, conn1);
                    AccessCommand2.ExecuteNonQuery();
                }

                conn1.Close();
            }
        }
    }
}