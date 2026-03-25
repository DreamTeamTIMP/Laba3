namespace WinFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGoldenrodYellow;
            textBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.ImeMode = ImeMode.NoControl;
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ShortcutsEnabled = false;
            textBox1.Size = new Size(617, 25);
            textBox1.TabIndex = 1;
            textBox1.TabStop = false;
            textBox1.Text = "АИС Отдел кадров";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.WordWrap = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Gold;
            textBox2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.ImeMode = ImeMode.NoControl;
            textBox2.Location = new Point(0, 25);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ShortcutsEnabled = false;
            textBox2.Size = new Size(617, 25);
            textBox2.TabIndex = 2;
            textBox2.TabStop = false;
            textBox2.Text = "Версия 1.0.0.0";
            textBox2.TextAlign = HorizontalAlignment.Right;
            textBox2.WordWrap = false;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.ImeMode = ImeMode.NoControl;
            textBox3.Location = new Point(0, 50);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.ShortcutsEnabled = false;
            textBox3.Size = new Size(617, 25);
            textBox3.TabIndex = 3;
            textBox3.TabStop = false;
            textBox3.Text = "Введите имя пользователя и пароль";
            textBox3.TextAlign = HorizontalAlignment.Right;
            textBox3.WordWrap = false;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(0, 124);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 5;
            label1.Text = "Имя пользователя";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(0, 162);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 6;
            label2.Text = "Пароль";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(216, 121);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(401, 27);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Location = new Point(216, 159);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(401, 27);
            textBox5.TabIndex = 8;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(45, 231);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Вход";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(523, 231);
            button2.Name = "button2";
            button2.Size = new Size(91, 29);
            button2.TabIndex = 10;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 275);
            panel1.Name = "panel1";
            panel1.Size = new Size(617, 39);
            panel1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 9);
            label4.Name = "label4";
            label4.Size = new Size(191, 20);
            label4.TabIndex = 1;
            label4.Text = "Клавиша CapsLock нажата";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(173, 20);
            label3.TabIndex = 0;
            label3.Text = "Язык ввода английский";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(617, 314);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Label label3;
        private Label label4;
    }
}
