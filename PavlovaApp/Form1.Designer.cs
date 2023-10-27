namespace PavlovaApp
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(181, 316);
            button1.Name = "button1";
            button1.Size = new Size(221, 86);
            button1.TabIndex = 0;
            button1.Text = "Нажми на меня!!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(255, 128, 255);
            textBox1.Location = new Point(181, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 42);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(64, 50);
            label1.Name = "label1";
            label1.Size = new Size(94, 22);
            label1.TabIndex = 2;
            label1.Text = "Введите a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(64, 142);
            label2.Name = "label2";
            label2.Size = new Size(95, 22);
            label2.TabIndex = 3;
            label2.Text = "Введите b";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(255, 128, 255);
            textBox2.Location = new Point(181, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 42);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(64, 242);
            label3.Name = "label3";
            label3.Size = new Size(113, 22);
            label3.TabIndex = 5;
            label3.Text = "Сумма a+b=";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.FromArgb(255, 128, 255);
            textBox3.Location = new Point(181, 228);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 42);
            textBox3.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 585);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(192, 0, 192);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
    }
}