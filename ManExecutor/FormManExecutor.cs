using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zarabotnaya_plata.Manager
{
    public partial class FormManExecutor : Form
    {
        public FormManExecutor()
        {
            InitializeComponent();
        }

        private void taskBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.taskBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zarabotnaya_plataDataSet);

        }

        private void FormManExecutor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zarabotnaya_plataDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.zarabotnaya_plataDataSet.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zarabotnaya_plataDataSet.Manager". При необходимости она может быть перемещена или удалена.
            this.managerTableAdapter.Fill(this.zarabotnaya_plataDataSet.Manager);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zarabotnaya_plataDataSet.Task". При необходимости она может быть перемещена или удалена.
            this.taskTableAdapter.Fill(this.zarabotnaya_plataDataSet.Task);

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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.taskTableAdapter.FillBy(this.zarabotnaya_plataDataSet.Task);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
