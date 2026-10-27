namespace GTools
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
            pictureBox1 = new PictureBox();
            UsernameLabel = new Label();
            UsernameTextBox = new TextBox();
            panel1 = new Panel();
            LoginButtom = new Button();
            TitleLabel = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            PasswordtextBox = new TextBox();
            PasswordLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(58, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(335, 322);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameLabel.ForeColor = Color.FromArgb(254, 129, 138);
            UsernameLabel.Location = new Point(464, 130);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(120, 16);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "ENTER USERNAME:";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.BackColor = Color.FromArgb(34, 40, 49);
            UsernameTextBox.BorderStyle = BorderStyle.None;
            UsernameTextBox.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameTextBox.ForeColor = Color.White;
            UsernameTextBox.Location = new Point(501, 154);
            UsernameTextBox.Multiline = true;
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.PlaceholderText = "Username";
            UsernameTextBox.Size = new Size(201, 28);
            UsernameTextBox.TabIndex = 1;
            UsernameTextBox.KeyDown += UsernameTextBox_KeyDown;
            UsernameTextBox.KeyPress += UsernameTextBox_KeyPress;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(254, 129, 138);
            panel1.Location = new Point(464, 182);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 3);
            panel1.TabIndex = 3;
            // 
            // LoginButtom
            // 
            LoginButtom.AutoSize = true;
            LoginButtom.BackColor = Color.FromArgb(255, 69, 82);
            LoginButtom.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButtom.ForeColor = Color.White;
            LoginButtom.Location = new Point(439, 321);
            LoginButtom.Name = "LoginButtom";
            LoginButtom.Size = new Size(295, 56);
            LoginButtom.TabIndex = 3;
            LoginButtom.Text = "LOGIN";
            LoginButtom.UseVisualStyleBackColor = false;
            LoginButtom.Click += LoginButtom_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Microsoft YaHei UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.FromArgb(254, 129, 138);
            TitleLabel.Location = new Point(433, 46);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(310, 57);
            TitleLabel.TabIndex = 5;
            TitleLabel.Text = "GTools Login";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(464, 149);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(464, 239);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(254, 129, 138);
            panel2.Location = new Point(464, 273);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 3);
            panel2.TabIndex = 9;
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.BackColor = Color.FromArgb(34, 40, 49);
            PasswordtextBox.BorderStyle = BorderStyle.None;
            PasswordtextBox.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordtextBox.ForeColor = Color.White;
            PasswordtextBox.Location = new Point(501, 240);
            PasswordtextBox.Multiline = true;
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.PlaceholderText = "Password";
            PasswordtextBox.Size = new Size(201, 33);
            PasswordtextBox.TabIndex = 2;
            PasswordtextBox.KeyDown += PasswordtextBox_KeyDown;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordLabel.ForeColor = Color.FromArgb(254, 129, 138);
            PasswordLabel.Location = new Point(464, 221);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(120, 16);
            PasswordLabel.TabIndex = 7;
            PasswordLabel.Text = "ENTER PASSWORD:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(panel2);
            Controls.Add(PasswordtextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(pictureBox2);
            Controls.Add(TitleLabel);
            Controls.Add(LoginButtom);
            Controls.Add(panel1);
            Controls.Add(UsernameTextBox);
            Controls.Add(UsernameLabel);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GTools";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label UsernameLabel;
        private TextBox UsernameTextBox;
        private Panel panel1;
        private Button LoginButtom;
        private Label TitleLabel;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel2;
        private TextBox PasswordtextBox;
        private Label PasswordLabel;
    }
}
