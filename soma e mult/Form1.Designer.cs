namespace soma_e_mult
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMult = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.num3 = new System.Windows.Forms.TextBox();
            this.num4 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSoma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo de 4 Numeros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(23, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primeiro Numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(23, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Segundo Numero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(23, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Terceiro Numero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(23, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quarto Numero:";
            // 
            // lblMult
            // 
            this.lblMult.AutoSize = true;
            this.lblMult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMult.Location = new System.Drawing.Point(23, 311);
            this.lblMult.Name = "lblMult";
            this.lblMult.Size = new System.Drawing.Size(0, 13);
            this.lblMult.TabIndex = 5;
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(119, 92);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 20);
            this.num1.TabIndex = 6;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(119, 124);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 20);
            this.num2.TabIndex = 7;
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(119, 154);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(100, 20);
            this.num3.TabIndex = 8;
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(119, 190);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(100, 20);
            this.num4.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCalcular.Location = new System.Drawing.Point(26, 228);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(88, 30);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSoma
            // 
            this.lblSoma.AutoSize = true;
            this.lblSoma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSoma.Location = new System.Drawing.Point(23, 281);
            this.lblSoma.Name = "lblSoma";
            this.lblSoma.Size = new System.Drawing.Size(0, 13);
            this.lblSoma.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(283, 371);
            this.Controls.Add(this.lblSoma);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.lblMult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMult;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox num3;
        private System.Windows.Forms.TextBox num4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSoma;
    }
}

