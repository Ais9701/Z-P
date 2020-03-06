using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zarabotnaya_plata.Authorization;

namespace Zarabotnaya_plata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0, b = 15, s = 0, d = 15;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (b > 0)
            {
                b--;
                label3.Text = ("Вы заблокированы. Пожалуйста подождите: " + b);
                if (b == 0)
                {
                    b = d;
                    d += 5;
                    timer1.Enabled = false;
                    buttEnter.Enabled = true;
                    label3.Visible = false;
                    buttExit.Enabled = true;
                    label3.Text = "";
                    txtboxlog.Enabled = true;
                    txtboxpas.Enabled = true;
                }
            }
            s++;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttEnter_Click(object sender, EventArgs e)
        {
            try
            {

                string loginUser = txtboxlog.Text;
                string passUser = txtboxpas.Text;
                DB db = new DB();

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand commandZarabotnaya_plata = new SqlCommand("SELECT * FROM [User] WHERE Login = @uL AND Password = @uP AND Role= 'manager'", db.GetConnection());
                commandZarabotnaya_plata.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
                commandZarabotnaya_plata.Parameters.Add("@uP", SqlDbType.VarChar).Value = passUser;
                adapter.SelectCommand = commandZarabotnaya_plata;
                adapter.Fill(table);
                DataTable table1 = new DataTable();
                SqlDataAdapter adapter1 = new SqlDataAdapter();
                SqlCommand commandexecutor = new SqlCommand("SELECT * FROM [User] WHERE Login = @uL AND Password = @uP AND Role = 'executor'", db.GetConnection());
                commandexecutor.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
                commandexecutor.Parameters.Add("@uP", SqlDbType.VarChar).Value = passUser;
                adapter1.SelectCommand = commandexecutor;
                adapter1.Fill(table1);
                if (table.Rows.Count > 0)
                {
                    Form ifrm = new FormManager();
                    ifrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
                    ifrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
                    ifrm.Show(); // отображаем Form2
                    this.Hide(); // скрываем Form1 (this - текущая форма)
                }
                else
                {
                    if (table1.Rows.Count > 0)
                    {
                        Form ifrm = new FormExecutor();
                        ifrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
                        ifrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
                        ifrm.Show(); // отображаем Form2
                        this.Hide(); // скрываем Form1 (this - текущая форма)
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                        txtboxlog.Clear();
                        txtboxpas.Clear();
                        a++;
                        if (a == 3)
                        {
                            a = 0;
                            timer1.Enabled = true;
                            buttEnter.Enabled = false;
                            label3.Visible = true;
                            buttExit.Enabled = false;
                            txtboxlog.Enabled = false;
                            txtboxpas.Enabled = false;
                        }
                    }
                }

            }
            finally { }
        }

        private void buttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
    

            