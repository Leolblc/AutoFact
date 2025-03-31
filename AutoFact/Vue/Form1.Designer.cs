namespace AutoFact
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
            panelClient = new Panel();
            buttonQuitter = new Button();
            buttonRecap = new Button();
            buttonFact = new Button();
            buttonPresta = new Button();
            buttonClient = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            DGVPrestation = new DataGridView();
            DGVLastClient = new DataGridView();
            dataGridViewCA = new DataGridView();
            DGVFact = new DataGridView();
            LB_Last_Cli = new Label();
            LB_Last_Presta = new Label();
            LB_Last_Fact = new Label();
            Btn_info1 = new Button();
            panelClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVPrestation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVLastClient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVFact).BeginInit();
            SuspendLayout();
            // 
            // panelClient
            // 
            panelClient.BackColor = Color.FromArgb(45, 45, 45);
            panelClient.Controls.Add(Btn_info1);
            panelClient.Controls.Add(buttonQuitter);
            panelClient.Controls.Add(buttonRecap);
            panelClient.Controls.Add(buttonFact);
            panelClient.Controls.Add(buttonPresta);
            panelClient.Controls.Add(buttonClient);
            panelClient.Controls.Add(pictureBox1);
            panelClient.Dock = DockStyle.Left;
            panelClient.Location = new Point(0, 0);
            panelClient.Name = "panelClient";
            panelClient.Size = new Size(210, 877);
            panelClient.TabIndex = 0;
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
            // buttonRecap
            // 
            buttonRecap.FlatAppearance.BorderSize = 0;
            buttonRecap.FlatStyle = FlatStyle.Flat;
            buttonRecap.Font = new Font("Segoe UI", 16F, FontStyle.Underline);
            buttonRecap.ForeColor = SystemColors.Control;
            buttonRecap.Location = new Point(29, 560);
            buttonRecap.Name = "buttonRecap";
            buttonRecap.Size = new Size(147, 46);
            buttonRecap.TabIndex = 4;
            buttonRecap.Text = "Récapitulatif";
            buttonRecap.UseVisualStyleBackColor = true;
            buttonRecap.Click += buttonRecap_Click;
            // 
            // buttonFact
            // 
            buttonFact.BackgroundImageLayout = ImageLayout.None;
            buttonFact.FlatAppearance.BorderSize = 0;
            buttonFact.FlatStyle = FlatStyle.Flat;
            buttonFact.Font = new Font("Segoe UI", 16F, FontStyle.Underline);
            buttonFact.ForeColor = SystemColors.Control;
            buttonFact.Location = new Point(29, 434);
            buttonFact.Name = "buttonFact";
            buttonFact.Size = new Size(147, 36);
            buttonFact.TabIndex = 3;
            buttonFact.Text = "Facture";
            buttonFact.UseVisualStyleBackColor = true;
            buttonFact.Click += buttonFact_Click;
            // 
            // buttonPresta
            // 
            buttonPresta.FlatAppearance.BorderSize = 0;
            buttonPresta.FlatStyle = FlatStyle.Flat;
            buttonPresta.Font = new Font("Segoe UI", 16F, FontStyle.Underline);
            buttonPresta.ForeColor = SystemColors.Control;
            buttonPresta.Location = new Point(29, 295);
            buttonPresta.Name = "buttonPresta";
            buttonPresta.Size = new Size(147, 46);
            buttonPresta.TabIndex = 2;
            buttonPresta.Text = "Prestation";
            buttonPresta.UseVisualStyleBackColor = true;
            buttonPresta.Click += buttonPresta_Click;
            // 
            // buttonClient
            // 
            buttonClient.BackColor = Color.FromArgb(45, 45, 45);
            buttonClient.FlatAppearance.BorderSize = 0;
            buttonClient.FlatStyle = FlatStyle.Flat;
            buttonClient.Font = new Font("Segoe UI", 16F, FontStyle.Underline);
            buttonClient.ForeColor = SystemColors.Control;
            buttonClient.Location = new Point(29, 180);
            buttonClient.Name = "buttonClient";
            buttonClient.Size = new Size(147, 40);
            buttonClient.TabIndex = 1;
            buttonClient.Text = "Client";
            buttonClient.UseVisualStyleBackColor = false;
            buttonClient.Click += buttonClient_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(73, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 26F);
            label1.Location = new Point(324, 67);
            label1.Name = "label1";
            label1.Size = new Size(179, 47);
            label1.TabIndex = 2;
            label1.Text = "Bienvenue";
            // 
            // DGVPrestation
            // 
            DGVPrestation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVPrestation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGVPrestation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVPrestation.EditMode = DataGridViewEditMode.EditProgrammatically;
            DGVPrestation.Location = new Point(324, 204);
            DGVPrestation.Name = "DGVPrestation";
            DGVPrestation.ReadOnly = true;
            DGVPrestation.Size = new Size(323, 200);
            DGVPrestation.TabIndex = 3;
            DGVPrestation.CellContentClick += DGVPrestation_CellContentClick;
            // 
            // DGVLastClient
            // 
            DGVLastClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVLastClient.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGVLastClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVLastClient.Location = new Point(876, 204);
            DGVLastClient.Name = "DGVLastClient";
            DGVLastClient.ReadOnly = true;
            DGVLastClient.Size = new Size(318, 200);
            DGVLastClient.TabIndex = 4;
            DGVLastClient.CellContentClick += DGVLastClient_CellContentClick;
            // 
            // dataGridViewCA
            // 
            dataGridViewCA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCA.Location = new Point(876, 528);
            dataGridViewCA.Name = "dataGridViewCA";
            dataGridViewCA.Size = new Size(318, 200);
            dataGridViewCA.TabIndex = 5;
            // 
            // DGVFact
            // 
            DGVFact.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVFact.Location = new Point(254, 528);
            DGVFact.Name = "DGVFact";
            DGVFact.Size = new Size(521, 200);
            DGVFact.TabIndex = 6;
            DGVFact.CellContentClick += DGVFact_CellContentClick;
            // 
            // LB_Last_Cli
            // 
            LB_Last_Cli.AutoSize = true;
            LB_Last_Cli.Font = new Font("Arial", 14F, FontStyle.Bold);
            LB_Last_Cli.Location = new Point(876, 166);
            LB_Last_Cli.Name = "LB_Last_Cli";
            LB_Last_Cli.Size = new Size(159, 22);
            LB_Last_Cli.TabIndex = 7;
            LB_Last_Cli.Text = "Derniers Clients";
            // 
            // LB_Last_Presta
            // 
            LB_Last_Presta.AutoSize = true;
            LB_Last_Presta.Font = new Font("Arial", 14F, FontStyle.Bold);
            LB_Last_Presta.Location = new Point(324, 166);
            LB_Last_Presta.Name = "LB_Last_Presta";
            LB_Last_Presta.Size = new Size(212, 22);
            LB_Last_Presta.TabIndex = 8;
            LB_Last_Presta.Text = "Dernières Prestations";
            // 
            // LB_Last_Fact
            // 
            LB_Last_Fact.AutoSize = true;
            LB_Last_Fact.Font = new Font("Arial", 14F, FontStyle.Bold);
            LB_Last_Fact.Location = new Point(254, 489);
            LB_Last_Fact.Name = "LB_Last_Fact";
            LB_Last_Fact.Size = new Size(188, 22);
            LB_Last_Fact.TabIndex = 9;
            LB_Last_Fact.Text = "Dernières Factures";
            // 
            // Btn_info1
            // 
            Btn_info1.BackColor = Color.FromArgb(45, 45, 45);
            Btn_info1.FlatAppearance.BorderSize = 0;
            Btn_info1.FlatStyle = FlatStyle.Flat;
            Btn_info1.Font = new Font("Segoe UI", 16F, FontStyle.Underline);
            Btn_info1.ForeColor = SystemColors.Control;
            Btn_info1.Location = new Point(6, 680);
            Btn_info1.Name = "Btn_info1";
            Btn_info1.Size = new Size(198, 48);
            Btn_info1.TabIndex = 7;
            Btn_info1.Text = "Vos Informations";
            Btn_info1.UseVisualStyleBackColor = true;
            Btn_info1.Click += Btn_info1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1281, 877);
            Controls.Add(LB_Last_Fact);
            Controls.Add(LB_Last_Presta);
            Controls.Add(LB_Last_Cli);
            Controls.Add(DGVFact);
            Controls.Add(dataGridViewCA);
            Controls.Add(DGVLastClient);
            Controls.Add(DGVPrestation);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panelClient);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVPrestation).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVLastClient).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCA).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVFact).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelClient;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button buttonClient;
        private Button buttonPresta;
        private Button buttonRecap;
        private Button buttonFact;
        private Label label1;
        private DataGridView DGVPrestation;
        private DataGridView DGVLastClient;
        private DataGridView dataGridViewCA;
        private DataGridView DGVFact;
        private Button buttonQuitter;
        private Label LB_Last_Cli;
        private Label LB_Last_Presta;
        private Label LB_Last_Fact;
        private Button Btn_info1;
    }
}
