namespace calculadora_TI27
{
    partial class frmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtVisor = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnDividir = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMultiplicar = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnSubtrair = new Button();
            btnLimpar = new Button();
            btn0 = new Button();
            btnIgual = new Button();
            btnSomar = new Button();
            SuspendLayout();
            // 
            // txtVisor
            // 
            txtVisor.BackColor = SystemColors.ControlDark;
            txtVisor.BorderStyle = BorderStyle.None;
            txtVisor.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            txtVisor.Location = new Point(12, 12);
            txtVisor.Name = "txtVisor";
            txtVisor.Size = new Size(318, 47);
            txtVisor.TabIndex = 0;
            txtVisor.Text = "0";
            txtVisor.TextAlign = HorizontalAlignment.Right;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ControlDark;
            btn7.Font = new Font("Segoe UI", 20F);
            btn7.Location = new Point(12, 65);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 75);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += BtnNumero_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ControlDark;
            btn8.Font = new Font("Segoe UI", 20F);
            btn8.Location = new Point(93, 65);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 75);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += BtnNumero_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ControlDark;
            btn9.Font = new Font("Segoe UI", 20F);
            btn9.Location = new Point(174, 65);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 75);
            btn9.TabIndex = 1;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += BtnNumero_Click;
            // 
            // btnDividir
            // 
            btnDividir.BackColor = Color.DarkOrange;
            btnDividir.Font = new Font("Segoe UI", 20F);
            btnDividir.Location = new Point(255, 65);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 75);
            btnDividir.TabIndex = 1;
            btnDividir.Text = "÷";
            btnDividir.UseVisualStyleBackColor = false;
            btnDividir.Click += btnDividir_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ControlDark;
            btn4.Font = new Font("Segoe UI", 20F);
            btn4.Location = new Point(12, 146);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 75);
            btn4.TabIndex = 1;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += BtnNumero_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ControlDark;
            btn5.Font = new Font("Segoe UI", 20F);
            btn5.Location = new Point(93, 146);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 75);
            btn5.TabIndex = 1;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += BtnNumero_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ControlDark;
            btn6.Font = new Font("Segoe UI", 20F);
            btn6.Location = new Point(174, 146);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 75);
            btn6.TabIndex = 1;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += BtnNumero_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.BackColor = Color.DarkOrange;
            btnMultiplicar.Font = new Font("Segoe UI", 20F);
            btnMultiplicar.Location = new Point(255, 146);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 75);
            btnMultiplicar.TabIndex = 1;
            btnMultiplicar.Text = "x";
            btnMultiplicar.UseVisualStyleBackColor = false;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ControlDark;
            btn1.Font = new Font("Segoe UI", 20F);
            btn1.Location = new Point(12, 227);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 75);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += BtnNumero_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ControlDark;
            btn2.Font = new Font("Segoe UI", 20F);
            btn2.Location = new Point(93, 227);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 75);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += BtnNumero_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ControlDark;
            btn3.Font = new Font("Segoe UI", 20F);
            btn3.Location = new Point(174, 227);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 75);
            btn3.TabIndex = 1;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += BtnNumero_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.BackColor = Color.DarkOrange;
            btnSubtrair.Font = new Font("Segoe UI", 20F);
            btnSubtrair.Location = new Point(255, 227);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(75, 75);
            btnSubtrair.TabIndex = 1;
            btnSubtrair.Text = "-";
            btnSubtrair.UseVisualStyleBackColor = false;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.DarkRed;
            btnLimpar.Font = new Font("Segoe UI", 20F);
            btnLimpar.ForeColor = SystemColors.ControlText;
            btnLimpar.Location = new Point(12, 308);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 75);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ControlDark;
            btn0.Font = new Font("Segoe UI", 20F);
            btn0.Location = new Point(93, 308);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 75);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += BtnNumero_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.DarkGreen;
            btnIgual.Font = new Font("Segoe UI", 20F);
            btnIgual.Location = new Point(174, 308);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(75, 75);
            btnIgual.TabIndex = 1;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnSomar
            // 
            btnSomar.BackColor = Color.DarkOrange;
            btnSomar.Font = new Font("Segoe UI", 20F);
            btnSomar.Location = new Point(255, 308);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(75, 75);
            btnSomar.TabIndex = 1;
            btnSomar.Text = "+";
            btnSomar.UseVisualStyleBackColor = false;
            btnSomar.Click += btnSomar_Click;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(346, 401);
            Controls.Add(btnSomar);
            Controls.Add(btnSubtrair);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnDividir);
            Controls.Add(btnIgual);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn6);
            Controls.Add(btnLimpar);
            Controls.Add(btn5);
            Controls.Add(btn1);
            Controls.Add(btn9);
            Controls.Add(btn4);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtVisor);
            Name = "frmCalculadora";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVisor;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnDividir;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMultiplicar;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnSubtrair;
        private Button btnLimpar;
        private Button btn0;
        private Button btnIgual;
        private Button btnSomar;
    }
}
