namespace WindowsFormsApp1
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
            this.txtArquivoLeitura = new System.Windows.Forms.TextBox();
            this.btn_Choose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChose2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArquivoSaida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caminho do Arquivo";
            // 
            // txtArquivoLeitura
            // 
            this.txtArquivoLeitura.Location = new System.Drawing.Point(119, 35);
            this.txtArquivoLeitura.Name = "txtArquivoLeitura";
            this.txtArquivoLeitura.ReadOnly = true;
            this.txtArquivoLeitura.Size = new System.Drawing.Size(328, 20);
            this.txtArquivoLeitura.TabIndex = 1;
            // 
            // btn_Choose
            // 
            this.btn_Choose.Location = new System.Drawing.Point(453, 33);
            this.btn_Choose.Name = "btn_Choose";
            this.btn_Choose.Size = new System.Drawing.Size(75, 23);
            this.btn_Choose.TabIndex = 2;
            this.btn_Choose.Text = "Escolher";
            this.btn_Choose.UseVisualStyleBackColor = true;
            this.btn_Choose.Click += new System.EventHandler(this.btn_Choose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtArquivoLeitura);
            this.groupBox1.Controls.Add(this.btn_Choose);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 73);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arquivo a ser Criptografado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChose2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtArquivoSaida);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(15, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 69);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnChose2
            // 
            this.btnChose2.Location = new System.Drawing.Point(453, 28);
            this.btnChose2.Name = "btnChose2";
            this.btnChose2.Size = new System.Drawing.Size(76, 20);
            this.btnChose2.TabIndex = 3;
            this.btnChose2.Text = "Escolher";
            this.btnChose2.UseVisualStyleBackColor = true;
            this.btnChose2.Click += new System.EventHandler(this.btnChose2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Arquivo de saída";
            // 
            // txtArquivoSaida
            // 
            this.txtArquivoSaida.Location = new System.Drawing.Point(117, 28);
            this.txtArquivoSaida.Name = "txtArquivoSaida";
            this.txtArquivoSaida.ReadOnly = true;
            this.txtArquivoSaida.Size = new System.Drawing.Size(330, 20);
            this.txtArquivoSaida.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Caminho do Arquivo";
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.Location = new System.Drawing.Point(238, 290);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(75, 23);
            this.btnCriptografar.TabIndex = 5;
            this.btnCriptografar.Text = "Criptografar";
            this.btnCriptografar.UseVisualStyleBackColor = true;
            this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtChave);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(15, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(543, 68);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(117, 28);
            this.txtChave.MaxLength = 8;
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(330, 20);
            this.txtChave.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Digite a Chave";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Chave de 8 dígitos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 325);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCriptografar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Criptografador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArquivoLeitura;
        private System.Windows.Forms.Button btn_Choose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtArquivoSaida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChose2;
        private System.Windows.Forms.Button btnCriptografar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

