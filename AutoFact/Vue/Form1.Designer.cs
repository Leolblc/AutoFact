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
            dataGridViewDebitnonpayer = new DataGridView();
            panelClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVPrestation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVLastClient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDebitnonpayer).BeginInit();
            SuspendLayout();
            // 
            // panelClient
            // 
            panelClient.BackColor = Color.FromArgb(45, 45, 45);
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
            // dataGridViewDebitnonpayer
            // 
            dataGridViewDebitnonpayer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDebitnonpayer.Location = new Point(324, 528);
            dataGridViewDebitnonpayer.Name = "dataGridViewDebitnonpayer";
            dataGridViewDebitnonpayer.Size = new Size(323, 200);
            dataGridViewDebitnonpayer.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1281, 877);
            Controls.Add(dataGridViewDebitnonpayer);
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewDebitnonpayer).EndInit();
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
        private DataGridView dataGridViewDebitnonpayer;
    }
}
