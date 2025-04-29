namespace AutoFact
{
    partial class Facturation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturation));
            panel1 = new Panel();
            buttonRecap3 = new Button();
            buttonFact3 = new Button();
            buttonPresta3 = new Button();
            buttonClient3 = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel6 = new Panel();
            BtnExportPDF = new Button();
            CBPDF = new ComboBox();
            BtnAddFact = new Button();
            label3 = new Label();
            label2 = new Label();
            DGVFacturation = new DataGridView();
            panel5 = new Panel();
            label1 = new Label();
            buttonQuitter = new Button();
            Btn_info1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVFacturation).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel1.Controls.Add(Btn_info1);
            panel1.Controls.Add(buttonRecap3);
            panel1.Controls.Add(buttonFact3);
            panel1.Controls.Add(buttonPresta3);
            panel1.Controls.Add(buttonClient3);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 877);
            panel1.TabIndex = 1;
            // 
            // buttonRecap3
            // 
            buttonRecap3.FlatAppearance.BorderSize = 0;
            buttonRecap3.FlatStyle = FlatStyle.Flat;
            buttonRecap3.Font = new Font("Segoe UI", 16F, FontStyle.Underline);
            buttonRecap3.ForeColor = SystemColors.Control;
            buttonRecap3.Location = new Point(29, 560);
            buttonRecap3.Name = "buttonRecap3";
            buttonRecap3.Size = new Size(147, 46);
            buttonRecap3.TabIndex = 5;
            buttonRecap3.Text = "Récapitulatif";
            buttonRecap3.UseVisualStyleBackColor = true;
            buttonRecap3.Click += buttonRecap3_Click;
            // 
            // buttonFact3
            // 
            buttonFact3.BackgroundImageLayout = ImageLayout.None;
            buttonFact3.FlatAppearance.BorderSize = 0;
            buttonFact3.FlatStyle = FlatStyle.Flat;
            buttonFact3.Font = new Font("Segoe UI", 16F, FontStyle.Underline);
            buttonFact3.ForeColor = SystemColors.ActiveBorder;
            buttonFact3.Location = new Point(29, 434);
            buttonFact3.Name = "buttonFact3";
            buttonFact3.Size = new Size(147, 36);
            buttonFact3.TabIndex = 4;
            buttonFact3.Text = "Facture";
            buttonFact3.UseVisualStyleBackColor = true;
            // 
            // buttonPresta3
            // 
            buttonPresta3.FlatAppearance.BorderSize = 0;
            buttonPresta3.FlatStyle = FlatStyle.Flat;
            buttonPresta3.Font = new Font("Segoe UI", 16F, FontStyle.Underline);
            buttonPresta3.ForeColor = SystemColors.Control;
            buttonPresta3.Location = new Point(29, 295);
            buttonPresta3.Name = "buttonPresta3";
            buttonPresta3.Size = new Size(147, 46);
            buttonPresta3.TabIndex = 3;
            buttonPresta3.Text = "Prestation";
            buttonPresta3.UseVisualStyleBackColor = true;
            buttonPresta3.Click += buttonPresta3_Click;
            // 
            // buttonClient3
            // 
            buttonClient3.BackColor = Color.FromArgb(45, 45, 45);
            buttonClient3.FlatAppearance.BorderSize = 0;
            buttonClient3.FlatStyle = FlatStyle.Flat;
            buttonClient3.Font = new Font("Segoe UI", 16F, FontStyle.Underline);
            buttonClient3.ForeColor = SystemColors.Control;
            buttonClient3.Location = new Point(29, 180);
            buttonClient3.Name = "buttonClient3";
            buttonClient3.Size = new Size(147, 40);
            buttonClient3.TabIndex = 2;
            buttonClient3.Text = "Client";
            buttonClient3.UseVisualStyleBackColor = false;
            buttonClient3.Click += buttonClient3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
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
            panel2.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(BtnExportPDF);
            panel6.Controls.Add(CBPDF);
            panel6.Controls.Add(BtnAddFact);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(DGVFacturation);
            panel6.Location = new Point(316, 152);
            panel6.Name = "panel6";
            panel6.Size = new Size(857, 608);
            panel6.TabIndex = 5;
            // 
            // BtnExportPDF
            // 
            BtnExportPDF.Location = new Point(180, 550);
            BtnExportPDF.Name = "BtnExportPDF";
            BtnExportPDF.Size = new Size(75, 23);
            BtnExportPDF.TabIndex = 5;
            BtnExportPDF.Text = "Exporter";
            BtnExportPDF.UseVisualStyleBackColor = true;
            BtnExportPDF.Click += BtnExportPDF_Click;
            // 
            // CBPDF
            // 
            CBPDF.FormattingEnabled = true;
            CBPDF.Location = new Point(41, 550);
            CBPDF.Name = "CBPDF";
            CBPDF.Size = new Size(121, 23);
            CBPDF.TabIndex = 4;
            CBPDF.SelectedIndexChanged += CBPDF_SelectedIndexChanged_1;
            // 
            // BtnAddFact
            // 
            BtnAddFact.BackgroundImageLayout = ImageLayout.None;
            BtnAddFact.FlatAppearance.BorderSize = 0;
            BtnAddFact.FlatStyle = FlatStyle.Flat;
            BtnAddFact.ForeColor = Color.Transparent;
            BtnAddFact.Image = (Image)resources.GetObject("BtnAddFact.Image");
            BtnAddFact.Location = new Point(801, 563);
            BtnAddFact.Name = "BtnAddFact";
            BtnAddFact.Size = new Size(27, 27);
            BtnAddFact.TabIndex = 3;
            BtnAddFact.UseVisualStyleBackColor = true;
            BtnAddFact.Click += BtnAddFact_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Underline);
            label3.Location = new Point(620, 563);
            label3.Name = "label3";
            label3.Size = new Size(175, 25);
            label3.TabIndex = 2;
            label3.Text = "Ajouter une facture";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Underline);
            label2.Location = new Point(41, 25);
            label2.Name = "label2";
            label2.Size = new Size(197, 32);
            label2.TabIndex = 1;
            label2.Text = "Liste des factures";
            // 
            // DGVFacturation
            // 
            DGVFacturation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVFacturation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGVFacturation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVFacturation.Location = new Point(30, 81);
            DGVFacturation.Name = "DGVFacturation";
            DGVFacturation.ReadOnly = true;
            DGVFacturation.Size = new Size(780, 414);
            DGVFacturation.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackgroundImageLayout = ImageLayout.None;
            panel5.Controls.Add(label1);
            panel5.ImeMode = ImeMode.Disable;
            panel5.Location = new Point(316, 64);
            panel5.Name = "panel5";
            panel5.Size = new Size(857, 64);
            panel5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label1.Location = new Point(16, 3);
            label1.Name = "label1";
            label1.Size = new Size(207, 47);
            label1.TabIndex = 0;
            label1.Text = "Facturation";
            // 
            // buttonQuitter
            // 
            buttonQuitter.Font = new Font("Segoe UI", 12F);
            buttonQuitter.Location = new Point(50, 777);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(100, 50);
            buttonQuitter.TabIndex = 6;
            buttonQuitter.Text = "Quitter";
            buttonQuitter.UseVisualStyleBackColor = true;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // Btn_info1
            // 
            Btn_info1.BackColor = Color.FromArgb(45, 45, 45);
            Btn_info1.FlatAppearance.BorderSize = 0;
            Btn_info1.FlatStyle = FlatStyle.Flat;
            Btn_info1.Font = new Font("Segoe UI", 16F, FontStyle.Underline);
            Btn_info1.ForeColor = SystemColors.Control;
            Btn_info1.Location = new Point(6, 669);
            Btn_info1.Name = "Btn_info1";
            Btn_info1.Size = new Size(198, 48);
            Btn_info1.TabIndex = 8;
            Btn_info1.Text = "Vos Informations";
            Btn_info1.UseVisualStyleBackColor = true;
            Btn_info1.Click += Btn_info1_Click;
            // 
            // Facturation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1281, 877);
            Controls.Add(buttonQuitter);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Facturation";
            Text = "Facturation";
            Load += Facturation_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVFacturation).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonRecap3;
        private Button buttonFact3;
        private Button buttonPresta3;
        private Button buttonClient3;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel6;
        private Button BtnAddFact;
        private Label label3;
        private Label label2;
        private DataGridView DGVFacturation;
        private Panel panel5;
        private Label label1;
        private Button BtnExportPDF;
        private ComboBox CBPDF;
        private Button buttonQuitter;
        private Button Btn_info1;
    }
}