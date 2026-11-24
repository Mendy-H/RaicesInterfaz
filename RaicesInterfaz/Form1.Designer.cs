namespace RaicesInterfaz
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            btnCalcular = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtX1 = new TextBox();
            txtX2 = new TextBox();
            lblTipo = new Label();
            btnSalida = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 24);
            label1.Name = "label1";
            label1.Size = new Size(644, 25);
            label1.TabIndex = 0;
            label1.Text = "Esta aplicación encuentra las raíces de una ecuación cuadrática Ax² + Bx + C = 0 ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 67);
            label2.Name = "label2";
            label2.Size = new Size(36, 25);
            label2.TabIndex = 1;
            label2.Text = "A=";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 101);
            label3.Name = "label3";
            label3.Size = new Size(34, 25);
            label3.TabIndex = 2;
            label3.Text = "B=";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 135);
            label4.Name = "label4";
            label4.Size = new Size(35, 25);
            label4.TabIndex = 3;
            label4.Text = "C=";
            label4.Click += label4_Click;
            // 
            // txtA
            // 
            txtA.Location = new Point(59, 61);
            txtA.Name = "txtA";
            txtA.Size = new Size(150, 31);
            txtA.TabIndex = 4;
            // 
            // txtB
            // 
            txtB.Location = new Point(59, 95);
            txtB.Name = "txtB";
            txtB.Size = new Size(150, 31);
            txtB.TabIndex = 5;
            // 
            // txtC
            // 
            txtC.Location = new Point(59, 129);
            txtC.Name = "txtC";
            txtC.Size = new Size(150, 31);
            txtC.TabIndex = 6;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Pink;
            btnCalcular.Location = new Point(233, 167);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(216, 33);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 244);
            label5.Name = "label5";
            label5.Size = new Size(124, 25);
            label5.TabIndex = 8;
            label5.Text = "Las raíces son:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 296);
            label6.Name = "label6";
            label6.Size = new Size(45, 25);
            label6.TabIndex = 9;
            label6.Text = "X1=";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 348);
            label7.Name = "label7";
            label7.Size = new Size(45, 25);
            label7.TabIndex = 10;
            label7.Text = "X2=";
            // 
            // txtX1
            // 
            txtX1.BackColor = Color.Cornsilk;
            txtX1.Location = new Point(110, 296);
            txtX1.Name = "txtX1";
            txtX1.ReadOnly = true;
            txtX1.Size = new Size(150, 31);
            txtX1.TabIndex = 11;
            // 
            // txtX2
            // 
            txtX2.BackColor = Color.Cornsilk;
            txtX2.Location = new Point(110, 348);
            txtX2.Name = "txtX2";
            txtX2.ReadOnly = true;
            txtX2.Size = new Size(150, 31);
            txtX2.TabIndex = 12;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(164, 244);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(0, 25);
            lblTipo.TabIndex = 13;
            // 
            // btnSalida
            // 
            btnSalida.BackColor = SystemColors.ActiveCaption;
            btnSalida.Location = new Point(233, 396);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(216, 34);
            btnSalida.TabIndex = 14;
            btnSalida.Text = "Salida";
            btnSalida.UseVisualStyleBackColor = false;
            btnSalida.Click += btnSalida_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 454);
            Controls.Add(btnSalida);
            Controls.Add(lblTipo);
            Controls.Add(txtX2);
            Controls.Add(txtX1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnCalcular);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Location = new Point(30, 70);
            Name = "Form1";
            Text = "Raices cuadraticas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private Button btnCalcular;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtX1;
        private TextBox txtX2;
        private Label lblTipo;
        private Button btnSalida;
    }
}
