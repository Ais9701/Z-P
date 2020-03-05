namespace Zarabotnaya_plata
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxlog = new System.Windows.Forms.TextBox();
            this.txtboxpas = new System.Windows.Forms.TextBox();
            this.buttEnter = new System.Windows.Forms.Button();
            this.buttExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(146)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(146)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(93, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(146)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(146)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(93, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // txtboxlog
            // 
            this.txtboxlog.Location = new System.Drawing.Point(263, 187);
            this.txtboxlog.Name = "txtboxlog";
            this.txtboxlog.Size = new System.Drawing.Size(170, 26);
            this.txtboxlog.TabIndex = 2;
            this.txtboxlog.Text = "kukleva";
            this.txtboxlog.TextChanged += new System.EventHandler(this.txtboxlog_TextChanged);
            // 
            // txtboxpas
            // 
            this.txtboxpas.Location = new System.Drawing.Point(263, 272);
            this.txtboxpas.Name = "txtboxpas";
            this.txtboxpas.PasswordChar = '*';
            this.txtboxpas.Size = new System.Drawing.Size(170, 26);
            this.txtboxpas.TabIndex = 3;
            this.txtboxpas.Text = "123";
            // 
            // buttEnter
            // 
            this.buttEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
            this.buttEnter.Font = new System.Drawing.Font("Calibri", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttEnter.Location = new System.Drawing.Point(233, 344);
            this.buttEnter.Name = "buttEnter";
            this.buttEnter.Size = new System.Drawing.Size(118, 54);
            this.buttEnter.TabIndex = 4;
            this.buttEnter.Text = "Войти";
            this.buttEnter.UseVisualStyleBackColor = false;
            this.buttEnter.Click += new System.EventHandler(this.buttEnter_Click);
            // 
            // buttExit
            // 
            this.buttExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(187)))));
            this.buttExit.Font = new System.Drawing.Font("Calibri", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.buttExit.Location = new System.Drawing.Point(233, 404);
            this.buttExit.Name = "buttExit";
            this.buttExit.Size = new System.Drawing.Size(118, 54);
            this.buttExit.TabIndex = 5;
            this.buttExit.Text = "Выйти";
            this.buttExit.UseVisualStyleBackColor = false;
            this.buttExit.Click += new System.EventHandler(this.buttExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zarabotnaya_plata.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label3.Location = new System.Drawing.Point(83, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(406, 62);
            this.label3.TabIndex = 7;
            this.label3.Text = "При трёх неудачных попыток, \r\nсистема заблокируется на 15 секунд";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 474);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttExit);
            this.Controls.Add(this.buttEnter);
            this.Controls.Add(this.txtboxpas);
            this.Controls.Add(this.txtboxlog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxlog;
        private System.Windows.Forms.TextBox txtboxpas;
        private System.Windows.Forms.Button buttEnter;
        private System.Windows.Forms.Button buttExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}

