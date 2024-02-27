namespace MP_PD_v3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prec_cena = new System.Windows.Forms.TextBox();
            this.prec_daud = new System.Windows.Forms.NumericUpDown();
            this.aprekinat_btn = new System.Windows.Forms.Button();
            this.maka_summa = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prec_nos = new System.Windows.Forms.TextBox();
            this.txt_summa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prec_daud)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preces cena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preču daudzums";
            // 
            // prec_cena
            // 
            this.prec_cena.Location = new System.Drawing.Point(82, 78);
            this.prec_cena.Name = "prec_cena";
            this.prec_cena.Size = new System.Drawing.Size(100, 20);
            this.prec_cena.TabIndex = 2;
            // 
            // prec_daud
            // 
            this.prec_daud.Location = new System.Drawing.Point(82, 114);
            this.prec_daud.Name = "prec_daud";
            this.prec_daud.Size = new System.Drawing.Size(120, 20);
            this.prec_daud.TabIndex = 3;
            // 
            // aprekinat_btn
            // 
            this.aprekinat_btn.Location = new System.Drawing.Point(82, 202);
            this.aprekinat_btn.Name = "aprekinat_btn";
            this.aprekinat_btn.Size = new System.Drawing.Size(100, 23);
            this.aprekinat_btn.TabIndex = 4;
            this.aprekinat_btn.Text = "Aprēķināt";
            this.aprekinat_btn.UseVisualStyleBackColor = true;
            this.aprekinat_btn.Click += new System.EventHandler(this.aprekinat_btn_Click);
            // 
            // maka_summa
            // 
            this.maka_summa.AutoSize = true;
            this.maka_summa.Location = new System.Drawing.Point(236, 150);
            this.maka_summa.Name = "maka_summa";
            this.maka_summa.Size = new System.Drawing.Size(94, 13);
            this.maka_summa.TabIndex = 5;
            this.maka_summa.Text = "Jūsu maka summa";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Preces nosaukums";
            // 
            // prec_nos
            // 
            this.prec_nos.Location = new System.Drawing.Point(82, 40);
            this.prec_nos.Name = "prec_nos";
            this.prec_nos.Size = new System.Drawing.Size(100, 20);
            this.prec_nos.TabIndex = 8;
            // 
            // txt_summa
            // 
            this.txt_summa.Location = new System.Drawing.Point(82, 263);
            this.txt_summa.Name = "txt_summa";
            this.txt_summa.Size = new System.Drawing.Size(100, 20);
            this.txt_summa.TabIndex = 9;
            this.txt_summa.TextChanged += new System.EventHandler(this.summa_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "summa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_summa);
            this.Controls.Add(this.prec_nos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.maka_summa);
            this.Controls.Add(this.aprekinat_btn);
            this.Controls.Add(this.prec_daud);
            this.Controls.Add(this.prec_cena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prec_daud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prec_cena;
        private System.Windows.Forms.NumericUpDown prec_daud;
        private System.Windows.Forms.Button aprekinat_btn;
        private System.Windows.Forms.Label maka_summa;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prec_nos;
        private System.Windows.Forms.TextBox txt_summa;
        private System.Windows.Forms.Label label4;
    }
}

