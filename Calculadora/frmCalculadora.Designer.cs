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
            this.BtnMM = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnErase = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnComa = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.Btn1Div = new System.Windows.Forms.Button();
            this.BtnPercent = new System.Windows.Forms.Button();
            this.BtnSqrt = new System.Windows.Forms.Button();
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
            this.Display.TextChanged += new System.EventHandler(this.Display_TextChanged);
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(12, 177);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(35, 35);
            this.Btn1.TabIndex = 1;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(53, 177);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(35, 35);
            this.Btn2.TabIndex = 2;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(94, 177);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(35, 35);
            this.Btn3.TabIndex = 3;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // BtnMinus
            // 
            this.BtnMinus.Location = new System.Drawing.Point(135, 177);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(35, 35);
            this.BtnMinus.TabIndex = 4;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = true;
            this.BtnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // BtnMult
            // 
            this.BtnMult.Location = new System.Drawing.Point(135, 136);
            this.BtnMult.Name = "BtnMult";
            this.BtnMult.Size = new System.Drawing.Size(35, 35);
            this.BtnMult.TabIndex = 8;
            this.BtnMult.Text = "*";
            this.BtnMult.UseVisualStyleBackColor = true;
            this.BtnMult.Click += new System.EventHandler(this.BtnMult_Click);
            // 
            // Btn6
            // 
            this.Btn6.Location = new System.Drawing.Point(94, 136);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(35, 35);
            this.Btn6.TabIndex = 7;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(53, 136);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(35, 35);
            this.Btn5.TabIndex = 6;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(12, 136);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(35, 35);
            this.Btn4.TabIndex = 5;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.Location = new System.Drawing.Point(135, 95);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(35, 35);
            this.BtnDiv.TabIndex = 12;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // Btn9
            // 
            this.Btn9.Location = new System.Drawing.Point(94, 95);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(35, 35);
            this.Btn9.TabIndex = 11;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // Btn8
            // 
            this.Btn8.Location = new System.Drawing.Point(53, 95);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(35, 35);
            this.Btn8.TabIndex = 10;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn7
            // 
            this.Btn7.Location = new System.Drawing.Point(12, 95);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(35, 35);
            this.Btn7.TabIndex = 9;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // BtnMM
            // 
            this.BtnMM.Location = new System.Drawing.Point(135, 54);
            this.BtnMM.Name = "BtnMM";
            this.BtnMM.Size = new System.Drawing.Size(35, 35);
            this.BtnMM.TabIndex = 16;
            this.BtnMM.Text = "±";
            this.BtnMM.UseVisualStyleBackColor = true;
            this.BtnMM.Click += new System.EventHandler(this.BtnMM_Click);
            // 
            // BtnC
            // 
            this.BtnC.Location = new System.Drawing.Point(94, 54);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(35, 35);
            this.BtnC.TabIndex = 15;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnCE
            // 
            this.BtnCE.Location = new System.Drawing.Point(53, 54);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(35, 35);
            this.BtnCE.TabIndex = 14;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = true;
            this.BtnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // BtnErase
            // 
            this.BtnErase.Location = new System.Drawing.Point(12, 54);
            this.BtnErase.Name = "BtnErase";
            this.BtnErase.Size = new System.Drawing.Size(35, 35);
            this.BtnErase.TabIndex = 13;
            this.BtnErase.Text = "<--";
            this.BtnErase.UseVisualStyleBackColor = true;
            this.BtnErase.Click += new System.EventHandler(this.BtnErase_Click);
            // 
            // Btn0
            // 
            this.Btn0.Location = new System.Drawing.Point(12, 218);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(76, 35);
            this.Btn0.TabIndex = 17;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // BtnComa
            // 
            this.BtnComa.Location = new System.Drawing.Point(94, 218);
            this.BtnComa.Name = "BtnComa";
            this.BtnComa.Size = new System.Drawing.Size(35, 35);
            this.BtnComa.TabIndex = 18;
            this.BtnComa.Text = ",";
            this.BtnComa.UseVisualStyleBackColor = true;
            this.BtnComa.Click += new System.EventHandler(this.BtnComa_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.Location = new System.Drawing.Point(135, 218);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(35, 35);
            this.BtnPlus.TabIndex = 19;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // BtnEqual
            // 
            this.BtnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEqual.Location = new System.Drawing.Point(175, 177);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(35, 76);
            this.BtnEqual.TabIndex = 20;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = true;
            this.BtnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // Btn1Div
            // 
            this.Btn1Div.Location = new System.Drawing.Point(176, 136);
            this.Btn1Div.Name = "Btn1Div";
            this.Btn1Div.Size = new System.Drawing.Size(35, 35);
            this.Btn1Div.TabIndex = 21;
            this.Btn1Div.Text = "1/x";
            this.Btn1Div.UseVisualStyleBackColor = true;
            this.Btn1Div.Click += new System.EventHandler(this.Btn1Div_Click);
            // 
            // BtnPercent
            // 
            this.BtnPercent.Location = new System.Drawing.Point(176, 95);
            this.BtnPercent.Name = "BtnPercent";
            this.BtnPercent.Size = new System.Drawing.Size(35, 35);
            this.BtnPercent.TabIndex = 22;
            this.BtnPercent.Text = "%";
            this.BtnPercent.UseVisualStyleBackColor = true;
            this.BtnPercent.Click += new System.EventHandler(this.BtnPercent_Click);
            // 
            // BtnSqrt
            // 
            this.BtnSqrt.Location = new System.Drawing.Point(176, 54);
            this.BtnSqrt.Name = "BtnSqrt";
            this.BtnSqrt.Size = new System.Drawing.Size(35, 35);
            this.BtnSqrt.TabIndex = 23;
            this.BtnSqrt.Text = "√";
            this.BtnSqrt.UseVisualStyleBackColor = true;
            this.BtnSqrt.Click += new System.EventHandler(this.BtnSqrt_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 261);
            this.Controls.Add(this.BtnSqrt);
            this.Controls.Add(this.BtnPercent);
            this.Controls.Add(this.Btn1Div);
            this.Controls.Add(this.BtnEqual);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.BtnComa);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnMM);
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
        private System.Windows.Forms.Button BtnMM;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.Button BtnErase;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnComa;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnEqual;
        private System.Windows.Forms.Button Btn1Div;
        private System.Windows.Forms.Button BtnPercent;
        private System.Windows.Forms.Button BtnSqrt;
    }
}

