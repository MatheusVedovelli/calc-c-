namespace Calculadora
{
    partial class frmCalculadora
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
            this.Display = new System.Windows.Forms.TextBox();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnMult = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnErase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Enabled = false;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(12, 12);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(198, 31);
            this.Display.TabIndex = 0;
            this.Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(12, 221);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(35, 35);
            this.Btn1.TabIndex = 1;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(53, 221);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(35, 35);
            this.Btn2.TabIndex = 2;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(94, 221);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(35, 35);
            this.Btn3.TabIndex = 3;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            // 
            // BtnMinus
            // 
            this.BtnMinus.Location = new System.Drawing.Point(135, 221);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(35, 35);
            this.BtnMinus.TabIndex = 4;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = true;
            // 
            // BtnMult
            // 
            this.BtnMult.Location = new System.Drawing.Point(135, 180);
            this.BtnMult.Name = "BtnMult";
            this.BtnMult.Size = new System.Drawing.Size(35, 35);
            this.BtnMult.TabIndex = 8;
            this.BtnMult.Text = "*";
            this.BtnMult.UseVisualStyleBackColor = true;
            // 
            // Btn6
            // 
            this.Btn6.Location = new System.Drawing.Point(94, 180);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(35, 35);
            this.Btn6.TabIndex = 7;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(53, 180);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(35, 35);
            this.Btn5.TabIndex = 6;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(12, 180);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(35, 35);
            this.Btn4.TabIndex = 5;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            // 
            // BtnDiv
            // 
            this.BtnDiv.Location = new System.Drawing.Point(135, 139);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(35, 35);
            this.BtnDiv.TabIndex = 12;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = true;
            // 
            // Btn9
            // 
            this.Btn9.Location = new System.Drawing.Point(94, 139);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(35, 35);
            this.Btn9.TabIndex = 11;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            // 
            // Btn8
            // 
            this.Btn8.Location = new System.Drawing.Point(53, 139);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(35, 35);
            this.Btn8.TabIndex = 10;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            // 
            // Btn7
            // 
            this.Btn7.Location = new System.Drawing.Point(12, 139);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(35, 35);
            this.Btn7.TabIndex = 9;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(135, 98);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(35, 35);
            this.button12.TabIndex = 16;
            this.button12.Text = "1";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // BtnC
            // 
            this.BtnC.Location = new System.Drawing.Point(94, 98);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(35, 35);
            this.BtnC.TabIndex = 15;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            // 
            // BtnCE
            // 
            this.BtnCE.Location = new System.Drawing.Point(53, 98);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(35, 35);
            this.BtnCE.TabIndex = 14;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = true;
            // 
            // BtnErase
            // 
            this.BtnErase.Location = new System.Drawing.Point(12, 98);
            this.BtnErase.Name = "BtnErase";
            this.BtnErase.Size = new System.Drawing.Size(35, 35);
            this.BtnErase.TabIndex = 13;
            this.BtnErase.Text = "<--";
            this.BtnErase.UseVisualStyleBackColor = true;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 316);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.BtnErase);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnMult);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Display);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button BtnMult;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.Button BtnErase;
    }
}

