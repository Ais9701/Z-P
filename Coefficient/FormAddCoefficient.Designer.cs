namespace Zarabotnaya_plata
{
    partial class FormAddCoefficient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCoefficient));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.zarabotnaya_plataDataSet = new Zarabotnaya_plata.Zarabotnaya_plataDataSet();
            this.coefficientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coefficientTableAdapter = new Zarabotnaya_plata.Zarabotnaya_plataDataSetTableAdapters.CoefficientTableAdapter();
            this.tableAdapterManager = new Zarabotnaya_plata.Zarabotnaya_plataDataSetTableAdapters.TableAdapterManager();
            this.coefficientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.coefficientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.coefficientDataGridView = new System.Windows.Forms.DataGridView();
            this.buttSave = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.zarabotnaya_plataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientBindingNavigator)).BeginInit();
            this.coefficientBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.coefficientBindingNavigator.CountItem = null;
            this.coefficientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.coefficientBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.coefficientBindingNavigator.Font = new System.Drawing.Font("Calibri", 13.78723F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coefficientBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.coefficientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.coefficientBindingNavigatorSaveItem});
            this.coefficientBindingNavigator.Location = new System.Drawing.Point(569, 346);
            this.coefficientBindingNavigator.MoveFirstItem = null;
            this.coefficientBindingNavigator.MoveLastItem = null;
            this.coefficientBindingNavigator.MoveNextItem = null;
            this.coefficientBindingNavigator.MovePreviousItem = null;
            this.coefficientBindingNavigator.Name = "coefficientBindingNavigator";
            this.coefficientBindingNavigator.PositionItem = null;
            this.coefficientBindingNavigator.Size = new System.Drawing.Size(486, 41);
            this.coefficientBindingNavigator.TabIndex = 0;
            this.coefficientBindingNavigator.Text = "bindingNavigator1";
            this.coefficientBindingNavigator.RefreshItems += new System.EventHandler(this.coefficientBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(128, 37);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(111, 37);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // coefficientBindingNavigatorSaveItem
            // 
            this.coefficientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.coefficientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("coefficientBindingNavigatorSaveItem.Image")));
            this.coefficientBindingNavigatorSaveItem.Name = "coefficientBindingNavigatorSaveItem";
            this.coefficientBindingNavigatorSaveItem.Size = new System.Drawing.Size(231, 37);
            this.coefficientBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.coefficientBindingNavigatorSaveItem.Click += new System.EventHandler(this.coefficientBindingNavigatorSaveItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zarabotnaya_plata.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
            this.button2.Font = new System.Drawing.Font("Calibri", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.button2.Location = new System.Drawing.Point(1240, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 62);
            this.button2.TabIndex = 43;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // coefficientDataGridView
            // 
            this.coefficientDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.coefficientDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.coefficientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coefficientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.coefficientDataGridView.DataSource = this.coefficientBindingSource;
            this.coefficientDataGridView.Location = new System.Drawing.Point(2, 0);
            this.coefficientDataGridView.Name = "coefficientDataGridView";
            this.coefficientDataGridView.RowHeadersWidth = 60;
            this.coefficientDataGridView.RowTemplate.Height = 28;
            this.coefficientDataGridView.Size = new System.Drawing.Size(1927, 280);
            this.coefficientDataGridView.TabIndex = 43;
            // 
            // buttSave
            // 
            this.buttSave.Location = new System.Drawing.Point(231, 346);
            this.buttSave.Name = "buttSave";
            this.buttSave.Size = new System.Drawing.Size(173, 81);
            this.buttSave.TabIndex = 44;
            this.buttSave.Text = "Сохранить";
            this.buttSave.UseVisualStyleBackColor = true;
            this.buttSave.Click += new System.EventHandler(this.buttSave_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_coefficient";
            this.dataGridViewTextBoxColumn1.HeaderText = "Коэффициент";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 147;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "junior";
            this.dataGridViewTextBoxColumn2.HeaderText = "Начальный уровень";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 147;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "middle";
            this.dataGridViewTextBoxColumn3.HeaderText = "Средний уровень";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 147;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "senior";
            this.dataGridViewTextBoxColumn4.HeaderText = "Высокий уровень";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 147;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "k_a_p";
            this.dataGridViewTextBoxColumn5.HeaderText = "Коэффициент для анализа и проектирования";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 147;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "k_y_o";
            this.dataGridViewTextBoxColumn6.HeaderText = "Коэффициент для установки оборудования";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 147;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "k_t_o_s";
            this.dataGridViewTextBoxColumn7.HeaderText = "Коэффициент для технического обслуживания и сопровождения";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 147;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "k_v";
            this.dataGridViewTextBoxColumn8.HeaderText = "Коэффициент времени";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 147;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "k_s";
            this.dataGridViewTextBoxColumn9.HeaderText = "Коэффициент сложности";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 147;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "k_p_d_e";
            this.dataGridViewTextBoxColumn10.HeaderText = "Коэффициент для перевода в денежный эквивалент";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 147;
            // 
            // FormAddCoefficient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 476);
            this.Controls.Add(this.buttSave);
            this.Controls.Add(this.coefficientDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.coefficientBindingNavigator);
            this.Name = "FormAddCoefficient";
            this.Text = "Добавление коэффициента";
            this.Load += new System.EventHandler(this.FormAddCoefficient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zarabotnaya_plataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientBindingNavigator)).EndInit();
            this.coefficientBindingNavigator.ResumeLayout(false);
            this.coefficientBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientDataGridView)).EndInit();
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton coefficientBindingNavigatorSaveItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView coefficientDataGridView;
        private System.Windows.Forms.Button buttSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}