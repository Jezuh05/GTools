namespace GTools
{
    partial class FormPTerminal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPTerminal));
            button4 = new Button();
            checkBox1 = new CheckBox();
            TerminalPreciotextBox = new TextBox();
            UsernameLabel = new Label();
            PriceLabel = new Label();
            TitleLabel = new Label();
            OcultarBox1 = new PictureBox();
            desocultarbox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)OcultarBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)desocultarbox).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = Color.FromArgb(29, 35, 43);
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(254, 129, 138);
            button4.Location = new Point(225, 396);
            button4.Name = "button4";
            button4.Size = new Size(171, 46);
            button4.TabIndex = 11;
            button4.Text = "Calcular";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(254, 314);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(128, 23);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Canon (3,25€)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // TerminalPreciotextBox
            // 
            TerminalPreciotextBox.BackColor = Color.FromArgb(34, 40, 49);
            TerminalPreciotextBox.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TerminalPreciotextBox.ForeColor = Color.White;
            TerminalPreciotextBox.Location = new Point(212, 343);
            TerminalPreciotextBox.Name = "TerminalPreciotextBox";
            TerminalPreciotextBox.Size = new Size(201, 34);
            TerminalPreciotextBox.TabIndex = 10;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameLabel.ForeColor = Color.FromArgb(254, 129, 138);
            UsernameLabel.Location = new Point(192, 287);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(261, 24);
            UsernameLabel.TabIndex = 14;
            UsernameLabel.Text = "INGRESE PRECIO TERMINAL:";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Microsoft YaHei UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PriceLabel.ForeColor = Color.White;
            PriceLabel.Location = new Point(263, 108);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(92, 57);
            PriceLabel.TabIndex = 13;
            PriceLabel.Text = "??€";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Microsoft YaHei UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.FromArgb(254, 129, 138);
            TitleLabel.Location = new Point(150, 18);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(362, 57);
            TitleLabel.TabIndex = 12;
            TitleLabel.Text = "Coste Terminal:";
            // 
            // OcultarBox1
            // 
            OcultarBox1.BorderStyle = BorderStyle.FixedSingle;
            OcultarBox1.Image = (Image)resources.GetObject("OcultarBox1.Image");
            OcultarBox1.InitialImage = (Image)resources.GetObject("OcultarBox1.InitialImage");
            OcultarBox1.Location = new Point(419, 343);
            OcultarBox1.Name = "OcultarBox1";
            OcultarBox1.Size = new Size(34, 34);
            OcultarBox1.SizeMode = PictureBoxSizeMode.Zoom;
            OcultarBox1.TabIndex = 15;
            OcultarBox1.TabStop = false;
            OcultarBox1.Click += OcultarBox1_Click;
            // 
            // desocultarbox
            // 
            desocultarbox.BorderStyle = BorderStyle.FixedSingle;
            desocultarbox.Image = (Image)resources.GetObject("desocultarbox.Image");
            desocultarbox.InitialImage = (Image)resources.GetObject("desocultarbox.InitialImage");
            desocultarbox.Location = new Point(419, 343);
            desocultarbox.Name = "desocultarbox";
            desocultarbox.Size = new Size(34, 34);
            desocultarbox.SizeMode = PictureBoxSizeMode.Zoom;
            desocultarbox.TabIndex = 16;
            desocultarbox.TabStop = false;
            desocultarbox.Visible = false;
            desocultarbox.Click += desocultarbox_Click;
            // 
            // FormPTerminal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(638, 454);
            Controls.Add(desocultarbox);
            Controls.Add(OcultarBox1);
            Controls.Add(button4);
            Controls.Add(checkBox1);
            Controls.Add(TerminalPreciotextBox);
            Controls.Add(UsernameLabel);
            Controls.Add(PriceLabel);
            Controls.Add(TitleLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPTerminal";
            Text = "FormPTerminal";
            Load += FormPTerminal_Load;
            ((System.ComponentModel.ISupportInitialize)OcultarBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)desocultarbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private CheckBox checkBox1;
        private TextBox TerminalPreciotextBox;
        private Label UsernameLabel;
        private Label PriceLabel;
        private Label TitleLabel;
        private PictureBox OcultarBox1;
        private PictureBox desocultarbox;
    }
}