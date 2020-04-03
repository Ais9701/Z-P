namespace Zarabotnaya_plata
{
    partial class FormProba
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_coefficientLabel;
            System.Windows.Forms.Label juniorLabel;
            System.Windows.Forms.Label middleLabel;
            System.Windows.Forms.Label seniorLabel;
            System.Windows.Forms.Label k_a_pLabel;
            System.Windows.Forms.Label k_y_oLabel;
            System.Windows.Forms.Label k_t_o_sLabel;
            System.Windows.Forms.Label k_vLabel;
            System.Windows.Forms.Label k_sLabel;
            System.Windows.Forms.Label k_p_d_eLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProba));
            this.zarabotnaya_plataDataSet = new Zarabotnaya_plata.Zarabotnaya_plataDataSet();
            this.coefficientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coefficientTableAdapter = new Zarabotnaya_plata.Zarabotnaya_plataDataSetTableAdapters.CoefficientTableAdapter();
            this.tableAdapterManager = new Zarabotnaya_plata.Zarabotnaya_plataDataSetTableAdapters.TableAdapterManager();
            this.coefficientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.coefficientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_coefficientTextBox = new System.Windows.Forms.TextBox();
            this.juniorTextBox = new System.Windows.Forms.TextBox();
            this.middleTextBox = new System.Windows.Forms.TextBox();
            this.seniorTextBox = new System.Windows.Forms.TextBox();
            this.k_a_pTextBox = new System.Windows.Forms.TextBox();
            this.k_y_oTextBox = new System.Windows.Forms.TextBox();
            this.k_t_o_sTextBox = new System.Windows.Forms.TextBox();
            this.k_vTextBox = new System.Windows.Forms.TextBox();
            this.k_sTextBox = new System.Windows.Forms.TextBox();
            this.k_p_d_eTextBox = new System.Windows.Forms.TextBox();
            this.buttAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            id_coefficientLabel = new System.Windows.Forms.Label();
            juniorLabel = new System.Windows.Forms.Label();
            middleLabel = new System.Windows.Forms.Label();
            seniorLabel = new System.Windows.Forms.Label();
            k_a_pLabel = new System.Windows.Forms.Label();
            k_y_oLabel = new System.Windows.Forms.Label();
            k_t_o_sLabel = new System.Windows.Forms.Label();
            k_vLabel = new System.Windows.Forms.Label();
            k_sLabel = new System.Windows.Forms.Label();
            k_p_d_eLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zarabotnaya_plataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientBindingNavigator)).BeginInit();
            this.coefficientBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_coefficientLabel
            // 
            id_coefficientLabel.AutoSize = true;
            id_coefficientLabel.Font = new System.Drawing.Font("Calibri", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_coefficientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            id_coefficientLabel.Location = new System.Drawing.Point(12, 66);
            id_coefficientLabel.Name = "id_coefficientLabel";
            id_coefficientLabel.Size = new System.Drawing.Size(168, 31);
            id_coefficientLabel.TabIndex = 1;
            id_coefficientLabel.Text = "Коэффициент:";
            // 
            // juniorLabel
            // 
            juniorLabel.AutoSize = true;
            juniorLabel.Font = new System.Drawing.Font("Calibri", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            juniorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            juniorLabel.Location = new System.Drawing.Point(12, 108);
            juniorLabel.Name = "juniorLabel";
            juniorLabel.Size = new System.Drawing.Size(234, 31);
            juniorLabel.TabIndex = 3;
            juniorLabel.Text = "Начальный уровень:";
            // 
            // middleLabel
            // 
            middleLabel.AutoSize = true;
            middleLabel.Font = new System.Drawing.Font("Calibri", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            middleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            middleLabel.Location = new System.Drawing.Point(12, 150);
            middleLabel.Name = "middleLabel";
            middleLabel.Size = new System.Drawing.Size(206, 31);
            middleLabel.TabIndex = 5;
            middleLabel.Text = "Средний уровень:";
            // 
            // seniorLabel
            // 
            seniorLabel.AutoSize = true;
            seniorLabel.Font = new System.Drawing.Font("Calibri", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            seniorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            seniorLabel.Location = new System.Drawing.Point(12, 195);
            seniorLabel.Name = "seniorLabel";
            seniorLabel.Size = new System.Drawing.Size(208, 31);
            seniorLabel.TabIndex = 7;
            seniorLabel.Text = "Высокий уровень:";
            // 
            // k_a_pLabel
            // 
            k_a_pLabel.AutoSize = true;
            k_a_pLabel.Font = new System.Drawing.Font("Calibri", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            k_a_pLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            k_a_pLabel.Location = new System.Drawing.Point(12, 241);
            k_a_pLabel.Name = "k_a_pLabel";
            k_a_pLabel.Size = new System.Drawing.Size(463, 31);
            k_a_pLabel.TabIndex = 9;
            k_a_pLabel.Text = "Коэффициент анализа и проектирования:";
            // 
            // k_y_oLabel
            // 
            k_y_oLabel.AutoSize = true;
            k_y_oLabel.Font = new System.Drawing.Font("Calibri", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            k_y_oLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            k_y_oLabel.Location = new System.Drawing.Point(12, 287);
            k_y_oLabel.Name = "k_y_oLabel";
            k_y_oLabel.Size = new System.Drawing.Size(485, 31);
            k_y_oLabel.TabIndex = 11;
            k_y_oLabel.Text = "Коэффициент для установки оборудования:";
            // 
            // k_t_o_sLabel
            // 
            k_t_o_sLabel.AutoSize = true;
            k_t_o_sLabel.Font = new System.Drawing.Font("Calibri", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            k_t_o_sLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            k_t_o_sLabel.Location = new System.Drawing.Point(12, 333);
            k_t_o_sLabel.Name = "k_t_o_sLabel";
            k_t_o_sLabel.Size = new System.Drawing.Size(718, 31);
            k_t_o_sLabel.TabIndex = 13;
            k_t_o_sLabel.Text = "Коэффициент для технического обслуживания и сопровождения:";
            // 
            // k_vLabel
            // 
            k_vLabel.AutoSize = true;
            k_vLabel.Font = new System.Drawing.Font("Calibri", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            k_vLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            k_vLabel.Location = new System.Drawing.Point(12, 383);
            k_vLabel.Name = "k_vLabel";
            k_vLabel.Size = new System.Drawing.Size(267, 31);
            k_vLabel.TabIndex = 15;
            k_vLabel.Text = "Коэффициент времени:";
            // 
            // k_sLabel
            // 
            k_sLabel.AutoSize = true;
            k_sLabel.Font = new System.Drawing.Font("Calibri", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            k_sLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            k_sLabel.Location = new System.Drawing.Point(12, 432);
            k_sLabel.Name = "k_sLabel";
            k_sLabel.Size = new System.Drawing.Size(289, 31);
            k_sLabel.TabIndex = 17;
            k_sLabel.Text = "Коэффициент сложности:";
            // 
            // k_p_d_eLabel
            // 
            k_p_d_eLabel.AutoSize = true;
            k_p_d_eLabel.Font = new System.Drawing.Font("Calibri", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            k_p_d_eLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            k_p_d_eLabel.Location = new System.Drawing.Point(12, 483);
            k_p_d_eLabel.Name = "k_p_d_eLabel";
            k_p_d_eLabel.Size = new System.Drawing.Size(582, 31);
            k_p_d_eLabel.TabIndex = 19;
            k_p_d_eLabel.Text = "Коэффициент для перевода в денежный эквивалент:";
            // 
            // zarabotnaya_plataDataSet
            // 
            this.zarabotnaya_plataDataSet.DataSetName = "Zarabotnaya_plataDataSet";
            this.zarabotnaya_plataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coefficientBindingSource
            // 
            this.coefficientBindingSource.DataMember = "Coefficient";
            this.coefficientBindingSource.DataSource = this.zarabotnaya_plataDataSet;
            // 
            // coefficientTableAdapter
            // 
            this.coefficientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoefficientTableAdapter = this.coefficientTableAdapter;
            this.tableAdapterManager.ExecutorTableAdapter = null;
            this.tableAdapterManager.ManagerTableAdapter = null;
            this.tableAdapterManager.TaskTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Zarabotnaya_plata.Zarabotnaya_plataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // coefficientBindingNavigator
            // 
            this.coefficientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.coefficientBindingNavigator.BindingSource = this.coefficientBindingSource;
            this.coefficientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.coefficientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.coefficientBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.coefficientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.coefficientBindingNavigatorSaveItem});
            this.coefficientBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.coefficientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.coefficientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.coefficientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.coefficientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.coefficientBindingNavigator.Name = "coefficientBindingNavigator";
            this.coefficientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.coefficientBindingNavigator.Size = new System.Drawing.Size(893, 32);
            this.coefficientBindingNavigator.TabIndex = 0;
            this.coefficientBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9.191489F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // coefficientBindingNavigatorSaveItem
            // 
            this.coefficientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.coefficientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("coefficientBindingNavigatorSaveItem.Image")));
            this.coefficientBindingNavigatorSaveItem.Name = "coefficientBindingNavigatorSaveItem";
            this.coefficientBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.coefficientBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.coefficientBindingNavigatorSaveItem.Visible = false;
            this.coefficientBindingNavigatorSaveItem.Click += new System.EventHandler(this.coefficientBindingNavigatorSaveItem_Click);
            // 
            // id_coefficientTextBox
            // 
            this.id_coefficientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "id_coefficient", true));
            this.id_coefficientTextBox.Location = new System.Drawing.Point(275, 71);
            this.id_coefficientTextBox.Name = "id_coefficientTextBox";
            this.id_coefficientTextBox.Size = new System.Drawing.Size(145, 26);
            this.id_coefficientTextBox.TabIndex = 2;
            // 
            // juniorTextBox
            // 
            this.juniorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "junior", true));
            this.juniorTextBox.Location = new System.Drawing.Point(275, 112);
            this.juniorTextBox.Name = "juniorTextBox";
            this.juniorTextBox.Size = new System.Drawing.Size(145, 26);
            this.juniorTextBox.TabIndex = 4;
            // 
            // middleTextBox
            // 
            this.middleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "middle", true));
            this.middleTextBox.Location = new System.Drawing.Point(275, 155);
            this.middleTextBox.Name = "middleTextBox";
            this.middleTextBox.Size = new System.Drawing.Size(145, 26);
            this.middleTextBox.TabIndex = 6;
            // 
            // seniorTextBox
            // 
            this.seniorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "senior", true));
            this.seniorTextBox.Location = new System.Drawing.Point(275, 200);
            this.seniorTextBox.Name = "seniorTextBox";
            this.seniorTextBox.Size = new System.Drawing.Size(145, 26);
            this.seniorTextBox.TabIndex = 8;
            // 
            // k_a_pTextBox
            // 
            this.k_a_pTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "k_a_p", true));
            this.k_a_pTextBox.Location = new System.Drawing.Point(515, 246);
            this.k_a_pTextBox.Name = "k_a_pTextBox";
            this.k_a_pTextBox.Size = new System.Drawing.Size(147, 26);
            this.k_a_pTextBox.TabIndex = 10;
            // 
            // k_y_oTextBox
            // 
            this.k_y_oTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "k_y_o", true));
            this.k_y_oTextBox.Location = new System.Drawing.Point(515, 292);
            this.k_y_oTextBox.Name = "k_y_oTextBox";
            this.k_y_oTextBox.Size = new System.Drawing.Size(147, 26);
            this.k_y_oTextBox.TabIndex = 12;
            // 
            // k_t_o_sTextBox
            // 
            this.k_t_o_sTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "k_t_o_s", true));
            this.k_t_o_sTextBox.Location = new System.Drawing.Point(738, 338);
            this.k_t_o_sTextBox.Name = "k_t_o_sTextBox";
            this.k_t_o_sTextBox.Size = new System.Drawing.Size(143, 26);
            this.k_t_o_sTextBox.TabIndex = 14;
            // 
            // k_vTextBox
            // 
            this.k_vTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "k_v", true));
            this.k_vTextBox.Location = new System.Drawing.Point(317, 388);
            this.k_vTextBox.Name = "k_vTextBox";
            this.k_vTextBox.Size = new System.Drawing.Size(137, 26);
            this.k_vTextBox.TabIndex = 16;
            // 
            // k_sTextBox
            // 
            this.k_sTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "k_s", true));
            this.k_sTextBox.Location = new System.Drawing.Point(317, 437);
            this.k_sTextBox.Name = "k_sTextBox";
            this.k_sTextBox.Size = new System.Drawing.Size(137, 26);
            this.k_sTextBox.TabIndex = 18;
            // 
            // k_p_d_eTextBox
            // 
            this.k_p_d_eTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "k_p_d_e", true));
            this.k_p_d_eTextBox.Location = new System.Drawing.Point(613, 488);
            this.k_p_d_eTextBox.Name = "k_p_d_eTextBox";
            this.k_p_d_eTextBox.Size = new System.Drawing.Size(136, 26);
            this.k_p_d_eTextBox.TabIndex = 20;
            // 
            // buttAdd
            // 
            this.buttAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
            this.buttAdd.Font = new System.Drawing.Font("Calibri", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttAdd.Location = new System.Drawing.Point(18, 554);
            this.buttAdd.Name = "buttAdd";
            this.buttAdd.Size = new System.Drawing.Size(213, 55);
            this.buttAdd.TabIndex = 21;
            this.buttAdd.Text = "Редактировать";
            this.buttAdd.UseVisualStyleBackColor = false;
            this.buttAdd.Click += new System.EventHandler(this.buttAdd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
            this.button1.Font = new System.Drawing.Font("Calibri", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.button1.Location = new System.Drawing.Point(711, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 55);
            this.button1.TabIndex = 22;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zarabotnaya_plata.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(629, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
            this.button2.Font = new System.Drawing.Font("Calibri", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.button2.Location = new System.Drawing.Point(252, 553);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 56);
            this.button2.TabIndex = 24;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormCoefficient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 642);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttAdd);
            this.Controls.Add(id_coefficientLabel);
            this.Controls.Add(this.id_coefficientTextBox);
            this.Controls.Add(juniorLabel);
            this.Controls.Add(this.juniorTextBox);
            this.Controls.Add(middleLabel);
            this.Controls.Add(this.middleTextBox);
            this.Controls.Add(seniorLabel);
            this.Controls.Add(this.seniorTextBox);
            this.Controls.Add(k_a_pLabel);
            this.Controls.Add(this.k_a_pTextBox);
            this.Controls.Add(k_y_oLabel);
            this.Controls.Add(this.k_y_oTextBox);
            this.Controls.Add(k_t_o_sLabel);
            this.Controls.Add(this.k_t_o_sTextBox);
            this.Controls.Add(k_vLabel);
            this.Controls.Add(this.k_vTextBox);
            this.Controls.Add(k_sLabel);
            this.Controls.Add(this.k_sTextBox);
            this.Controls.Add(k_p_d_eLabel);
            this.Controls.Add(this.k_p_d_eTextBox);
            this.Controls.Add(this.coefficientBindingNavigator);
            this.Name = "FormCoefficient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно коэффициента(ов)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCoefficient_FormClosed);
            this.Load += new System.EventHandler(this.FormCoefficient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zarabotnaya_plataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientBindingNavigator)).EndInit();
            this.coefficientBindingNavigator.ResumeLayout(false);
            this.coefficientBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Zarabotnaya_plataDataSet zarabotnaya_plataDataSet;
        private System.Windows.Forms.BindingSource coefficientBindingSource;
        private Zarabotnaya_plataDataSetTableAdapters.CoefficientTableAdapter coefficientTableAdapter;
        private Zarabotnaya_plataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator coefficientBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton coefficientBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_coefficientTextBox;
        private System.Windows.Forms.TextBox juniorTextBox;
        private System.Windows.Forms.TextBox middleTextBox;
        private System.Windows.Forms.TextBox seniorTextBox;
        private System.Windows.Forms.TextBox k_a_pTextBox;
        private System.Windows.Forms.TextBox k_y_oTextBox;
        private System.Windows.Forms.TextBox k_t_o_sTextBox;
        private System.Windows.Forms.TextBox k_vTextBox;
        private System.Windows.Forms.TextBox k_sTextBox;
        private System.Windows.Forms.TextBox k_p_d_eTextBox;
        private System.Windows.Forms.Button buttAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}