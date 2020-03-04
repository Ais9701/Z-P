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
using System.Globalization;


namespace Zarabotnaya_plata
{
    public partial class FormAddCoefficient : Form
    {
        public FormAddCoefficient()
        {
            InitializeComponent();
        }

        private void coefficientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coefficientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zarabotnaya_plataDataSet);

        }

        private void FormAddCoefficient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zarabotnaya_plataDataSet.Coefficient". При необходимости она может быть перемещена или удалена.
            this.coefficientTableAdapter.Fill(this.zarabotnaya_plataDataSet.Coefficient);

        }

        private void buttAdd_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Zarabotnaya_plata;Integrated Security=True");
            connection.Open();
            IFormatProvider formatt = new NumberFormatInfo {NumberDecimalSeparator = "."};
            int id_coefficient = int.Parse(id_coefficienttextBox.Text);//эта строчка кода преобразует введенный ID клиента из строкового типа в тип int
            int junior = int.Parse(juniortextBox.Text);
            int middle = int.Parse(middletextBox.Text);
            int senior = int.Parse(seniortextBox.Text);
            // double k_a_p = Convert.ToDouble(k_a_ptextBox.Text, formatt);
            // double k_y_o = Convert.ToDouble(k_y_otextBox.Text, formatt);
            // double k_t_o_s = Convert.ToDouble(k_t_o_stextBox.Text, formatt);
            double k_a_p = double.Parse(k_a_ptextBox.Text.Replace (".",","));
            double k_y_o = double.Parse(k_y_otextBox.Text.Replace(".", ","));
            double k_t_o_s = double.Parse(k_t_o_stextBox.Text.Replace(".", ","));

            //double k_a_p = Convert.ToDouble(k_a_ptextBox.Text, formatt);
            //double k_y_o = Convert.ToDouble(k_y_otextBox.Text, formatt);
            //double k_t_o_s = Convert.ToDouble(k_t_o_stextBox.Text, formatt);
            int k_v = int.Parse(k_vtextBox.Text);
            int k_s = int.Parse(k_stextBox.Text);
            int k_p_d_e = int.Parse(k_p_d_etextBox.Text);
            String querySave = "INSERT INTO Coefficient (id_coefficient, junior, middle, senior, k_a_p, k_y_o, k_t_o_s, k_v, k_s, k_p_d_e) VALUES ('" + id_coefficient + "','" + junior + "','" + middle + "','" + senior + "','" + k_a_p + "','" + k_y_o + "','" + k_t_o_s + "','" + k_v + "','" + k_s + "','" + k_p_d_e + "')";
            //updateCoefficient.Parameters.AddWithValue"(@Ставка", k_a_p);
            SqlDataAdapter SDA = new SqlDataAdapter(querySave, connection);
            SDA.SelectCommand.ExecuteNonQuery();//для проверки правильности внесенных данных
            connection.Close();
            MessageBox.Show("Коэффициент добавлен в базу данных");
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void id_coefficienttextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form Coefficient = Application.OpenForms[2];
            Coefficient.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Coefficient.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Coefficient.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Coefficient.Show(); // отображаем Form2
            this.Hide();
        }

        private void coefficientBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
