using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Globalization;

namespace EasyCheck
{
    public partial class EasyCheck : Form
    {
        SQLiteConnection connection;
        SQLiteCommand command;
        const string databaseName = "SPrinter.db3";

        string printerName = "";
        public float total = 0;
        public string Customer = "";
        public List<string[]> rows = new List<string[]>();
        List<List<string[]>> listRows = new List<List<string[]>>();

        public static EasyCheck SelfRef
        {
            get;
            set;
        }

        public EasyCheck()
        {
            InitializeComponent();
            SelfRef = this;
        }

        private void EasyCheck_Load(object sender, EventArgs e)
        {
            command = new SQLiteCommand();
            MyDbConnection();
            MyDbExist();
            MyDbLoadData();
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            bool dot = false;

            string[] split = (sender as TextBox).Text.Split(new Char[] { '.' });
            if (split.Length > 1)
            {
                dot = true;
            }

            if (!dot)
            {
                if ((!Char.IsDigit(number)) && (number != 8) && (number != 46))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if ((!Char.IsDigit(number)) && (number != 8))
                {
                    e.Handled = true;
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            var name = this.Controls["name" + (sender as Button).Tag];
            var price = this.Controls["price" + (sender as Button).Tag];
            var lb = this.Controls["lb" + (sender as Button).Tag] as ListBox;

            if (name.Text != "" && price.Text != "")
            {
                MyDbAddData(int.Parse((sender as Button).Tag.ToString()), name.Text, price.Text);
                lb.Items.Add(name.Text + " (" + price.Text + "р.)");
            }
            else
            {
                MessageBox.Show("Введите название позиции и цену!");
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            var name = this.Controls["name" + (sender as Button).Tag];
            var price = this.Controls["price" + (sender as Button).Tag];
            var lb = this.Controls["lb" + (sender as Button).Tag] as ListBox;

            if (name.Text != "" && price.Text != "")
            {
                if (lb.SelectedIndex != -1)
                {
                    MyDbChangeData(int.Parse((sender as Button).Tag.ToString()), lb.SelectedIndex, name.Text, price.Text);
                    lb.Items[lb.SelectedIndex] = name.Text + " (" + price.Text + "р.)";
                }
                else
                {
                    MessageBox.Show("Нужно выбрать элемент!");
                }
            }
            else
            {
                MessageBox.Show("Введите название позиции и цену!");
            }
        }

        private void lb_MouseClick(object sender, MouseEventArgs e)
        {
            var lb = sender as ListBox;
            var nm = this.Controls["name" + (sender as ListBox).Tag] as TextBox;
            var prc = this.Controls["price" + (sender as ListBox).Tag] as TextBox;

            string name = "";
            string price = "";

            string value = lb.Items[lb.SelectedIndex].ToString();

            string[] split = value.Split(new Char[] { '(' });
            string[] price_spl = split[split.Length - 1].Split(new Char[] { ')' });

            name = value.Substring(0, value.Length - (price_spl[0].Length + 2));
            price = price_spl[0];

            name = name.Substring(0, name.Length - 1);
            price = price.Substring(0, price.Length - 2);

            nm.Text = name;
            prc.Text = price;
        }

        private void lb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string name = "";
            string price = "";

            var lb = sender as ListBox;

            string value = lb.Items[lb.SelectedIndex].ToString();

            string[] split = value.Split(new Char[] { '(' });
            string[] price_spl = split[split.Length - 1].Split(new Char[] { ')' });

            name = value.Substring(0, value.Length - (price_spl[0].Length + 2));
            price = price_spl[0];

            name = name.Substring(0, name.Length - 1);
            price = price.Substring(0, price.Length - 2);

            AddValueToCheck(name, price);
        }

        private void del_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Действительно удалить элемент?", "Подтвердите действие", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var lb = this.Controls["lb" + (sender as Button).Tag] as ListBox;

                if (lb.SelectedIndex != -1)
                {
                    int index = int.Parse((sender as Button).Tag.ToString());
                    List<string[]> list = listRows[index - 1];
                    string[] row = list[lb.SelectedIndex];
                    MyDbDeleteData(index, row[2]);

                    lb.Items.RemoveAt(lb.SelectedIndex);
                }
            }
        }

        private void down_Click(object sender, EventArgs e)
        {
            var lb = this.Controls["lb" + (sender as Button).Tag] as ListBox;

            if (lb.SelectedIndex < lb.Items.Count - 1)
            {
                int index = int.Parse((sender as Button).Tag.ToString());

                List<string[]> list = listRows[index - 1];
                string[] row1 = list[lb.SelectedIndex];
                string[] row2 = list[lb.SelectedIndex + 1];

                string _id1 = row2[2];
                string _id2 = row1[2];
                string _name1 = row1[0];
                string _price1 = row1[1];
                string _name2 = row2[0];
                string _price2 = row2[1];

                MyDbChangePosition(index, _id1, _id2, _name1, _price1, _name2, _price2);

                string selItem = lb.Items[lb.SelectedIndex].ToString();
                lb.Items[lb.SelectedIndex] = lb.Items[lb.SelectedIndex + 1].ToString();
                lb.Items[lb.SelectedIndex + 1] = selItem;
                lb.SelectedIndex = lb.SelectedIndex + 1;
            }
        }

        private void up_Click(object sender, EventArgs e)
        {
            var lb = this.Controls["lb" + (sender as Button).Tag] as ListBox;

            if (lb.SelectedIndex > 0)
            {
                int index = int.Parse((sender as Button).Tag.ToString());

                List<string[]> list = listRows[index - 1];
                string[] row1 = list[lb.SelectedIndex];
                string[] row2 = list[lb.SelectedIndex - 1];

                string _id1 = row2[2];
                string _id2 = row1[2];
                string _name1 = row1[0];
                string _price1 = row1[1];
                string _name2 = row2[0];
                string _price2 = row2[1];

                MyDbChangePosition(index, _id1, _id2, _name1, _price1, _name2, _price2);

                string selItem = lb.Items[lb.SelectedIndex].ToString();
                lb.Items[lb.SelectedIndex] = lb.Items[lb.SelectedIndex - 1].ToString();
                lb.Items[lb.SelectedIndex - 1] = selItem;
                lb.SelectedIndex = lb.SelectedIndex - 1;
            }

        }

        private void lb_DoubleClick(object sender, EventArgs e)
        {
            if (lb.SelectedIndex != -1)
            {
                RemoveValueFromCheck(lb.SelectedIndex);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lb.Items.Clear();
            rows.Clear();

            tbCustomer.Text = "";

            CalculateTotalValue();
        }

        private void chUp_Click(object sender, EventArgs e)
        {
            if (lb.SelectedIndex > 0)
            {
                string[] row1 = rows[lb.SelectedIndex];
                string[] row2 = rows[lb.SelectedIndex - 1];

                string value1 = lb.Items[lb.SelectedIndex].ToString();
                string value2 = lb.Items[lb.SelectedIndex - 1].ToString();
                string name1 = row1[0];
                string price1 = row1[1];
                string count1 = row1[2];
                string name2 = row2[0];
                string price2 = row2[1];
                string count2 = row2[2];

                row1[0] = name2;
                row1[1] = price2;
                row1[2] = count2;
                row2[0] = name1;
                row2[1] = price1;
                row2[2] = count1;

                lb.Items[lb.SelectedIndex] = value2;
                lb.Items[lb.SelectedIndex - 1] = value1;

                lb.SelectedIndex -= 1; 
            }
        }

        private void chDown_Click(object sender, EventArgs e)
        {
            if (lb.SelectedIndex < lb.Items.Count - 1)
            {
                string[] row1 = rows[lb.SelectedIndex];
                string[] row2 = rows[lb.SelectedIndex + 1];

                string value1 = lb.Items[lb.SelectedIndex].ToString();
                string value2 = lb.Items[lb.SelectedIndex + 1].ToString();
                string name1 = row1[0];
                string price1 = row1[1];
                string count1 = row1[2];
                string name2 = row2[0];
                string price2 = row2[1];
                string count2 = row2[2];

                row1[0] = name2;
                row1[1] = price2;
                row1[2] = count2;
                row2[0] = name1;
                row2[1] = price1;
                row2[2] = count1;

                lb.Items[lb.SelectedIndex] = value2;
                lb.Items[lb.SelectedIndex + 1] = value1;

                lb.SelectedIndex += 1;
            }
        }

        private void tbCustomer_TextChanged(object sender, EventArgs e)
        {
            Customer = tbCustomer.Text;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmCheck frm_check = new frmCheck();
            frm_check.ShowDialog();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string from_buf = Clipboard.GetText();
            tbCustomer.Text = from_buf;
        }

        private void AddValueToCheck(string name, string price)
        {
            string[] row = { name, price, "1" };

            if (rows.Count > 0)
            {
                for (int i = 0; i < rows.Count; i++)
                {
                    if ((rows[i][0] == name) && (rows[i][1] == price))
                    {
                        int count = int.Parse(rows[i][2]) + 1;
                        float ttl = count * float.Parse(rows[i][1], CultureInfo.InvariantCulture.NumberFormat);
                        rows[i][2] = count.ToString();
                        lb.Items[i] = name + " (" + price + "р.) " + count + "шт. (" + ttl + "р.)";
                        goto calc;
                    }
                }

                rows.Add(row);
                lb.Items.Add(name + " (" + price + "р.)");
            }
            else
            {
                rows.Add(row);
                lb.Items.Add(name + " (" + price + "р.)");
            }

        calc:
            CalculateTotalValue();
        }

        private void RemoveValueFromCheck(int index)
        {
            string[] row = rows[index];
            int count = int.Parse(row[2]);
            if (count > 1)
            {
                count--;
                row[2] = count.ToString();
                if (count > 1)
                {
                    float ttl = count * float.Parse(rows[index][1], CultureInfo.InvariantCulture.NumberFormat);
                    lb.Items[index] = row[0] + " (" + row[1] + "р.) " + count + "шт. (" + ttl + "р.)";
                }
                else
                {
                    lb.Items[index] = row[0] + " (" + row[1] + "р.)";
                }
            }
            else
            {
                rows.RemoveAt(index);
                lb.Items.RemoveAt(index);
            }
            
            CalculateTotalValue();
        }

        private void CalculateTotalValue()
        {
            total = 0;

            if (rows.Count > 0)
            {
                for (int i = 0; i < rows.Count; i++)
                {
                    total += (float.Parse(rows[i][1], CultureInfo.InvariantCulture.NumberFormat) * int.Parse(rows[i][2]));
                }
            }
            else
            {
                total = 0;
            }

            lbTotal.Text = total.ToString() + " р.";
        }

        private void MyDbExist()
        {
            if (!File.Exists(Directory.GetCurrentDirectory() + "/" + databaseName))
            {
                SQLiteConnection.CreateFile(databaseName);
                MyDbQuery("CREATE TABLE [list1] ([id] integer PRIMARY KEY AUTOINCREMENT NOT NULL, [name] char(80) NOT NULL, [price] char(10) NOT NULL);");
                MyDbQuery("CREATE TABLE [list2] ([id] integer PRIMARY KEY AUTOINCREMENT NOT NULL, [name] char(80) NOT NULL, [price] char(10) NOT NULL);");
                MyDbQuery("CREATE TABLE [list3] ([id] integer PRIMARY KEY AUTOINCREMENT NOT NULL, [name] char(80) NOT NULL, [price] char(10) NOT NULL);");
            }
        }

        private void MyDbConnection()
        {
            connection = new SQLiteConnection(string.Format("Data Source={0};", databaseName));
        }

        private void MyDbQuery(string query)
        {
            connection.Open();
            command.CommandText = query;
            command.Connection = connection;
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void MyDbLoadData()
        {
            if (listRows.Count > 0)
            {
                for (int i = 0; i < listRows.Count; i++)
                {
                    listRows[i].Clear();
                }
            }

            for (int i = 0; i < 3; i++)
            {
                string query = "SELECT * FROM list" +  (i + 1) + " ORDER BY id;";
                connection.Open();
                command.CommandText = query;
                command.Connection = connection;
                SQLiteDataReader reader = command.ExecuteReader();

                List<string[]> list = new List<string[]>();
                var lb = this.Controls["lb" + (i + 1)] as ListBox;

                while (reader.Read())
                {
                    string name = reader["name"].ToString();
                    string price = reader["price"].ToString();
                    string id = reader["id"].ToString();

                    string[] row = { name, price, id };

                    lb.Items.Add(name + " (" + price + "р.)");
                    list.Add(row);
                }

                listRows.Add(list);

                reader.Close();
                connection.Close();
            }
        }

        private void MyDbAddData(int list_num, string name, string price)
        {
            connection.Open();
            command.CommandText = "INSERT INTO list" + list_num + " (name, price) VALUES ('" + name + "', '" + price + "');";
            command.CommandText += "\nSELECT last_insert_rowid();";
            command.Connection = connection;
            string id = command.ExecuteScalar().ToString();
            connection.Close();
            
            List<string[]> list = listRows[list_num - 1];
            string[] row = { name, price, id};
            list.Add(row);
        }

        private void MyDbChangeData(int list_num, int index, string name, string price)
        {
            string id;

            List<string[]> list = listRows[list_num - 1];
            string[] row = list[index];
            row[0] = name;
            row[1] = price;

            id = row[2].ToString();

            list[index] = row;

            MyDbQuery("UPDATE list" + list_num + " SET name='" + name + "', price='" + price + "' WHERE id='" + id + "';");
        }

        private void MyDbDeleteData(int list_num, string row_id)
        {
            MyDbQuery("DELETE FROM list" + list_num + " WHERE id = '" + row_id + "';");

            List<string[]> list = listRows[list_num - 1];
            for (int i = 0; i < list.Count; i++)
            {
                string[] row = list[i];
                if (row[2] == row_id)
                {
                    list.RemoveAt(i);
                }
            }
        }

        private void MyDbChangePosition(int list_num, string id1, string id2, string name1, string price1, string name2, string price2)
        {
            MyDbQuery("UPDATE list" + list_num + " SET name = '" + name1 + "', price = '" + price1 + "' WHERE (id = '" + id1 + "');");
            MyDbQuery("UPDATE list" + list_num + " SET name = '" + name2 + "', price = '" + price2 + "' WHERE (id = '" + id2 + "');");

            List<string[]> list = listRows[list_num - 1];

            for (int i = 0; i < list.Count; i++ )
            {
                string[] row = list[i];

                if (row[2] == id1)
                {
                    row[0] = name1;
                    row[1] = price1;
                }

                if (row[2] == id2)
                {
                    row[0] = name2;
                    row[1] = price2;
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F12)
            {
                btnView.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
