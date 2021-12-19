using MySqlConnector;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Andrey
{
    public partial class Menu : Form
    {
        Point LastPoint;
        public Menu(Form1 form1)
        {
            InitializeComponent();
            listfio.Text = form1.User.FIONepolnoe;
            ReverseLabel(listfio);
            comboBox1.Items.Add("Пользователи");
            comboBox1.Items.Add("Клиент");
            comboBox1.Items.Add("Магаз");
            comboBox1.Items.Add("Поставщик");
            comboBox1.Items.Add("Продукт");
            comboBox1.Items.Add("Работник");
            comboBox1.Items.Add("Тип");
            comboBox1.SelectedValueChanged += ComboBox1_SelectedValueChanged;
            ONE.Visible = false;
            TWO.Visible = false;
            THREE.Visible = false;
            FOUR.Visible = false;
            FIVE.Visible = false;
            SIX.Visible = false;
            SEVEN.Visible = false;
            ONEBOX.Visible = false;
            TWOBOX.Visible = false;
            THREEBOX.Visible = false;
            FOURBOX.Visible = false;
            CREATE.Visible = false;
            UPDATE.Visible = false;
            DELETE.Visible = false;
            FULL1.Visible = false;
            FULL2.Visible = false;
            FULL3.Visible = false;
            FULL4.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

        }
        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem as String == "Пользователи")
            {
                FilDT.DataSource = Database.SECURITY();
                FilDT.Columns[0].Visible = true;
                ONE.Visible = true;
                TWO.Visible = true;
                THREE.Visible = true;
                FOUR.Visible = true;
                FIVE.Visible = true;
                SIX.Visible = true;
                SEVEN.Visible = true;
                ONEBOX.Visible = false;
                TWOBOX.Visible = false;
                THREEBOX.Visible = false;
                FOURBOX.Visible = false;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREEBOX.Text = "";
                FOURBOX.Text = "";
                FULL1.Visible = false;
                FULL2.Visible = false;
                FULL3.Visible = false;
                FULL4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
            }
            if (comboBox1.SelectedItem as String == "Клиент")
            {
                FilDT.DataSource = Database.CLIENT();
                FilDT.Columns[0].Visible = false;
                ONE.Visible = true;
                TWO.Visible = true;
                THREE.Visible = true;
                FOUR.Visible = false;
                FIVE.Visible = false;
                SIX.Visible = false;
                SEVEN.Visible = false;
                ONEBOX.Visible = false;
                TWOBOX.Visible = false;
                THREEBOX.Visible = false;
                FOURBOX.Visible = false;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREEBOX.Text = "";
                FOURBOX.Text = "";
                FULL1.Visible = false;
                FULL2.Visible = false;
                FULL3.Visible = false;
                FULL4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
            }
            if (comboBox1.SelectedItem as String == "Магаз")
            {
                FilDT.DataSource = Database.MAGAZINE();
                FilDT.Columns[0].Visible = false;
                ONE.Visible = true;
                TWO.Visible = false;
                THREE.Visible = false;
                FOUR.Visible = false;
                FIVE.Visible = false;
                SIX.Visible = false;
                SEVEN.Visible = false;
                ONEBOX.Visible = true;
                TWOBOX.Visible = true;
                THREEBOX.Visible = true;
                FOURBOX.Visible = true;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREEBOX.Text = "";
                FOURBOX.Text = "";
                FULL1.Visible = true;
                FULL2.Visible = true;
                FULL3.Visible = true;
                FULL4.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label2.Text = "Тип";
                label3.Text = "Работник";
                label4.Text = "Продукт";
                label5.Text = "Клиент";
                MySqlConnection con1 = new MySqlConnection
              ("server= 127.0.0.1;database=torg; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From tip", con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONEBOX.DataSource = dt1;
                ONEBOX.DisplayMember = "Naim";
                ONEBOX.ValueMember = "ID_Tip";
                MySqlConnection con2 = new MySqlConnection
              ("server= 127.0.0.1;database=torg; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da2 = new MySqlDataAdapter
                    ("Select * From rab", con1);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                TWOBOX.DataSource = dt2;
                TWOBOX.DisplayMember = "FIO";
                TWOBOX.ValueMember = "ID_Rab";
                MySqlConnection con3 = new MySqlConnection
              ("server= 127.0.0.1;database=torg; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da3 = new MySqlDataAdapter
                    ("Select * From product", con1);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                THREEBOX.DataSource = dt3;
                THREEBOX.DisplayMember = "Naim";
                THREEBOX.ValueMember = "ID_Product";
                MySqlConnection con4 = new MySqlConnection
              ("server= 127.0.0.1;database=torg; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da4 = new MySqlDataAdapter
                    ("Select * From client", con1);
                DataTable dt4 = new DataTable();
                da4.Fill(dt4);
                FOURBOX.DataSource = dt4;
                FOURBOX.DisplayMember = "FIO";
                FOURBOX.ValueMember = "ID_Client";

            }
            if (comboBox1.SelectedItem as String == "Поставщик")
            {
                FilDT.DataSource = Database.POSTAVSHIK();
                FilDT.Columns[0].Visible = false;
                ONE.Visible = true;
                TWO.Visible = true;
                THREE.Visible = false;
                FOUR.Visible = false;
                FIVE.Visible = false;
                SIX.Visible = false;
                SEVEN.Visible = false;
                ONEBOX.Visible = true;
                TWOBOX.Visible = false;
                THREEBOX.Visible = false;
                FOURBOX.Visible = false;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREEBOX.Text = "";
                FOURBOX.Text = "";
                FULL1.Visible = true;
                FULL2.Visible = false;
                FULL3.Visible = false;
                FULL4.Visible = false;
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label2.Text = "Работник";
                MySqlConnection con1 = new MySqlConnection
               ("server= 127.0.0.1;database=torg; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From rab", con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONEBOX.DataSource = dt1;
                ONEBOX.DisplayMember = "FIO";
                ONEBOX.ValueMember = "ID_Rab";
            }
            if (comboBox1.SelectedItem as String == "Продукт")
            {
                FilDT.DataSource = Database.PRODUCT();
                FilDT.Columns[0].Visible = false;
                ONE.Visible = true;
                TWO.Visible = false;
                THREE.Visible = false;
                FOUR.Visible = false;
                FIVE.Visible = false;
                SIX.Visible = false;
                SEVEN.Visible = false;
                ONEBOX.Visible = true;
                TWOBOX.Visible = false;
                THREEBOX.Visible = false;
                FOURBOX.Visible = false;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREEBOX.Text = "";
                FOURBOX.Text = "";
                FULL1.Visible = true;
                FULL2.Visible = false;
                FULL3.Visible = false;
                FULL4.Visible = false;
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label2.Text = "Поставщик";
                MySqlConnection con1 = new MySqlConnection
               ("server= 127.0.0.1;database=torg; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From postavshik", con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONEBOX.DataSource = dt1;
                ONEBOX.DisplayMember = "Naim";
                ONEBOX.ValueMember = "ID_Postavshik";
            }
            if (comboBox1.SelectedItem as String == "Работник")
            {
                FilDT.DataSource = Database.RAB();
                FilDT.Columns[0].Visible = false;
                ONE.Visible = true;
                TWO.Visible = true;
                THREE.Visible = true;
                FOUR.Visible = false;
                FIVE.Visible = false;
                SIX.Visible = false;
                SEVEN.Visible = false;
                ONEBOX.Visible = false;
                TWOBOX.Visible = false;
                THREEBOX.Visible = false;
                FOURBOX.Visible = false;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREEBOX.Text = "";
                FOURBOX.Text = "";
                FULL1.Visible = false;
                FULL2.Visible = false;
                FULL3.Visible = false;
                FULL4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
            if (comboBox1.SelectedItem as String == "Тип")
            {
                FilDT.DataSource = Database.TIP();
                FilDT.Columns[0].Visible = false;
                ONE.Visible = true;
                TWO.Visible = false;
                THREE.Visible = false;
                FOUR.Visible = false;
                FIVE.Visible = false;
                SIX.Visible = false;
                SEVEN.Visible = false;
                ONEBOX.Visible = false;
                TWOBOX.Visible = false;
                THREEBOX.Visible = false;
                FOURBOX.Visible = false;
                CREATE.Visible = true;
                UPDATE.Visible = true;
                DELETE.Visible = true;
                ONE.Text = "";
                TWO.Text = "";
                THREE.Text = "";
                FOUR.Text = "";
                FIVE.Text = "";
                SIX.Text = "";
                SEVEN.Text = "";
                ONEBOX.Text = "";
                TWOBOX.Text = "";
                THREEBOX.Text = "";
                FOURBOX.Text = "";
                FULL1.Visible = false;
                FULL2.Visible = false;
                FULL3.Visible = false;
                FULL4.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
        }

        private void ReverseLabel(Label label)
        {
            int witdh = label.Width;
            label.Location = new Point(label.Location.X - witdh, label.Location.Y);
            label.TextAlign = ContentAlignment.MiddleRight;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }
        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;

            }
        }

        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {

            LastPoint = new Point(e.X, e.Y);
        }
        int idd;
        private void SECDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idd = Convert.ToInt32(FilDT[0, e.RowIndex].Value);
            if (comboBox1.Text == "Пользователи")
            {
                int id = Convert.ToInt32(FilDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                   ("server=127.0.0.1;database=security; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From sec " +
                    "where ID_SEC=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
                TWO.Text = dt1.Rows[0][2].ToString();
                THREE.Text = dt1.Rows[0][3].ToString();
                FOUR.Text = dt1.Rows[0][4].ToString();
                FIVE.Text = dt1.Rows[0][5].ToString();
                SIX.Text = dt1.Rows[0][6].ToString();
                SEVEN.Text = dt1.Rows[0][7].ToString();
            }
            if (comboBox1.Text == "Клиент")
            {
                int id = Convert.ToInt32(FilDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                   ("server=127.0.0.1;database=torg; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From client " +
                    "where client.ID_Client=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
                TWO.Text = dt1.Rows[0][2].ToString();
                THREE.Text = dt1.Rows[0][3].ToString();
            }
            if (comboBox1.Text == "Магаз")
            {
                int id = Convert.ToInt32(FilDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                   ("server=127.0.0.1;database=torg; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From magaz " +
                    "where magaz.ID_Magaz=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
                ONEBOX.SelectedValue = dt1.Rows[0][2].ToString();
                TWOBOX.SelectedValue = dt1.Rows[0][3].ToString();
                THREEBOX.SelectedValue = dt1.Rows[0][4].ToString();
                FOURBOX.SelectedValue = dt1.Rows[0][5].ToString();
            }

            if (comboBox1.Text == "Поставщик")
            {

                int id = Convert.ToInt32(FilDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                   ("server=127.0.0.1;database=torg; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From postavshik " +
                    "where postavshik.ID_Postavshik=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
                ONEBOX.SelectedValue = dt1.Rows[0][2].ToString();
                TWO.Text = dt1.Rows[0][3].ToString();
            }
            if (comboBox1.Text == "Продукт")
            {
                int id = Convert.ToInt32(FilDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                   ("server=127.0.0.1;database=torg; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From product " +
                    "where product.ID_Product=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
                ONEBOX.SelectedValue = dt1.Rows[0][2].ToString();


            }
            if (comboBox1.Text == "Работник")
            {
                int id = Convert.ToInt32(FilDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                    ("server= 127.0.0.1;database=torg; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From rab " +
                    "where rab.ID_Rab=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
                TWO.Text = dt1.Rows[0][2].ToString();
                THREE.Text = dt1.Rows[0][3].ToString();
            }
            if (comboBox1.Text == "Тип")
            {
                int id = Convert.ToInt32(FilDT[0, e.RowIndex].Value);
                MySqlConnection con1 = new MySqlConnection
                    ("server= 127.0.0.1;database=torg; Uid=Admin; Pwd=test; SslMode=none; charset=utf8");
                MySqlDataAdapter da1 = new MySqlDataAdapter
                    ("Select * From tip " +
                    "where tip.ID_Tip=" + id, con1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                ONE.Text = dt1.Rows[0][1].ToString();
            }

        }
        private void insertButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Пользователи")
            {
                var q = $"Insert into security.sec(FIO,FIONepolnoe,Dolg,Login,Password,level,Mesto)\n" +
                    $"values ('{ONE.Text}', '{TWO.Text}', '{THREE.Text}', '{FOUR.Text}', '{FIVE.Text}', {SIX.Text}, '{SEVEN.Text}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=security; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.SECURITY();
                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Клиент")
            {
                var q = $"Insert into torg.client(FIO,ADDRES,KONTAKT)\n" +
                    $"values ('{ONE.Text}','{TWO.Text}','{THREE.Text}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=torg; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.CLIENT();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Магаз")
            {
                var q = $"Insert into torg.magaz(Naim,ID_Tip,ID_Rab,ID_Product,ID_Client)\n" +
                    $"values ('{ONE.Text}', '{ONEBOX.SelectedValue}', '{TWOBOX.SelectedValue}', '{THREEBOX.SelectedValue}', '{FOURBOX.SelectedValue}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=torg; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.MAGAZINE();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Поставщик")
            {
                var q = $"Insert into torg.postavshik(Naim,ID_Rab,Kolvo)\n" +
                    $"values ('{ONE.Text}', '{ONEBOX.SelectedValue}', '{TWO.Text}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=torg; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.POSTAVSHIK();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Продукт")
            {
                var q = $"Insert into torg.product(Naim,ID_Postavshik)\n" +
                    $"values ('{ONE.Text}', '{ONEBOX.SelectedValue}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=torg; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.PRODUCT();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Работник")
            {
                var q = $"Insert into torg.rab(FIO,DOLG,KONTAKT)\n" +
                    $"values ('{ONE.Text}','{TWO.Text}','{THREE.Text}')";
                using (var con = new MySqlConnection("server=127.0.0.1;database=torg; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.RAB();
                }

                }
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////
                if (comboBox1.Text == "Тип")
                {
                    var q = $"Insert into torg.tip(Naim)\n" +
                        $"values ('{ONE.Text}')";
                    using (var con = new MySqlConnection("server=127.0.0.1;database=torg; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                    {
                        con.Open();

                        MySqlCommand dt3 = new MySqlCommand(q, con);
                        dt3.ExecuteNonQuery();

                        con.Close();
                        FilDT.DataSource = Database.TIP();

                    }
                }

            }
        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Пользователи")
            {
                var q = $"UPDATE `sec` SET `FIO`='{ONE.Text}',`FIONepolnoe`='{TWO.Text}',`Dolg`='{THREE.Text}',`Login`='{FOUR.Text}',`Password`='{FIVE.Text}',`level`='{SIX.Text}',`Mesto`='{SEVEN.Text}' WHERE ID_SEC = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=security; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.SECURITY();
                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Клиент")
            {
                var q = $"UPDATE `client` SET `FIO`='{ONE.Text}', `ADDRES`='{TWO.Text}', `KONTAKT`='{THREE.Text}' WHERE ID_Client = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=torg; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.CLIENT();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Магаз")
            {

                var q = $"UPDATE `magaz` SET `Naim`='{ONE.Text}', `ID_Tip`='{ONEBOX.SelectedValue}', `ID_Rab`='{TWOBOX.SelectedValue}', `ID_Product`='{THREEBOX.SelectedValue}', `ID_Client`='{FOURBOX.SelectedValue}' WHERE ID_Magaz = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=torg; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.MAGAZINE();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Поставщик")
            {
                var q = $"UPDATE `postavshik` SET `Naim`='{ONE.Text}',`ID_Rab`='{ONEBOX.SelectedValue}', `Kolvo`='{TWO.Text}' WHERE ID_Postavshik = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=torg; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.POSTAVSHIK();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Продукт")
            {
                var q = $"UPDATE `product` SET `Naim`='{ONE.Text}', `ID_Postavshik`='{ONEBOX.SelectedValue}' WHERE ID_Product = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=torg; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.PRODUCT();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Работник")
            {
                var q = $"UPDATE `rab` SET `FIO`='{ONE.Text}', `DOLG`='{TWO.Text}', `KONTAKT`='{THREE.Text}' WHERE ID_Rab = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=torg; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.RAB();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Тип")
            {
                var q = $"UPDATE `tip` SET `Naim`='{ONE.Text}' WHERE ID_Tip = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=torg; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.TIP();

                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Пользователи")
            {
                var q = $"DELETE FROM `sec` WHERE ID_SEC = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=security; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.SECURITY();
                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Клиент")
            {
                var q = $"DELETE FROM `client` WHERE ID_Client = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=torg; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.CLIENT();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Магаз")
            {

                var q = $"DELETE FROM `magaz` WHERE ID_Magaz = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=torg; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.MAGAZINE();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Поставщик")
            {
                var q = $"DELETE FROM `postavshik` WHERE ID_Postavshik = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=torg; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.POSTAVSHIK();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Продукт")
            {
                var q = $"DELETE FROM `product` WHERE ID_Product = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=torg; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.PRODUCT();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Работник")
            {
                var q = $"DELETE FROM `rab` WHERE ID_Rab = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=torg; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.RAB();

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (comboBox1.Text == "Тип")
            {
                var q = $"DELETE FROM `tip` WHERE ID_Tip = {idd}";
                using (var con = new MySqlConnection("server=127.0.0.1;database=torg; Uid=Admin; Pwd=test;SslMode=none;charset=utf8"))
                {
                    con.Open();

                    MySqlCommand dt3 = new MySqlCommand(q, con);
                    dt3.ExecuteNonQuery();

                    con.Close();
                    FilDT.DataSource = Database.TIP();

                }
            }
        }
        }
    }
   
