namespace HaftalikAjanda

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
            btnPazartesi = new Button();
            btnSali = new Button();
            btnCarsamba = new Button();
            btnPersembe = new Button();
            btnCuma = new Button();
            btnCumartesi = new Button();
            btnPazar = new Button();
            pnlAnaEkran = new Panel();
            btnPazarSayisi = new Button();
            btnCumartesiSayisi = new Button();
            btnCumaSayisi = new Button();
            btnPersembeSayisi = new Button();
            btnCarsambaSayisi = new Button();
            btnSaliSayisi = new Button();
            btnPazartesiSayisi = new Button();
            lblBaslik = new Label();
            button1 = new Button();
            pnlGunEkran = new Panel();
            pnlAnaEkran.SuspendLayout();
            SuspendLayout();
            // 
            // btnPazartesi
            // 
            btnPazartesi.BackColor = SystemColors.MenuBar;
            btnPazartesi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnPazartesi.Location = new Point(0, 110);
            btnPazartesi.Name = "btnPazartesi";
            btnPazartesi.Size = new Size(702, 52);
            btnPazartesi.TabIndex = 0;
            btnPazartesi.Text = "Pazartesi";
            btnPazartesi.UseVisualStyleBackColor = false;
            btnPazartesi.Click += btnPazartesi_Click;
            // 
            // btnSali
            // 
            btnSali.Anchor = AnchorStyles.Left;
            btnSali.BackColor = SystemColors.MenuBar;
            btnSali.Location = new Point(0, 162);
            btnSali.Name = "btnSali";
            btnSali.Size = new Size(702, 52);
            btnSali.TabIndex = 1;
            btnSali.Text = "Salı";
            btnSali.UseVisualStyleBackColor = false;
            btnSali.Click += btnSali_Click;
            // 
            // btnCarsamba
            // 
            btnCarsamba.BackColor = SystemColors.MenuBar;
            btnCarsamba.Location = new Point(0, 214);
            btnCarsamba.Name = "btnCarsamba";
            btnCarsamba.Size = new Size(702, 52);
            btnCarsamba.TabIndex = 2;
            btnCarsamba.Text = "Çarşamba";
            btnCarsamba.UseVisualStyleBackColor = false;
            btnCarsamba.Click += btnCarsamba_Click;
            // 
            // btnPersembe
            // 
            btnPersembe.BackColor = SystemColors.MenuBar;
            btnPersembe.Location = new Point(0, 266);
            btnPersembe.Name = "btnPersembe";
            btnPersembe.Size = new Size(702, 52);
            btnPersembe.TabIndex = 3;
            btnPersembe.Text = "Perşembe";
            btnPersembe.UseVisualStyleBackColor = false;
            btnPersembe.Click += btnPersembe_Click;
            // 
            // btnCuma
            // 
            btnCuma.BackColor = SystemColors.MenuBar;
            btnCuma.Location = new Point(0, 318);
            btnCuma.Name = "btnCuma";
            btnCuma.Size = new Size(702, 52);
            btnCuma.TabIndex = 4;
            btnCuma.Text = "Cuma";
            btnCuma.UseVisualStyleBackColor = false;
            btnCuma.Click += btnCuma_Click;
            // 
            // btnCumartesi
            // 
            btnCumartesi.BackColor = SystemColors.MenuBar;
            btnCumartesi.Location = new Point(0, 370);
            btnCumartesi.Name = "btnCumartesi";
            btnCumartesi.Size = new Size(702, 52);
            btnCumartesi.TabIndex = 5;
            btnCumartesi.Text = "Cumartesi";
            btnCumartesi.UseVisualStyleBackColor = false;
            btnCumartesi.Click += btnCumartesi_Click;
            // 
            // btnPazar
            // 
            btnPazar.BackColor = SystemColors.MenuBar;
            btnPazar.Location = new Point(0, 422);
            btnPazar.Name = "btnPazar";
            btnPazar.Size = new Size(702, 52);
            btnPazar.TabIndex = 6;
            btnPazar.Text = "Pazar";
            btnPazar.UseVisualStyleBackColor = false;
            btnPazar.Click += btnPazar_Click;
            // 
            // pnlAnaEkran
            // 
            pnlAnaEkran.Anchor = AnchorStyles.None;
            pnlAnaEkran.Controls.Add(btnPazarSayisi);
            pnlAnaEkran.Controls.Add(btnCumartesiSayisi);
            pnlAnaEkran.Controls.Add(btnCumaSayisi);
            pnlAnaEkran.Controls.Add(btnPersembeSayisi);
            pnlAnaEkran.Controls.Add(btnCarsambaSayisi);
            pnlAnaEkran.Controls.Add(btnSaliSayisi);
            pnlAnaEkran.Controls.Add(btnPazartesiSayisi);
            pnlAnaEkran.Controls.Add(btnPazartesi);
            pnlAnaEkran.Controls.Add(lblBaslik);
            pnlAnaEkran.Controls.Add(btnSali);
            pnlAnaEkran.Controls.Add(btnCarsamba);
            pnlAnaEkran.Controls.Add(btnPersembe);
            pnlAnaEkran.Controls.Add(btnCuma);
            pnlAnaEkran.Controls.Add(btnCumartesi);
            pnlAnaEkran.Controls.Add(btnPazar);
            pnlAnaEkran.Controls.Add(button1);
            pnlAnaEkran.Location = new Point(-3, 0);
            pnlAnaEkran.Name = "pnlAnaEkran";
            pnlAnaEkran.Size = new Size(896, 474);
            pnlAnaEkran.TabIndex = 7;
            pnlAnaEkran.Visible = false;
            // 
            // btnPazarSayisi
            // 
            btnPazarSayisi.Location = new Point(700, 422);
            btnPazarSayisi.Name = "btnPazarSayisi";
            btnPazarSayisi.Size = new Size(193, 52);
            btnPazarSayisi.TabIndex = 15;
            btnPazarSayisi.Text = "0 görev";
            btnPazarSayisi.UseVisualStyleBackColor = true;
            // 
            // btnCumartesiSayisi
            // 
            btnCumartesiSayisi.Location = new Point(700, 370);
            btnCumartesiSayisi.Name = "btnCumartesiSayisi";
            btnCumartesiSayisi.Size = new Size(193, 52);
            btnCumartesiSayisi.TabIndex = 14;
            btnCumartesiSayisi.Text = "0 görev";
            btnCumartesiSayisi.UseVisualStyleBackColor = true;
            // 
            // btnCumaSayisi
            // 
            btnCumaSayisi.Location = new Point(700, 318);
            btnCumaSayisi.Name = "btnCumaSayisi";
            btnCumaSayisi.Size = new Size(193, 52);
            btnCumaSayisi.TabIndex = 13;
            btnCumaSayisi.Text = "0 görev";
            btnCumaSayisi.UseVisualStyleBackColor = true;
            // 
            // btnPersembeSayisi
            // 
            btnPersembeSayisi.Location = new Point(700, 266);
            btnPersembeSayisi.Name = "btnPersembeSayisi";
            btnPersembeSayisi.Size = new Size(193, 52);
            btnPersembeSayisi.TabIndex = 12;
            btnPersembeSayisi.Text = "0 görev";
            btnPersembeSayisi.UseVisualStyleBackColor = true;
            // 
            // btnCarsambaSayisi
            // 
            btnCarsambaSayisi.Location = new Point(700, 214);
            btnCarsambaSayisi.Name = "btnCarsambaSayisi";
            btnCarsambaSayisi.Size = new Size(193, 52);
            btnCarsambaSayisi.TabIndex = 11;
            btnCarsambaSayisi.Text = "0 görev";
            btnCarsambaSayisi.UseVisualStyleBackColor = true;
            // 
            // btnSaliSayisi
            // 
            btnSaliSayisi.Location = new Point(700, 162);
            btnSaliSayisi.Name = "btnSaliSayisi";
            btnSaliSayisi.Size = new Size(193, 52);
            btnSaliSayisi.TabIndex = 10;
            btnSaliSayisi.Text = "0 görev";
            btnSaliSayisi.UseVisualStyleBackColor = true;
            // 
            // btnPazartesiSayisi
            // 
            btnPazartesiSayisi.Location = new Point(700, 110);
            btnPazartesiSayisi.Name = "btnPazartesiSayisi";
            btnPazartesiSayisi.Size = new Size(193, 52);
            btnPazartesiSayisi.TabIndex = 9;
            btnPazartesiSayisi.Text = "0 görev";
            btnPazartesiSayisi.UseVisualStyleBackColor = true;
            // 
            // lblBaslik
            // 
            lblBaslik.Anchor = AnchorStyles.Top;
            lblBaslik.AutoSize = true;
            lblBaslik.BackColor = SystemColors.ControlDark;
            lblBaslik.Font = new Font("Modern No. 20", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBaslik.Location = new Point(153, 24);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(592, 83);
            lblBaslik.TabIndex = 7;
            lblBaslik.Text = "Haftalık Ajanda";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(896, 112);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            // 
            // pnlGunEkran
            // 
            pnlGunEkran.Dock = DockStyle.Fill;
            pnlGunEkran.Location = new Point(0, 0);
            pnlGunEkran.Name = "pnlGunEkran";
            pnlGunEkran.Size = new Size(891, 474);
            pnlGunEkran.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(891, 474);
            Controls.Add(pnlAnaEkran);
            Controls.Add(pnlGunEkran);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pnlAnaEkran.ResumeLayout(false);
            pnlAnaEkran.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPazartesi;
        private Button btnSali;
        private Button btnCarsamba;
        private Button btnPersembe;
        private Button btnCuma;
        private Button btnCumartesi;
        private Button btnPazar;
        private Panel pnlAnaEkran;
        private Panel pnlGunEkran;
        private Label lblBaslik;
        private Button button1;
        private Button btnPazartesiSayisi;
        private Button btnPazarSayisi;
        private Button btnCumartesiSayisi;
        private Button btnCumaSayisi;
        private Button btnPersembeSayisi;
        private Button btnCarsambaSayisi;
        private Button btnSaliSayisi;
    }
}
