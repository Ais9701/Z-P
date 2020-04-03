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

        private void buttSave_Click(object sender, EventArgs e)
        {
            coefficientTableAdapter.Update(zarabotnaya_plataDataSet);
            MessageBox.Show("Изменения сохранены в базе данных");
        }

        private void buttDelete_Click(object sender, EventArgs e)
        {
            coefficientDataGridView.Rows.RemoveAt(coefficientDataGridView.CurrentCell.RowIndex);
            coefficientTableAdapter.Update(zarabotnaya_plataDataSet);
            MessageBox.Show("Запись удалена из базы данных");
        }

        private void coefficientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void coefficientDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

        }

        private void FormAddCoefficient_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
