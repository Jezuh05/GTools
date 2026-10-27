namespace GTools
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            TopPanel = new Panel();
            label2 = new Label();
            ExitLabel = new Label();
            panel1 = new Panel();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            CreditsLabel = new Label();
            pictureCredits = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            TitleLabel = new Label();
            PanelContainer = new Panel();
            DescripcionLabel1 = new Label();
            FechaLabel1 = new Label();
            changelogslabel = new Label();
            Changelogspanel = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TopPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCredits).BeginInit();
            Changelogspanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(254, 129, 138);
            TopPanel.Controls.Add(label2);
            TopPanel.Controls.Add(ExitLabel);
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(820, 42);
            TopPanel.TabIndex = 0;
            TopPanel.Paint += TopPanel_Paint;
            TopPanel.MouseDown += TopPanel_MouseDown;
            TopPanel.MouseMove += TopPanel_MouseMove;
            TopPanel.MouseUp += TopPanel_MouseUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Microsoft YaHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(34, 40, 49);
            label2.Location = new Point(748, -8);
            label2.Name = "label2";
            label2.Size = new Size(38, 50);
            label2.TabIndex = 7;
            label2.Text = "-";
            label2.Click += label2_Click;
            // 
            // ExitLabel
            // 
            ExitLabel.AutoSize = true;
            ExitLabel.Cursor = Cursors.Hand;
            ExitLabel.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitLabel.ForeColor = Color.FromArgb(34, 40, 49);
            ExitLabel.Location = new Point(781, 3);
            ExitLabel.Name = "ExitLabel";
            ExitLabel.Size = new Size(34, 36);
            ExitLabel.TabIndex = 6;
            ExitLabel.Text = "X";
            ExitLabel.Click += ExitLabel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 35, 43);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(CreditsLabel);
            panel1.Controls.Add(pictureCredits);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(TitleLabel);
            panel1.Location = new Point(0, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 470);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(254, 129, 138);
            label1.Location = new Point(49, 72);
            label1.Name = "label1";
            label1.Size = new Size(79, 16);
            label1.TabIndex = 11;
            label1.Text = "ID: ?????????";
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = Color.FromArgb(29, 35, 43);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(254, 129, 138);
            button4.Location = new Point(0, 280);
            button4.Name = "button4";
            button4.Size = new Size(171, 46);
            button4.TabIndex = 4;
            button4.Text = "Ajustes";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.FromArgb(29, 35, 43);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(254, 129, 138);
            button3.Location = new Point(0, 228);
            button3.Name = "button3";
            button3.Size = new Size(171, 46);
            button3.TabIndex = 3;
            button3.Text = "Pedidos";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // CreditsLabel
            // 
            CreditsLabel.AutoSize = true;
            CreditsLabel.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreditsLabel.ForeColor = Color.FromArgb(254, 129, 138);
            CreditsLabel.Location = new Point(38, 438);
            CreditsLabel.Name = "CreditsLabel";
            CreditsLabel.Size = new Size(126, 16);
            CreditsLabel.TabIndex = 2;
            CreditsLabel.Text = "Desarrollado por Jesús Núñez";
            CreditsLabel.Click += CreditsLabel_Click;
            // 
            // pictureCredits
            // 
            pictureCredits.Image = (Image)resources.GetObject("pictureCredits.Image");
            pictureCredits.Location = new Point(8, 437);
            pictureCredits.Name = "pictureCredits";
            pictureCredits.Size = new Size(30, 18);
            pictureCredits.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCredits.TabIndex = 2;
            pictureCredits.TabStop = false;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(29, 35, 43);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(254, 129, 138);
            button2.Location = new Point(0, 176);
            button2.Name = "button2";
            button2.Size = new Size(171, 46);
            button2.TabIndex = 2;
            button2.Text = "Precio Terminal";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(29, 35, 43);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(254, 129, 138);
            button1.Location = new Point(3, 124);
            button1.Name = "button1";
            button1.Size = new Size(171, 46);
            button1.TabIndex = 1;
            button1.Text = "Precio Reparacion";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(254, 129, 138);
            panel2.Location = new Point(3, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(168, 3);
            panel2.TabIndex = 7;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Microsoft YaHei UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.FromArgb(254, 129, 138);
            TitleLabel.Location = new Point(0, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(175, 57);
            TitleLabel.TabIndex = 6;
            TitleLabel.Text = "GTools";
            // 
            // PanelContainer
            // 
            PanelContainer.Location = new Point(177, 48);
            PanelContainer.Name = "PanelContainer";
            PanelContainer.Size = new Size(638, 454);
            PanelContainer.TabIndex = 2;
            PanelContainer.Paint += PanelContainer_Paint;
            // 
            // DescripcionLabel1
            // 
            DescripcionLabel1.AutoSize = true;
            DescripcionLabel1.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescripcionLabel1.ForeColor = Color.White;
            DescripcionLabel1.Location = new Point(18, 162);
            DescripcionLabel1.Name = "DescripcionLabel1";
            DescripcionLabel1.Size = new Size(536, 48);
            DescripcionLabel1.TabIndex = 16;
            DescripcionLabel1.Text = "+ Ajuste para posicionar programa por encima por defecto\r\n+ AutoUpdate\r\n";
            // 
            // FechaLabel1
            // 
            FechaLabel1.AutoSize = true;
            FechaLabel1.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FechaLabel1.ForeColor = Color.FromArgb(254, 129, 138);
            FechaLabel1.Location = new Point(18, 129);
            FechaLabel1.Name = "FechaLabel1";
            FechaLabel1.Size = new Size(127, 24);
            FechaLabel1.TabIndex = 15;
            FechaLabel1.Text = "- 17/07/2024";
            // 
            // changelogslabel
            // 
            changelogslabel.AutoSize = true;
            changelogslabel.Font = new Font("Microsoft YaHei UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changelogslabel.ForeColor = Color.FromArgb(254, 129, 138);
            changelogslabel.Location = new Point(177, 10);
            changelogslabel.Name = "changelogslabel";
            changelogslabel.Size = new Size(291, 57);
            changelogslabel.TabIndex = 13;
            changelogslabel.Text = "ChangeLogs";
            // 
            // Changelogspanel
            // 
            Changelogspanel.Controls.Add(label6);
            Changelogspanel.Controls.Add(label5);
            Changelogspanel.Controls.Add(label3);
            Changelogspanel.Controls.Add(label4);
            Changelogspanel.Controls.Add(changelogslabel);
            Changelogspanel.Controls.Add(DescripcionLabel1);
            Changelogspanel.Controls.Add(FechaLabel1);
            Changelogspanel.Location = new Point(177, 48);
            Changelogspanel.Name = "Changelogspanel";
            Changelogspanel.Size = new Size(638, 454);
            Changelogspanel.TabIndex = 17;
            Changelogspanel.Paint += Changelogspanel_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 256);
            label3.Name = "label3";
            label3.Size = new Size(524, 96);
            label3.TabIndex = 18;
            label3.Text = "+ Corregidos Precios en Precio Terminales\r\n+ Ocultar Precios original para que los clientes no lo vean\r\n+ Visualizacion de tiempo de licencia hasta expiracion\r\n\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(254, 129, 138);
            label4.Location = new Point(18, 223);
            label4.Name = "label4";
            label4.Size = new Size(127, 24);
            label4.TabIndex = 17;
            label4.Text = "- 11/07/2024";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(254, 129, 138);
            label5.Location = new Point(18, 66);
            label5.Name = "label5";
            label5.Size = new Size(127, 24);
            label5.TabIndex = 19;
            label5.Text = "- 10/07/2025";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(18, 100);
            label6.Name = "label6";
            label6.Size = new Size(327, 24);
            label6.TabIndex = 20;
            label6.Text = "+ Arreglado problemas de licencias";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 40, 49);
            ClientSize = new Size(817, 508);
            Controls.Add(Changelogspanel);
            Controls.Add(PanelContainer);
            Controls.Add(panel1);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Main_Load;
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCredits).EndInit();
            Changelogspanel.ResumeLayout(false);
            Changelogspanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private PictureBox pictureCredits;
        private Label ExitLabel;
        private Panel panel1;
        private Label TitleLabel;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Label CreditsLabel;
        private Button button3;
        private Button button4;
        private Panel PanelContainer;
        private Label label1;
        private Label label2;
        private Label changelogslabel;
        private Label FechaLabel1;
        private Label DescripcionLabel1;
        private Panel Changelogspanel;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}