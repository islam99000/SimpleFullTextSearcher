namespace SimpleFullTextSearcher
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            button3 = new Button();
            listBox1 = new ListBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 62);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
            label1.TabIndex = 0;
            label1.Text = "folder path";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 133);
            label2.Name = "label2";
            label2.Size = new Size(136, 28);
            label2.TabIndex = 1;
            label2.Text = "research text";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(221, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(325, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(221, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(325, 27);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.LightGreen;
            button1.Location = new Point(567, 62);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 4;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.LightGreen;
            button2.Location = new Point(567, 128);
            button2.Name = "button2";
            button2.Size = new Size(94, 38);
            button2.TabIndex = 5;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(203, 35);
            label3.TabIndex = 7;
            label3.Text = "FullTextSearchApp";
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.LightGreen;
            button3.Location = new Point(170, 469);
            button3.Name = "button3";
            button3.Size = new Size(94, 38);
            button3.TabIndex = 9;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(87, 202);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(581, 244);
            listBox1.TabIndex = 10;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.LightGreen;
            button4.Location = new Point(487, 469);
            button4.Name = "button4";
            button4.Size = new Size(94, 38);
            button4.TabIndex = 11;
            button4.Text = "Close";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(765, 543);
            Controls.Add(button4);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Label label3;
        private Button button3;
        private ListBox listBox1;
        private Button button4;
    }
}
