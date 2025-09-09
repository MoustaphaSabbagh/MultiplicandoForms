namespace MultiplicandoForms
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
            textBox2 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(13, 54);
            button1.Name = "button1";
            button1.Size = new Size(243, 51);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(65, 23);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(104, 25);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(62, 23);
            textBox2.TabIndex = 1;
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 27);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 2;
            label1.Text = "X";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(193, 25);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(63, 23);
            textBox3.TabIndex = 3;
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 6);
            label2.Name = "label2";
            label2.Size = new Size(251, 15);
            label2.TabIndex = 4;
            label2.Text = "DIGITE DOIS NUMERO PARA MULTIPLICA-LOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 28);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 5;
            label3.Text = "=";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 119);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
    }
}
