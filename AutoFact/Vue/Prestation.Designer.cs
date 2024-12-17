namespace AutoFact
{
    partial class Prestation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestation));
            panel1 = new Panel();
            buttonRecap3 = new Button();
            buttonFact3 = new Button();
            buttonPresta3 = new Button();
            buttonClient3 = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            BtnAddPresta = new Button();
            label3 = new Label();
            label2 = new Label();
            DGVListClient = new DataGridView();
            buttonQuitter = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVListClient).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel1.Controls.Add(buttonRecap3);
            panel1.Controls.Add(buttonFact3);
            panel1.Controls.Add(buttonPresta3);
            panel1.Controls.Add(buttonClient3);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 877);
            panel1.TabIndex = 0;
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
            buttonFact3.ForeColor = SystemColors.Control;
            buttonFact3.Location = new Point(29, 434);
            buttonFact3.Name = "buttonFact3";
            buttonFact3.Size = new Size(147, 36);
            buttonFact3.TabIndex = 4;
            buttonFact3.Text = "Facture";
            buttonFact3.UseVisualStyleBackColor = true;
            buttonFact3.Click += buttonFact3_Click;
            // 
            // buttonPresta3
            // 
            buttonPresta3.FlatAppearance.BorderSize = 0;
            buttonPresta3.FlatStyle = FlatStyle.Flat;
            buttonPresta3.Font = new Font("Segoe UI", 16F, FontStyle.Underline);
            buttonPresta3.ForeColor = SystemColors.ActiveBorder;
            buttonPresta3.Location = new Point(29, 295);
            buttonPresta3.Name = "buttonPresta3";
            buttonPresta3.Size = new Size(147, 46);
            buttonPresta3.TabIndex = 3;
            buttonPresta3.Text = "Prestation";
            buttonPresta3.UseVisualStyleBackColor = true;
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
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackgroundImageLayout = ImageLayout.None;
            panel5.Controls.Add(label1);
            panel5.ImeMode = ImeMode.Disable;
            panel5.Location = new Point(290, 92);
            panel5.Name = "panel5";
            panel5.Size = new Size(857, 64);
            panel5.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label1.Location = new Point(16, 3);
            label1.Name = "label1";
            label1.Size = new Size(204, 47);
            label1.TabIndex = 0;
            label1.Text = "Prestations";
            label1.Click += label1_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(BtnAddPresta);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(DGVListClient);
            panel6.Location = new Point(290, 180);
            panel6.Name = "panel6";
            panel6.Size = new Size(857, 608);
            panel6.TabIndex = 3;
            // 
            // BtnAddPresta
            // 
            BtnAddPresta.BackgroundImageLayout = ImageLayout.None;
            BtnAddPresta.FlatAppearance.BorderSize = 0;
            BtnAddPresta.FlatStyle = FlatStyle.Flat;
            BtnAddPresta.ForeColor = Color.Transparent;
            BtnAddPresta.Image = (Image)resources.GetObject("BtnAddPresta.Image");
            BtnAddPresta.Location = new Point(801, 563);
            BtnAddPresta.Name = "BtnAddPresta";
            BtnAddPresta.Size = new Size(27, 27);
            BtnAddPresta.TabIndex = 3;
            BtnAddPresta.UseVisualStyleBackColor = true;
            BtnAddPresta.Click += BtnAddPresta_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Underline);
            label3.Location = new Point(594, 563);
            label3.Name = "label3";
            label3.Size = new Size(201, 25);
            label3.TabIndex = 2;
            label3.Text = "Ajouter une prestation";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Underline);
            label2.Location = new Point(41, 25);
            label2.Name = "label2";
            label2.Size = new Size(230, 32);
            label2.TabIndex = 1;
            label2.Text = "Liste des prestations";
            // 
            // DGVListClient
            // 
            DGVListClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVListClient.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
            buttonQuitter.TabIndex = 6;
            buttonQuitter.Text = "Quitter";
            buttonQuitter.UseVisualStyleBackColor = true;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // Prestation
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
            Name = "Prestation";
            Text = "Prestation";
            Load += Prestation_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVListClient).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button buttonClient3;
        private Button buttonPresta3;
        private Button buttonFact3;
        private Button buttonRecap3;
        private Panel panel5;
        private Label label1;
        private Panel panel6;
        private Button BtnAddPresta;
        private Label label3;
        private Label label2;
        private DataGridView DGVListClient;
        private Button buttonQuitter;
    }
}