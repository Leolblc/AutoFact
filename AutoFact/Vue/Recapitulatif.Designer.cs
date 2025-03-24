namespace AutoFact.Vue
{
    partial class Recapitulatif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recapitulatif));
            panel2 = new Panel();
            panelClient = new Panel();
            buttonQuitter = new Button();
            buttonRecap = new Button();
            buttonFact = new Button();
            buttonPresta = new Button();
            buttonClient = new Button();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            label1 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            ARPT = new DataGridView();
            ARPM = new DataGridView();
            dataGridViewT = new DataGridView();
            dataGridViewM = new DataGridView();
            label2 = new Label();
            panelClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ARPT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ARPM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewM).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(237, 54, 54);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(210, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 877);
            panel2.TabIndex = 3;
            // 
            // panelClient
            // 
            panelClient.BackColor = Color.FromArgb(45, 45, 45);
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
            panelClient.TabIndex = 2;
            // 
            // buttonQuitter
            // 
            buttonQuitter.Font = new Font("Segoe UI", 12F);
            buttonQuitter.Location = new Point(50, 777);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(100, 50);
            buttonQuitter.TabIndex = 5;
            buttonQuitter.Text = "Quitter";
            buttonQuitter.UseVisualStyleBackColor = true;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // buttonRecap
            // 
            buttonRecap.FlatAppearance.BorderSize = 0;
            buttonRecap.FlatStyle = FlatStyle.Flat;
            buttonRecap.Font = new Font("Segoe UI", 16F, FontStyle.Underline);
            buttonRecap.ForeColor = SystemColors.ButtonShadow;
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
            buttonFact.Click += buttonFact_Click_1;
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
            buttonPresta.Click += buttonPresta_Click_1;
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
            buttonClient.Click += buttonClient_Click_1;
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
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackgroundImageLayout = ImageLayout.None;
            panel5.Controls.Add(label1);
            panel5.ImeMode = ImeMode.Disable;
            panel5.Location = new Point(351, 64);
            panel5.Name = "panel5";
            panel5.Size = new Size(796, 82);
            panel5.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(3, 18);
            label1.Name = "label1";
            label1.Size = new Size(230, 47);
            label1.TabIndex = 0;
            label1.Text = "Récapitulatif";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ImageAlign = ContentAlignment.TopLeft;
            label3.Location = new Point(246, 163);
            label3.Name = "label3";
            label3.Size = new Size(256, 32);
            label3.TabIndex = 10;
            label3.Text = "Votre cumul mensuel";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ARPT);
            panel1.Controls.Add(ARPM);
            panel1.Controls.Add(dataGridViewT);
            panel1.Controls.Add(dataGridViewM);
            panel1.ImeMode = ImeMode.Disable;
            panel1.Location = new Point(229, 152);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(1028, 720);
            panel1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.ImageAlign = ContentAlignment.TopLeft;
            label4.Location = new Point(17, 379);
            label4.Name = "label4";
            label4.Size = new Size(278, 32);
            label4.TabIndex = 13;
            label4.Text = "Votre cumul trimestriel";
            // 
            // ARPT
            // 
            ARPT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ARPT.Location = new Point(777, 541);
            ARPT.Name = "ARPT";
            ARPT.ReadOnly = true;
            ARPT.Size = new Size(233, 148);
            ARPT.TabIndex = 12;
            // 
            // ARPM
            // 
            ARPM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ARPM.Location = new Point(777, 161);
            ARPM.Name = "ARPM";
            ARPM.ReadOnly = true;
            ARPM.Size = new Size(233, 148);
            ARPM.TabIndex = 11;
            // 
            // dataGridViewT
            // 
            dataGridViewT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewT.Location = new Point(17, 426);
            dataGridViewT.Name = "dataGridViewT";
            dataGridViewT.ReadOnly = true;
            dataGridViewT.Size = new Size(993, 263);
            dataGridViewT.TabIndex = 6;
            // 
            // dataGridViewM
            // 
            dataGridViewM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewM.Location = new Point(17, 46);
            dataGridViewM.Name = "dataGridViewM";
            dataGridViewM.ReadOnly = true;
            dataGridViewM.Size = new Size(993, 263);
            dataGridViewM.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.Location = new Point(246, 543);
            label2.Name = "label2";
            label2.Size = new Size(278, 32);
            label2.TabIndex = 12;
            label2.Text = "Votre cumul trimestriel";
            // 
            // Recapitulatif
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1281, 877);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panelClient);
            Name = "Recapitulatif";
            Text = "Recapitulatif";
            Load += Recapitulatif_Load;
            panelClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ARPT).EndInit();
            ((System.ComponentModel.ISupportInitialize)ARPM).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewT).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panelClient;
        private Button buttonRecap;
        private Button buttonFact;
        private Button buttonPresta;
        private Button buttonClient;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Label label1;
        private Label label3;
        private Panel panel1;
        private DataGridView ARPT;
        private DataGridView ARPM;
        private DataGridView dataGridViewT;
        private DataGridView dataGridViewM;
        private Label label2;
        private Label label4;
        private Button buttonQuitter;
    }
}