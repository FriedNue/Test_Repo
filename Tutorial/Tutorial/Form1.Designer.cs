namespace Tutorial
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Base 05", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(200, 26);
            label1.Name = "label1";
            label1.Size = new Size(850, 55);
            label1.TabIndex = 0;
            label1.Text = "Test Text";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Location = new Point(200, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1200, 600);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Base 05", 24F, FontStyle.Bold);
            button1.Location = new Point(12, 284);
            button1.Name = "button1";
            button1.Size = new Size(70, 270);
            button1.TabIndex = 2;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Base 05", 24F, FontStyle.Bold);
            button2.Location = new Point(1502, 284);
            button2.Name = "button2";
            button2.Size = new Size(70, 270);
            button2.TabIndex = 3;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Base 05", 24F, FontStyle.Bold);
            label2.Location = new Point(684, 703);
            label2.Name = "label2";
            label2.Size = new Size(216, 40);
            label2.TabIndex = 4;
            label2.Text = "NaN / NaN";
            // 
            // button3
            // 
            button3.Font = new Font("Base 05", 24F, FontStyle.Bold);
            button3.Location = new Point(1233, 706);
            button3.Name = "button3";
            button3.Size = new Size(167, 69);
            button3.TabIndex = 5;
            button3.Text = "SKIP";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1621, 853);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tutorial";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Button button3;
    }
}
