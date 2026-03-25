using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Laba3Test2
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
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
            splitContainer1.Size = new Size(540, 241);
            splitContainer1.SplitterDistance = 212;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.Window;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(3, 50);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(535, 22);
            panel3.TabIndex = 19;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(303, 3);
            label3.Name = "label3";
            label3.Size = new Size(206, 15);
            label3.TabIndex = 0;
            label3.Text = "Введите имя пользователя и пароль";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.LemonChiffon;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 22);
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(452, 4);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "АСУ Ждаю";
            // 
            // labelUser
            // 
            labelUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelUser.AutoSize = true;
            labelUser.BackColor = SystemColors.GradientActiveCaption;
            labelUser.Location = new Point(17, 122);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(109, 15);
            labelUser.TabIndex = 11;
            labelUser.Text = "Имя пользователя";
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(17, 148);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(49, 15);
            labelPassword.TabIndex = 12;
            labelPassword.Text = "Пароль";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.Window;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Location = new Point(56, 182);
            buttonLogin.Margin = new Padding(3, 2, 3, 2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(82, 22);
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
            buttonCancel.Location = new Point(434, 182);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(80, 22);
            buttonCancel.TabIndex = 16;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxPassword.Location = new Point(178, 148);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.MinimumSize = new Size(350, 25);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(351, 25);
            textBoxPassword.TabIndex = 14;
            textBoxPassword.KeyDown += textBoxPassword_KeyDown;
            // 
            // textBoxUser
            // 
            textBoxUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxUser.Location = new Point(178, 120);
            textBoxUser.Margin = new Padding(3, 2, 3, 2);
            textBoxUser.MinimumSize = new Size(350, 25);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(351, 25);
            textBoxUser.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Gold;
            panel2.Controls.Add(labelVersion);
            panel2.Location = new Point(3, 26);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(519, 22);
            panel2.TabIndex = 18;
            // 
            // labelVersion
            // 
            labelVersion.Anchor = AnchorStyles.Left;
            labelVersion.AutoSize = true;
            labelVersion.Location = new Point(399, 3);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(109, 15);
            labelVersion.TabIndex = 0;
            labelVersion.Text = "АИС Отдел кадров";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelLang, toolStripStatusLabelCaps });
            statusStrip1.Location = new Point(0, 4);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(540, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelLang
            // 
            toolStripStatusLabelLang.Name = "toolStripStatusLabelLang";
            toolStripStatusLabelLang.Size = new Size(263, 17);
            toolStripStatusLabelLang.Spring = true;
            toolStripStatusLabelLang.Text = "Язык ввода";
            toolStripStatusLabelLang.TextAlign = ContentAlignment.BottomLeft;
            // 
            // toolStripStatusLabelCaps
            // 
            toolStripStatusLabelCaps.Name = "toolStripStatusLabelCaps";
            toolStripStatusLabelCaps.Size = new Size(263, 17);
            toolStripStatusLabelCaps.Spring = true;
            toolStripStatusLabelCaps.Text = "Клавиша Capslock нажата";
            toolStripStatusLabelCaps.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 4);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(540, 241);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(553, 280);
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
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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