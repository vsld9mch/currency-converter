namespace project_2
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
            this.label_wź = new System.Windows.Forms.Label();
            this.label_wd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox_wż = new System.Windows.Forms.GroupBox();
            this.radioButton_vd = new System.Windows.Forms.RadioButton();
            this.radioButton_pln = new System.Windows.Forms.RadioButton();
            this.radioButton_usd = new System.Windows.Forms.RadioButton();
            this.radioButton_eur = new System.Windows.Forms.RadioButton();
            this.groupBox_wd = new System.Windows.Forms.GroupBox();
            this.radioButton_vd2 = new System.Windows.Forms.RadioButton();
            this.radioButton_usd2 = new System.Windows.Forms.RadioButton();
            this.radioButton_pln2 = new System.Windows.Forms.RadioButton();
            this.radioButton_eur2 = new System.Windows.Forms.RadioButton();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.groupBox_wż.SuspendLayout();
            this.groupBox_wd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_wź
            // 
            this.label_wź.AutoSize = true;
            this.label_wź.Location = new System.Drawing.Point(22, 20);
            this.label_wź.Name = "label_wź";
            this.label_wź.Size = new System.Drawing.Size(109, 16);
            this.label_wź.TabIndex = 0;
            this.label_wź.Text = "Waluta źródłowa";
            // 
            // label_wd
            // 
            this.label_wd.AutoSize = true;
            this.label_wd.Location = new System.Drawing.Point(22, 67);
            this.label_wd.Name = "label_wd";
            this.label_wd.Size = new System.Drawing.Size(111, 16);
            this.label_wd.TabIndex = 1;
            this.label_wd.Text = "Waluta docelowa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(176, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(389, 22);
            this.textBox2.TabIndex = 3;
            // 
            // groupBox_wż
            // 
            this.groupBox_wż.Controls.Add(this.radioButton_vd);
            this.groupBox_wż.Controls.Add(this.radioButton_pln);
            this.groupBox_wż.Controls.Add(this.radioButton_usd);
            this.groupBox_wż.Controls.Add(this.radioButton_eur);
            this.groupBox_wż.Location = new System.Drawing.Point(25, 168);
            this.groupBox_wż.Name = "groupBox_wż";
            this.groupBox_wż.Size = new System.Drawing.Size(153, 123);
            this.groupBox_wż.TabIndex = 4;
            this.groupBox_wż.TabStop = false;
            this.groupBox_wż.Text = "Waluta źródłowa";
            // 
            // radioButton_vd
            // 
            this.radioButton_vd.AutoSize = true;
            this.radioButton_vd.Location = new System.Drawing.Point(6, 99);
            this.radioButton_vd.Name = "radioButton_vd";
            this.radioButton_vd.Size = new System.Drawing.Size(47, 20);
            this.radioButton_vd.TabIndex = 2;
            this.radioButton_vd.TabStop = true;
            this.radioButton_vd.Text = "VD";
            this.radioButton_vd.UseVisualStyleBackColor = true;
            this.radioButton_vd.CheckedChanged += new System.EventHandler(this.radioButton_vd_CheckedChanged);
            // 
            // radioButton_pln
            // 
            this.radioButton_pln.AutoSize = true;
            this.radioButton_pln.Location = new System.Drawing.Point(6, 47);
            this.radioButton_pln.Name = "radioButton_pln";
            this.radioButton_pln.Size = new System.Drawing.Size(54, 20);
            this.radioButton_pln.TabIndex = 0;
            this.radioButton_pln.TabStop = true;
            this.radioButton_pln.Text = "PLN";
            this.radioButton_pln.UseVisualStyleBackColor = true;
            this.radioButton_pln.CheckedChanged += new System.EventHandler(this.radioButton_pln_CheckedChanged);
            // 
            // radioButton_usd
            // 
            this.radioButton_usd.AutoSize = true;
            this.radioButton_usd.Location = new System.Drawing.Point(6, 73);
            this.radioButton_usd.Name = "radioButton_usd";
            this.radioButton_usd.Size = new System.Drawing.Size(57, 20);
            this.radioButton_usd.TabIndex = 1;
            this.radioButton_usd.TabStop = true;
            this.radioButton_usd.Text = "USD";
            this.radioButton_usd.UseVisualStyleBackColor = true;
            this.radioButton_usd.CheckedChanged += new System.EventHandler(this.radioButton_usd_CheckedChanged);
            // 
            // radioButton_eur
            // 
            this.radioButton_eur.AutoSize = true;
            this.radioButton_eur.Location = new System.Drawing.Point(6, 21);
            this.radioButton_eur.Name = "radioButton_eur";
            this.radioButton_eur.Size = new System.Drawing.Size(57, 20);
            this.radioButton_eur.TabIndex = 0;
            this.radioButton_eur.TabStop = true;
            this.radioButton_eur.Text = "EUR";
            this.radioButton_eur.UseVisualStyleBackColor = true;
            this.radioButton_eur.CheckedChanged += new System.EventHandler(this.radioButton_eur_CheckedChanged);
            // 
            // groupBox_wd
            // 
            this.groupBox_wd.Controls.Add(this.radioButton_vd2);
            this.groupBox_wd.Controls.Add(this.radioButton_usd2);
            this.groupBox_wd.Controls.Add(this.radioButton_pln2);
            this.groupBox_wd.Controls.Add(this.radioButton_eur2);
            this.groupBox_wd.Location = new System.Drawing.Point(383, 168);
            this.groupBox_wd.Name = "groupBox_wd";
            this.groupBox_wd.Size = new System.Drawing.Size(182, 123);
            this.groupBox_wd.TabIndex = 5;
            this.groupBox_wd.TabStop = false;
            this.groupBox_wd.Text = "Waluta docelowa";
            // 
            // radioButton_vd2
            // 
            this.radioButton_vd2.AutoSize = true;
            this.radioButton_vd2.Location = new System.Drawing.Point(7, 99);
            this.radioButton_vd2.Name = "radioButton_vd2";
            this.radioButton_vd2.Size = new System.Drawing.Size(47, 20);
            this.radioButton_vd2.TabIndex = 3;
            this.radioButton_vd2.TabStop = true;
            this.radioButton_vd2.Text = "VD";
            this.radioButton_vd2.UseVisualStyleBackColor = true;
            this.radioButton_vd2.CheckedChanged += new System.EventHandler(this.radioButton_vd2_CheckedChanged);
            // 
            // radioButton_usd2
            // 
            this.radioButton_usd2.AutoSize = true;
            this.radioButton_usd2.Location = new System.Drawing.Point(7, 73);
            this.radioButton_usd2.Name = "radioButton_usd2";
            this.radioButton_usd2.Size = new System.Drawing.Size(57, 20);
            this.radioButton_usd2.TabIndex = 2;
            this.radioButton_usd2.TabStop = true;
            this.radioButton_usd2.Text = "USD";
            this.radioButton_usd2.UseVisualStyleBackColor = true;
            this.radioButton_usd2.CheckedChanged += new System.EventHandler(this.radioButton_usd2_CheckedChanged);
            // 
            // radioButton_pln2
            // 
            this.radioButton_pln2.AutoSize = true;
            this.radioButton_pln2.Location = new System.Drawing.Point(7, 47);
            this.radioButton_pln2.Name = "radioButton_pln2";
            this.radioButton_pln2.Size = new System.Drawing.Size(54, 20);
            this.radioButton_pln2.TabIndex = 1;
            this.radioButton_pln2.TabStop = true;
            this.radioButton_pln2.Text = "PLN";
            this.radioButton_pln2.UseVisualStyleBackColor = true;
            this.radioButton_pln2.CheckedChanged += new System.EventHandler(this.radioButton_pln2_CheckedChanged);
            // 
            // radioButton_eur2
            // 
            this.radioButton_eur2.AutoSize = true;
            this.radioButton_eur2.Location = new System.Drawing.Point(7, 21);
            this.radioButton_eur2.Name = "radioButton_eur2";
            this.radioButton_eur2.Size = new System.Drawing.Size(57, 20);
            this.radioButton_eur2.TabIndex = 0;
            this.radioButton_eur2.TabStop = true;
            this.radioButton_eur2.Text = "EUR";
            this.radioButton_eur2.UseVisualStyleBackColor = true;
            this.radioButton_eur2.CheckedChanged += new System.EventHandler(this.radioButton_eur2_CheckedChanged);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(25, 403);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(540, 31);
            this.hScrollBar1.TabIndex = 6;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 517);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.groupBox_wd);
            this.Controls.Add(this.groupBox_wż);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_wd);
            this.Controls.Add(this.label_wź);
            this.Name = "Form1";
            this.Text = "Kalkulator walut";
            this.groupBox_wż.ResumeLayout(false);
            this.groupBox_wż.PerformLayout();
            this.groupBox_wd.ResumeLayout(false);
            this.groupBox_wd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_wź;
        private System.Windows.Forms.Label label_wd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox_wż;
        private System.Windows.Forms.RadioButton radioButton_eur;
        private System.Windows.Forms.GroupBox groupBox_wd;
        private System.Windows.Forms.RadioButton radioButton_pln;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.RadioButton radioButton_usd;
        private System.Windows.Forms.RadioButton radioButton_vd;
        private System.Windows.Forms.RadioButton radioButton_vd2;
        private System.Windows.Forms.RadioButton radioButton_usd2;
        private System.Windows.Forms.RadioButton radioButton_pln2;
        private System.Windows.Forms.RadioButton radioButton_eur2;
    }
}

