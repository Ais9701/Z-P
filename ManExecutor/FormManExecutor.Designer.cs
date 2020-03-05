namespace Zarabotnaya_plata.Manager
{
    partial class FormManExecutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManExecutor));
            System.Windows.Forms.Label fio_executorLabel1;
            System.Windows.Forms.Label fio_managerLabel1;
            System.Windows.Forms.Label statusLabel1;
            System.Windows.Forms.Label name_taskLabel1;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.taskBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.taskBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.fio_executorTextBox = new System.Windows.Forms.TextBox();
            this.fio_managerTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.name_taskTextBox = new System.Windows.Forms.TextBox();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zarabotnaya_plataDataSet = new Zarabotnaya_plata.Zarabotnaya_plataDataSet();
            this.taskTableAdapter = new Zarabotnaya_plata.Zarabotnaya_plataDataSetTableAdapters.TaskTableAdapter();
            this.tableAdapterManager = new Zarabotnaya_plata.Zarabotnaya_plataDataSetTableAdapters.TableAdapterManager();
            this.managerTableAdapter = new Zarabotnaya_plata.Zarabotnaya_plataDataSetTableAdapters.ManagerTableAdapter();
            this.userTableAdapter = new Zarabotnaya_plata.Zarabotnaya_plataDataSetTableAdapters.UserTableAdapter();
            this.managerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            fio_executorLabel1 = new System.Windows.Forms.Label();
            fio_managerLabel1 = new System.Windows.Forms.Label();
            statusLabel1 = new System.Windows.Forms.Label();
            name_taskLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingNavigator)).BeginInit();
            this.taskBindingNavigator.SuspendLayout();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarabotnaya_plataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zarabotnaya_plata.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(896, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // taskBindingNavigator
            // 
            this.taskBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.taskBindingNavigator.BindingSource = this.taskBindingSource;
            this.taskBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.taskBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.taskBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.taskBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.taskBindingNavigatorSaveItem});
            this.taskBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.taskBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.taskBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.taskBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.taskBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.taskBindingNavigator.Name = "taskBindingNavigator";
            this.taskBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.taskBindingNavigator.Size = new System.Drawing.Size(1036, 37);
            this.taskBindingNavigator.TabIndex = 1;
            this.taskBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // taskBindingNavigatorSaveItem
            // 
            this.taskBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.taskBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("taskBindingNavigatorSaveItem.Image")));
            this.taskBindingNavigatorSaveItem.Name = "taskBindingNavigatorSaveItem";
            this.taskBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.taskBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.taskBindingNavigatorSaveItem.Click += new System.EventHandler(this.taskBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
            this.button1.Font = new System.Drawing.Font("Calibri", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(814, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 64);
            this.button1.TabIndex = 13;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fio_executorLabel1
            // 
            fio_executorLabel1.AutoSize = true;
            fio_executorLabel1.Font = new System.Drawing.Font("Calibri", 13.78723F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            fio_executorLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            fio_executorLabel1.Location = new System.Drawing.Point(71, 153);
            fio_executorLabel1.Name = "fio_executorLabel1";
            fio_executorLabel1.Size = new System.Drawing.Size(228, 33);
            fio_executorLabel1.TabIndex = 13;
            fio_executorLabel1.Text = "ФИО исполнителя:";
            // 
            // fio_executorTextBox
            // 
            this.fio_executorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "fio_executor", true));
            this.fio_executorTextBox.Location = new System.Drawing.Point(335, 160);
            this.fio_executorTextBox.Name = "fio_executorTextBox";
            this.fio_executorTextBox.Size = new System.Drawing.Size(199, 26);
            this.fio_executorTextBox.TabIndex = 14;
            // 
            // fio_managerLabel1
            // 
            fio_managerLabel1.AutoSize = true;
            fio_managerLabel1.Font = new System.Drawing.Font("Calibri", 13.78723F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            fio_managerLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            fio_managerLabel1.Location = new System.Drawing.Point(71, 232);
            fio_managerLabel1.Name = "fio_managerLabel1";
            fio_managerLabel1.Size = new System.Drawing.Size(214, 33);
            fio_managerLabel1.TabIndex = 14;
            fio_managerLabel1.Text = "ФИО менеджера:";
            // 
            // fio_managerTextBox
            // 
            this.fio_managerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "fio_manager", true));
            this.fio_managerTextBox.Location = new System.Drawing.Point(335, 239);
            this.fio_managerTextBox.Name = "fio_managerTextBox";
            this.fio_managerTextBox.Size = new System.Drawing.Size(199, 26);
            this.fio_managerTextBox.TabIndex = 15;
            // 
            // statusLabel1
            // 
            statusLabel1.AutoSize = true;
            statusLabel1.Font = new System.Drawing.Font("Calibri", 13.78723F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            statusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            statusLabel1.Location = new System.Drawing.Point(71, 381);
            statusLabel1.Name = "statusLabel1";
            statusLabel1.Size = new System.Drawing.Size(92, 33);
            statusLabel1.TabIndex = 15;
            statusLabel1.Text = "Статус:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "status", true));
            this.statusTextBox.Location = new System.Drawing.Point(335, 388);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(199, 26);
            this.statusTextBox.TabIndex = 16;
            // 
            // name_taskLabel1
            // 
            name_taskLabel1.AutoSize = true;
            name_taskLabel1.Font = new System.Drawing.Font("Calibri", 13.78723F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            name_taskLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            name_taskLabel1.Location = new System.Drawing.Point(71, 310);
            name_taskLabel1.Name = "name_taskLabel1";
            name_taskLabel1.Size = new System.Drawing.Size(217, 33);
            name_taskLabel1.TabIndex = 17;
            name_taskLabel1.Text = "Название задачи:";
            // 
            // name_taskTextBox
            // 
            this.name_taskTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "name_task", true));
            this.name_taskTextBox.Location = new System.Drawing.Point(335, 317);
            this.name_taskTextBox.Name = "name_taskTextBox";
            this.name_taskTextBox.Size = new System.Drawing.Size(199, 26);
            this.name_taskTextBox.TabIndex = 18;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 37);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1036, 37);
            this.fillByToolStrip.TabIndex = 19;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(56, 29);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "Task";
            this.taskBindingSource.DataSource = this.zarabotnaya_plataDataSet;
            // 
            // zarabotnaya_plataDataSet
            // 
            this.zarabotnaya_plataDataSet.DataSetName = "Zarabotnaya_plataDataSet";
            this.zarabotnaya_plataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoefficientTableAdapter = null;
            this.tableAdapterManager.ExecutorTableAdapter = null;
            this.tableAdapterManager.ManagerTableAdapter = this.managerTableAdapter;
            this.tableAdapterManager.TaskTableAdapter = this.taskTableAdapter;
            this.tableAdapterManager.UpdateOrder = Zarabotnaya_plata.Zarabotnaya_plataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            // 
            // managerTableAdapter
            // 
            this.managerTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // managerBindingSource
            // 
            this.managerBindingSource.DataMember = "Manager";
            this.managerBindingSource.DataSource = this.zarabotnaya_plataDataSet;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.zarabotnaya_plataDataSet;
            // 
            // FormManExecutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 515);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(name_taskLabel1);
            this.Controls.Add(this.name_taskTextBox);
            this.Controls.Add(statusLabel1);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(fio_managerLabel1);
            this.Controls.Add(this.fio_managerTextBox);
            this.Controls.Add(fio_executorLabel1);
            this.Controls.Add(this.fio_executorTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.taskBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormManExecutor";
            this.Text = "Окно исполнителя";
            this.Load += new System.EventHandler(this.FormManExecutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingNavigator)).EndInit();
            this.taskBindingNavigator.ResumeLayout(false);
            this.taskBindingNavigator.PerformLayout();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarabotnaya_plataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Zarabotnaya_plataDataSet zarabotnaya_plataDataSet;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private Zarabotnaya_plataDataSetTableAdapters.TaskTableAdapter taskTableAdapter;
        private Zarabotnaya_plataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator taskBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton taskBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button1;
        private Zarabotnaya_plataDataSetTableAdapters.ManagerTableAdapter managerTableAdapter;
        private System.Windows.Forms.BindingSource managerBindingSource;
        private Zarabotnaya_plataDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TextBox fio_executorTextBox;
        private System.Windows.Forms.TextBox fio_managerTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox name_taskTextBox;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}