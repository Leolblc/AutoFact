namespace AutoFact
{
    partial class AjoutFacturation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutFacturation));
            panelClient = new Panel();
            buttonRecap = new Button();
            buttonFact = new Button();
            buttonPresta = new Button();
            buttonClient = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            label8 = new Label();
            panel4 = new Panel();
            LBDate = new Label();
            DTPDate = new DateTimePicker();
            TBEscompte = new TextBox();
            LBEscompte = new Label();
            CBNpresta = new ComboBox();
            NUDQte = new NumericUpDown();
            CBListCli = new ComboBox();
            TBDescription = new TextBox();
            buttonValider = new Button();
            label34 = new Label();
            label7 = new Label();
            label6 = new Label();
            label56 = new Label();
            label3 = new Label();
            TBNomFacture = new TextBox();
            buttonQuitter = new Button();
            Btn_info1 = new Button();
            panelClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUDQte).BeginInit();
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
            panelClient.TabIndex = 1;
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
            buttonFact.ForeColor = SystemColors.ActiveBorder;
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(label8);
            panel1.ImeMode = ImeMode.Disable;
            panel1.Location = new Point(289, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(739, 64);
            panel1.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label8.Location = new Point(16, 3);
            label8.Name = "label8";
            label8.Size = new Size(298, 47);
            label8.TabIndex = 0;
            label8.Text = "Nouvelle Facture";
            // 
            // panel4
            // 
            panel4.Controls.Add(LBDate);
            panel4.Controls.Add(DTPDate);
            panel4.Controls.Add(TBEscompte);
            panel4.Controls.Add(LBEscompte);
            panel4.Controls.Add(CBNpresta);
            panel4.Controls.Add(NUDQte);
            panel4.Controls.Add(CBListCli);
            panel4.Controls.Add(TBDescription);
            panel4.Controls.Add(buttonValider);
            panel4.Controls.Add(label34);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label56);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(TBNomFacture);
            panel4.Location = new Point(289, 180);
            panel4.Name = "panel4";
            panel4.Size = new Size(857, 608);
            panel4.TabIndex = 4;
            // 
            // LBDate
            // 
            LBDate.AutoSize = true;
            LBDate.Font = new Font("Arial", 14F);
            LBDate.Location = new Point(328, 230);
            LBDate.Name = "LBDate";
            LBDate.Size = new Size(169, 22);
            LBDate.TabIndex = 21;
            LBDate.Text = "Date de facturation";
            // 
            // DTPDate
            // 
            DTPDate.Location = new Point(328, 266);
            DTPDate.Name = "DTPDate";
            DTPDate.Size = new Size(200, 23);
            DTPDate.TabIndex = 20;
            // 
            // TBEscompte
            // 
            TBEscompte.Location = new Point(46, 370);
            TBEscompte.Name = "TBEscompte";
            TBEscompte.Size = new Size(243, 23);
            TBEscompte.TabIndex = 19;
            // 
            // LBEscompte
            // 
            LBEscompte.AutoSize = true;
            LBEscompte.Font = new Font("Arial", 14F);
            LBEscompte.Location = new Point(46, 327);
            LBEscompte.Name = "LBEscompte";
            LBEscompte.Size = new Size(97, 22);
            LBEscompte.TabIndex = 18;
            LBEscompte.Text = "Escompte";
            // 
            // CBNpresta
            // 
            CBNpresta.FormattingEnabled = true;
            CBNpresta.Location = new Point(328, 178);
            CBNpresta.Name = "CBNpresta";
            CBNpresta.Size = new Size(184, 23);
            CBNpresta.TabIndex = 16;
            // 
            // NUDQte
            // 
            NUDQte.Location = new Point(46, 179);
            NUDQte.Name = "NUDQte";
            NUDQte.Size = new Size(120, 23);
            NUDQte.TabIndex = 15;
            // 
            // CBListCli
            // 
            CBListCli.FormattingEnabled = true;
            CBListCli.Location = new Point(43, 266);
            CBListCli.Name = "CBListCli";
            CBListCli.Size = new Size(175, 23);
            CBListCli.TabIndex = 14;
            CBListCli.SelectedIndexChanged += CBListCli_SelectedIndexChanged;
            // 
            // TBDescription
            // 
            TBDescription.Location = new Point(41, 473);
            TBDescription.Name = "TBDescription";
            TBDescription.Size = new Size(466, 23);
            TBDescription.TabIndex = 13;
            // 
            // buttonValider
            // 
            buttonValider.BackColor = Color.Transparent;
            buttonValider.FlatStyle = FlatStyle.Popup;
            buttonValider.Font = new Font("Segoe UI", 18F, FontStyle.Underline);
            buttonValider.Location = new Point(41, 532);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(101, 39);
            buttonValider.TabIndex = 12;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = false;
            buttonValider.Click += buttonValider_Click;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Arial", 14F);
            label34.Location = new Point(46, 448);
            label34.Name = "label34";
            label34.Size = new Size(106, 22);
            label34.TabIndex = 11;
            label34.Text = "Description";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 14F);
            label7.Location = new Point(44, 230);
            label7.Name = "label7";
            label7.Size = new Size(58, 22);
            label7.TabIndex = 10;
            label7.Text = "Client";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14F);
            label6.Location = new Point(44, 139);
            label6.Name = "label6";
            label6.Size = new Size(80, 22);
            label6.TabIndex = 9;
            label6.Text = "Quantité";
            // 
            // label56
            // 
            label56.AutoSize = true;
            label56.Font = new Font("Arial", 14F);
            label56.Location = new Point(328, 139);
            label56.Name = "label56";
            label56.Size = new Size(184, 22);
            label56.TabIndex = 8;
            label56.Text = "Nom de la prestation";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14F);
            label3.Location = new Point(41, 40);
            label3.Name = "label3";
            label3.Size = new Size(165, 22);
            label3.TabIndex = 7;
            label3.Text = "Nom de la Facture";
            // 
            // TBNomFacture
            // 
            TBNomFacture.Location = new Point(44, 75);
            TBNomFacture.Name = "TBNomFacture";
            TBNomFacture.Size = new Size(468, 23);
            TBNomFacture.TabIndex = 2;
            // 
            // buttonQuitter
            // 
            buttonQuitter.Font = new Font("Segoe UI", 12F);
            buttonQuitter.Location = new Point(50, 777);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(100, 50);
            buttonQuitter.TabIndex = 9;
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
            Btn_info1.Location = new Point(6, 680);
            Btn_info1.Name = "Btn_info1";
            Btn_info1.Size = new Size(198, 48);
            Btn_info1.TabIndex = 10;
            Btn_info1.Text = "Vos Informations";
            Btn_info1.UseVisualStyleBackColor = true;
            Btn_info1.Click += Btn_info1_Click;
            // 
            // AjoutFacturation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1281, 877);
            Controls.Add(Btn_info1);
            Controls.Add(buttonQuitter);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panelClient);
            Name = "AjoutFacturation";
            Text = "AjoutFacturation";
            Load += AjoutFacturation_Load;
            panelClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUDQte).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelClient;
        private Button buttonRecap;
        private Button buttonFact;
        private Button buttonPresta;
        private Button buttonClient;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel1;
        private Label label8;
        private Panel panel4;
        private Button buttonValider;
        private Label label34;
        private Label label7;
        private Label label6;
        private Label label56;
        private Label label3;
        private TextBox TBNomFacture;
        private ComboBox CBListCli;
        private TextBox TBDescription;
        private NumericUpDown NUDQte;
        private ComboBox CBNpresta;
        private Label LBEscompte;
        private TextBox TBEscompte;
        private DateTimePicker DTPDate;
        private Label LBDate;
        private Button buttonQuitter;
        private Button Btn_info1;
    }
}