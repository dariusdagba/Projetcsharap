namespace WinFormApp2
{
    partial class Form3
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
            buttonConvertir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonAnnuler = new Button();
            buttonQuitter = new Button();
            buttonExo4 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            SuspendLayout();
            // 
            // buttonConvertir
            // 
            buttonConvertir.Location = new Point(332, 277);
            buttonConvertir.Name = "buttonConvertir";
            buttonConvertir.Size = new Size(112, 34);
            buttonConvertir.TabIndex = 0;
            buttonConvertir.Text = "Convertir";
            buttonConvertir.UseVisualStyleBackColor = true;
            buttonConvertir.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 45);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 1;
            label1.Text = "Convertisseur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 144);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 2;
            label2.Text = "Dollar CAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(359, 152);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 3;
            label3.Text = "EURO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(460, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 5;
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.Location = new Point(44, 362);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(112, 34);
            buttonAnnuler.TabIndex = 6;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = true;
            buttonAnnuler.Click += buttonAnnuler_Click;
            // 
            // buttonQuitter
            // 
            buttonQuitter.Location = new Point(650, 288);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(112, 34);
            buttonQuitter.TabIndex = 7;
            buttonQuitter.Text = "Quitter";
            buttonQuitter.UseVisualStyleBackColor = true;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // buttonExo4
            // 
            buttonExo4.Location = new Point(686, 404);
            buttonExo4.Name = "buttonExo4";
            buttonExo4.Size = new Size(112, 34);
            buttonExo4.TabIndex = 8;
            buttonExo4.Text = "Exo4";
            buttonExo4.UseVisualStyleBackColor = true;
            buttonExo4.Click += buttonExo4_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(219, 212);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(139, 29);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Dollar->Euro";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(430, 212);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(141, 29);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(buttonExo4);
            Controls.Add(buttonQuitter);
            Controls.Add(buttonAnnuler);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonConvertir);
            Name = "Form3";
            Text = "Exercice3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonConvertir;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonAnnuler;
        private Button buttonQuitter;
        private Button buttonExo4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}