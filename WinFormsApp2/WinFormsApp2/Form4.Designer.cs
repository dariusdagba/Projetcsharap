namespace WinFormApp2
{
    partial class Form4
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
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            radioButtonDiv = new RadioButton();
            radioButtonMul = new RadioButton();
            radioButtonSous = new RadioButton();
            radioButtonAdd = new RadioButton();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonExecuter = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(radioButtonDiv);
            groupBox1.Controls.Add(radioButtonMul);
            groupBox1.Controls.Add(radioButtonSous);
            groupBox1.Controls.Add(radioButtonAdd);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonExecuter);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opération arithmétiques";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(187, 306);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(442, 31);
            textBox3.TabIndex = 10;
            // 
            // radioButtonDiv
            // 
            radioButtonDiv.AutoSize = true;
            radioButtonDiv.Location = new Point(462, 200);
            radioButtonDiv.Name = "radioButtonDiv";
            radioButtonDiv.Size = new Size(100, 29);
            radioButtonDiv.TabIndex = 9;
            radioButtonDiv.TabStop = true;
            radioButtonDiv.Text = "Division";
            radioButtonDiv.UseVisualStyleBackColor = true;
            // 
            // radioButtonMul
            // 
            radioButtonMul.AutoSize = true;
            radioButtonMul.Location = new Point(462, 150);
            radioButtonMul.Name = "radioButtonMul";
            radioButtonMul.Size = new Size(144, 29);
            radioButtonMul.TabIndex = 8;
            radioButtonMul.TabStop = true;
            radioButtonMul.Text = "Multiplication";
            radioButtonMul.UseVisualStyleBackColor = true;
            radioButtonMul.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButtonSous
            // 
            radioButtonSous.AutoSize = true;
            radioButtonSous.Location = new Point(462, 106);
            radioButtonSous.Name = "radioButtonSous";
            radioButtonSous.Size = new Size(136, 29);
            radioButtonSous.TabIndex = 7;
            radioButtonSous.TabStop = true;
            radioButtonSous.Text = "Soustraction";
            radioButtonSous.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdd
            // 
            radioButtonAdd.AutoSize = true;
            radioButtonAdd.Location = new Point(462, 62);
            radioButtonAdd.Name = "radioButtonAdd";
            radioButtonAdd.Size = new Size(106, 29);
            radioButtonAdd.TabIndex = 6;
            radioButtonAdd.TabStop = true;
            radioButtonAdd.Text = "Addition";
            radioButtonAdd.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(187, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(187, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 306);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 3;
            label3.Text = "Résultat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 120);
            label2.Name = "label2";
            label2.Size = new Size(31, 25);
            label2.TabIndex = 2;
            label2.Text = "Y :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 64);
            label1.Name = "label1";
            label1.Size = new Size(32, 25);
            label1.TabIndex = 1;
            label1.Text = "X :";
            // 
            // buttonExecuter
            // 
            buttonExecuter.Location = new Point(204, 195);
            buttonExecuter.Name = "buttonExecuter";
            buttonExecuter.Size = new Size(112, 34);
            buttonExecuter.TabIndex = 0;
            buttonExecuter.Text = "Executer";
            buttonExecuter.UseVisualStyleBackColor = true;
            buttonExecuter.Click += buttonExecuter_Click;
            // 
            // button1
            // 
            button1.Location = new Point(634, 246);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 11;
            button1.Text = "Exo5";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form4";
            Text = "Exercice4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private RadioButton radioButtonMul;
        private RadioButton radioButtonSous;
        private RadioButton radioButtonAdd;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonExecuter;
        private RadioButton radioButtonDiv;
        private TextBox textBox3;
        private Button button1;
    }
}