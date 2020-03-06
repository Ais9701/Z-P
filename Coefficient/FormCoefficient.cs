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

namespace Zarabotnaya_plata
{
    public partial class FormCoefficient : Form
    {
        public FormCoefficient()
        {
            InitializeComponent();
        }

        private void coefficientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coefficientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zarabotnaya_plataDataSet);

        }

        private void FormCoefficient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zarabotnaya_plataDataSet.Coefficient". При необходимости она может быть перемещена или удалена.
            this.coefficientTableAdapter.Fill(this.zarabotnaya_plataDataSet.Coefficient);

        }

        private void buttAdd_Click(object sender, EventArgs e)
        {
            FormAddCoefficient f14 = new FormAddCoefficient();
            f14.StartPosition = FormStartPosition.CenterScreen;
            f14.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form Manager = Application.OpenForms[1];
            Manager.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Manager.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Manager.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Manager.Show(); // отображаем Form2
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Zarabotnaya_plata;Integrated Security=True");
            connection.Open();
            String queryDelete = "DELETE FROM Coefficient where id_coefficient ='" + id_coefficientTextBox.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(queryDelete, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Коэффициент успешно удален");
        }

        private void FormCoefficient_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
