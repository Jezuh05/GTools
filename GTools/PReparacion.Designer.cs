namespace GTools
{
    partial class PReparacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PReparacion));
            TitleLabel = new Label();
            PriceLabel = new Label();
            UsernameLabel = new Label();
            PiezaPreciotextBox = new TextBox();
            checkBox1 = new CheckBox();
            button4 = new Button();
            desocultarbox = new PictureBox();
            OcultarBox1 = new PictureBox();
            checkBox2 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)desocultarbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OcultarBox1).BeginInit();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Microsoft YaHei UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.FromArgb(254, 129, 138);
            TitleLabel.Location = new Point(113, 28);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(414, 57);
            TitleLabel.TabIndex = 6;
            TitleLabel.Text = "Coste Reparacion:";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Microsoft YaHei UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PriceLabel.ForeColor = Color.White;
            PriceLabel.Location = new Point(264, 116);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(92, 57);
            PriceLabel.TabIndex = 7;
            PriceLabel.Text = "??€";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameLabel.ForeColor = Color.FromArgb(254, 129, 138);
            UsernameLabel.Location = new Point(208, 295);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(218, 24);
            UsernameLabel.TabIndex = 8;
            UsernameLabel.Text = "INGRESE PRECIO PIEZA:";
            // 
            // PiezaPreciotextBox
            // 
            PiezaPreciotextBox.BackColor = Color.FromArgb(34, 40, 49);
            PiezaPreciotextBox.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PiezaPreciotextBox.ForeColor = Color.White;
            PiezaPreciotextBox.Location = new Point(215, 351);
            PiezaPreciotextBox.Name = "PiezaPreciotextBox";
            PiezaPreciotextBox.Size = new Size(201, 34);
            PiezaPreciotextBox.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(187, 322);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(148, 23);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Descuento Pieza";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = Color.FromArgb(29, 35, 43);
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(254, 129, 138);
            button4.Location = new Point(226, 396);
            button4.Name = "button4";
            button4.Size = new Size(171, 46);
            button4.TabIndex = 3;
            button4.Text = "Calcular";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // desocultarbox
            // 
            desocultarbox.BorderStyle = BorderStyle.FixedSingle;
            desocultarbox.Image = (Image)resources.GetObject("desocultarbox.Image");
            desocultarbox.InitialImage = (Image)resources.GetObject("desocultarbox.InitialImage");
            desocultarbox.Location = new Point(422, 351);
            desocultarbox.Name = "desocultarbox";
            desocultarbox.Size = new Size(34, 34);
            desocultarbox.SizeMode = PictureBoxSizeMode.Zoom;
            desocultarbox.TabIndex = 18;
            desocultarbox.TabStop = false;
            desocultarbox.Visible = false;
            desocultarbox.Click += desocultarbox_Click;
            // 
            // OcultarBox1
            // 
            OcultarBox1.BorderStyle = BorderStyle.FixedSingle;
            OcultarBox1.Image = (Image)resources.GetObject("OcultarBox1.Image");
            OcultarBox1.InitialImage = (Image)resources.GetObject("OcultarBox1.InitialImage");
            OcultarBox1.Location = new Point(422, 351);
            OcultarBox1.Name = "OcultarBox1";
            OcultarBox1.Size = new Size(34, 34);
            OcultarBox1.SizeMode = PictureBoxSizeMode.Zoom;
            OcultarBox1.TabIndex = 17;
            OcultarBox1.TabStop = false;
            OcultarBox1.Click += OcultarBox1_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox2.ForeColor = Color.White;
            checkBox2.Location = new Point(336, 322);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(114, 23);
            checkBox2.TabIndex = 19;
            checkBox2.Text = "Primera Vez";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // PReparacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(638, 454);
            Controls.Add(checkBox2);
            Controls.Add(desocultarbox);
            Controls.Add(OcultarBox1);
            Controls.Add(button4);
            Controls.Add(checkBox1);
            Controls.Add(PiezaPreciotextBox);
            Controls.Add(UsernameLabel);
            Controls.Add(PriceLabel);
            Controls.Add(TitleLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PReparacion";
            Text = "PReparacion";
            Load += PReparacion_Load;
            ((System.ComponentModel.ISupportInitialize)desocultarbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)OcultarBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Label PriceLabel;
        private Label UsernameLabel;
        private TextBox PiezaPreciotextBox;
        private CheckBox checkBox1;
        private Button button4;
        private PictureBox desocultarbox;
        private PictureBox OcultarBox1;
        private CheckBox checkBox2;
    }
}