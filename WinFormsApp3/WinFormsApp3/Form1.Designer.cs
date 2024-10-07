namespace WinFormsApp3
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(268, 200);
            button1.Name = "button1";
            button1.Size = new Size(203, 34);
            button1.TabIndex = 0;
            button1.Text = "Trouver les racines";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(268, 357);
            button2.Name = "button2";
            button2.Size = new Size(203, 34);
            button2.TabIndex = 1;
            button2.Text = "On recommence";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 44);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 2;
            label1.Text = "Entrer la valeur de a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 92);
            label2.Name = "label2";
            label2.Size = new Size(169, 25);
            label2.TabIndex = 3;
            label2.Text = "Entrer la valeur de b";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 141);
            label3.Name = "label3";
            label3.Size = new Size(166, 25);
            label3.TabIndex = 4;
            label3.Text = "Entrer la valeur de c";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 275);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(203, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(203, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(203, 141);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(648, 89);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 9;
            button3.Text = "Exercice 2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Equation du second degré";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button3;
    }
}
