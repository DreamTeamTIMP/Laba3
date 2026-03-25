namespace Laba3
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            labelUser = new Label();
            labelPassword = new Label();
            buttonLogin = new Button();
            buttonCancel = new Button();
            textBoxPassword = new TextBox();
            textBoxUser = new TextBox();
            panel2 = new Panel();
            labelVersion = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelLang = new ToolStripStatusLabel();
            toolStripStatusLabelCaps = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.GradientActiveCaption;
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(labelUser);
            splitContainer1.Panel1.Controls.Add(labelPassword);
            splitContainer1.Panel1.Controls.Add(buttonLogin);
            splitContainer1.Panel1.Controls.Add(buttonCancel);
            splitContainer1.Panel1.Controls.Add(textBoxPassword);
            splitContainer1.Panel1.Controls.Add(textBoxUser);
            splitContainer1.Panel1.Controls.Add(panel2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.GradientActiveCaption;
            splitContainer1.Panel2.Controls.Add(statusStrip1);
            splitContainer1.Size = new Size(617, 314);
            splitContainer1.SplitterDistance = 285;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.Window;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(3, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(611, 29);
            panel3.TabIndex = 19;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(346, 4);
            label3.Name = "label3";
            label3.Size = new Size(265, 20);
            label3.TabIndex = 0;
            label3.Text = "Введите имя пользователя и пароль";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LemonChiffon;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(602, 29);
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(517, 5);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "АСУ Ждаю";
            // 
            // labelUser
            // 
            labelUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelUser.AutoSize = true;
            labelUser.BackColor = SystemColors.GradientActiveCaption;
            labelUser.Location = new Point(19, 163);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(139, 20);
            labelUser.TabIndex = 11;
            labelUser.Text = "Имя пользователя";
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(19, 198);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(62, 20);
            labelPassword.TabIndex = 12;
            labelPassword.Text = "Пароль";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.Window;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Location = new Point(64, 242);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 29);
            buttonLogin.TabIndex = 15;
            buttonLogin.Text = "Вход";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancel.BackColor = SystemColors.Window;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Location = new Point(496, 242);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(91, 29);
            buttonCancel.TabIndex = 16;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxPassword.Location = new Point(204, 198);
            textBoxPassword.MinimumSize = new Size(400, 25);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(401, 27);
            textBoxPassword.TabIndex = 14;
            textBoxPassword.KeyDown += textBoxPassword_KeyDown;
            // 
            // textBoxUser
            // 
            textBoxUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxUser.Location = new Point(204, 160);
            textBoxUser.MinimumSize = new Size(400, 25);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(401, 27);
            textBoxUser.TabIndex = 13;
            textBoxUser.KeyDown += textBoxUser_KeyDown;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Gold;
            panel2.Controls.Add(labelVersion);
            panel2.Location = new Point(3, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(593, 29);
            panel2.TabIndex = 18;
            // 
            // labelVersion
            // 
            labelVersion.Anchor = AnchorStyles.Left;
            labelVersion.AutoSize = true;
            labelVersion.Location = new Point(456, 4);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(137, 20);
            labelVersion.TabIndex = 0;
            labelVersion.Text = "АИС Отдел кадров";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelLang, toolStripStatusLabelCaps });
            statusStrip1.Location = new Point(0, -1);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(617, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelLang
            // 
            toolStripStatusLabelLang.Name = "toolStripStatusLabelLang";
            toolStripStatusLabelLang.Size = new Size(301, 20);
            toolStripStatusLabelLang.Spring = true;
            toolStripStatusLabelLang.Text = "Язык ввода";
            toolStripStatusLabelLang.TextAlign = ContentAlignment.BottomLeft;
            // 
            // toolStripStatusLabelCaps
            // 
            toolStripStatusLabelCaps.Name = "toolStripStatusLabelCaps";
            toolStripStatusLabelCaps.Size = new Size(301, 20);
            toolStripStatusLabelCaps.Spring = true;
            toolStripStatusLabelCaps.Text = "Клавиша Capslock нажата";
            toolStripStatusLabelCaps.TextAlign = ContentAlignment.BottomLeft;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(617, 314);
            Controls.Add(splitContainer1);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(630, 360);
            Name = "LoginForm";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label labelUser;
        private Label labelPassword;
        private Button buttonLogin;
        private Button buttonCancel;
        private TextBox textBoxPassword;
        private TextBox textBoxUser;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelLang;
        private ToolStripStatusLabel toolStripStatusLabelCaps;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private Panel panel2;
        private Label labelVersion;
        private PictureBox pictureBox1;
    }
}