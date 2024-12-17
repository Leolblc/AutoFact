namespace AutoFact
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            panel1 = new Panel();
            BtnRecap = new Button();
            BtnFacture = new Button();
            BtnPrestation = new Button();
            BtnClientNa = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            DGVListClient = new DataGridView();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            buttonQuitter = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVListClient).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel1.Controls.Add(BtnRecap);
            panel1.Controls.Add(BtnFacture);
            panel1.Controls.Add(BtnPrestation);
            panel1.Controls.Add(BtnClientNa);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 877);
            panel1.TabIndex = 0;
            // 
            // BtnRecap
            // 
            BtnRecap.FlatAppearance.BorderSize = 0;
            BtnRecap.FlatStyle = FlatStyle.Flat;
            BtnRecap.Font = new Font("Segoe UI", 16F, FontStyle.Underline);
            BtnRecap.ForeColor = SystemColors.Control;
            BtnRecap.Location = new Point(29, 560);
            BtnRecap.Name = "BtnRecap";
            BtnRecap.Size = new Size(147, 46);
            BtnRecap.TabIndex = 4;
            BtnRecap.Text = "Récapitulatif";
            BtnRecap.UseVisualStyleBackColor = true;
            BtnRecap.Click += BtnRecap_Click;
            // 
            // BtnFacture
            // 
            BtnFacture.FlatAppearance.BorderSize = 0;
            BtnFacture.FlatStyle = FlatStyle.Flat;
            BtnFacture.Font = new Font("Segoe UI", 16F, FontStyle.Underline);
            BtnFacture.ForeColor = SystemColors.Control;
            BtnFacture.Location = new Point(29, 434);
            BtnFacture.Name = "BtnFacture";
            BtnFacture.Size = new Size(147, 36);
            BtnFacture.TabIndex = 3;
            BtnFacture.Text = "Facture";
            BtnFacture.UseVisualStyleBackColor = true;
            BtnFacture.Click += BtnFacture_Click;
            // 
            // BtnPrestation
            // 
            BtnPrestation.FlatAppearance.BorderSize = 0;
            BtnPrestation.FlatStyle = FlatStyle.Flat;
            BtnPrestation.Font = new Font("Segoe UI", 16F, FontStyle.Underline);
            BtnPrestation.ForeColor = SystemColors.Control;
            BtnPrestation.Location = new Point(29, 295);
            BtnPrestation.Name = "BtnPrestation";
            BtnPrestation.Size = new Size(147, 46);
            BtnPrestation.TabIndex = 2;
            BtnPrestation.Text = "Prestation";
            BtnPrestation.UseVisualStyleBackColor = true;
            BtnPrestation.Click += BtnPrestation_Click;
            // 
            // BtnClientNa
            // 
            BtnClientNa.FlatAppearance.BorderSize = 0;
            BtnClientNa.FlatStyle = FlatStyle.Flat;
            BtnClientNa.Font = new Font("Segoe UI", 16F, FontStyle.Underline);
            BtnClientNa.ForeColor = SystemColors.ButtonShadow;
            BtnClientNa.Location = new Point(29, 180);
            BtnClientNa.Name = "BtnClientNa";
            BtnClientNa.Size = new Size(147, 40);
            BtnClientNa.TabIndex = 1;
            BtnClientNa.Text = "Client";
            BtnClientNa.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(73, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(237, 54, 54);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(210, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 877);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Controls.Add(label1);
            panel3.ImeMode = ImeMode.Disable;
            panel3.Location = new Point(305, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(857, 64);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label1.Location = new Point(16, 3);
            label1.Name = "label1";
            label1.Size = new Size(131, 47);
            label1.TabIndex = 0;
            label1.Text = "Clients";
            label1.Click += label1_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(DGVListClient);
            panel4.Location = new Point(305, 180);
            panel4.Name = "panel4";
            panel4.Size = new Size(857, 608);
            panel4.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(801, 563);
            button1.Name = "button1";
            button1.Size = new Size(27, 27);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Underline);
            label3.Location = new Point(653, 563);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 2;
            label3.Text = "Nouveau Client";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Underline);
            label2.Location = new Point(41, 25);
            label2.Name = "label2";
            label2.Size = new Size(451, 32);
            label2.TabIndex = 1;
            label2.Text = "Liste des clients actuellement enregistrés";
            // 
            // DGVListClient
            // 
            DGVListClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVListClient.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            DGVListClient.BorderStyle = BorderStyle.Fixed3D;
            DGVListClient.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            DGVListClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVListClient.Location = new Point(30, 81);
            DGVListClient.Name = "DGVListClient";
            DGVListClient.ReadOnly = true;
            DGVListClient.Size = new Size(780, 414);
            DGVListClient.TabIndex = 0;
            // 
            // buttonQuitter
            // 
            buttonQuitter.Font = new Font("Segoe UI", 12F);
            buttonQuitter.Location = new Point(50, 777);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(100, 50);
            buttonQuitter.TabIndex = 7;
            buttonQuitter.Text = "Quitter";
            buttonQuitter.UseVisualStyleBackColor = true;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1281, 877);
            Controls.Add(buttonQuitter);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Client";
            Text = "Client";
            Load += Client_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVListClient).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button BtnClientNa;
        private Button BtnPrestation;
        private Button BtnFacture;
        private Button BtnRecap;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private DataGridView DGVListClient;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button buttonQuitter;
    }
}