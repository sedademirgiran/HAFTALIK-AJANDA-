namespace HaftalikAjanda
{
    partial class GunForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblGunAdi = new Label();
            btnGorevEkle = new Button();
            flpGorevler = new FlowLayoutPanel();
            btnGeri = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblGunAdi
            // 
            lblGunAdi.AutoSize = true;
            lblGunAdi.BackColor = SystemColors.ControlDark;
            lblGunAdi.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGunAdi.ForeColor = SystemColors.ControlText;
            lblGunAdi.Location = new Point(75, 17);
            lblGunAdi.Name = "lblGunAdi";
            lblGunAdi.Size = new Size(44, 22);
            lblGunAdi.TabIndex = 0;
            lblGunAdi.Text = "Gün";
            lblGunAdi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGorevEkle
            // 
            btnGorevEkle.BackColor = SystemColors.MenuBar;
            btnGorevEkle.Dock = DockStyle.Bottom;
            btnGorevEkle.Location = new Point(0, 386);
            btnGorevEkle.Name = "btnGorevEkle";
            btnGorevEkle.Size = new Size(876, 40);
            btnGorevEkle.TabIndex = 1;
            btnGorevEkle.Text = "Görev Ekle";
            btnGorevEkle.UseVisualStyleBackColor = false;
            btnGorevEkle.Click += btnGorevEkle_Click;
            // 
            // flpGorevler
            // 
            flpGorevler.AutoScroll = true;
            flpGorevler.BackColor = SystemColors.ScrollBar;
            flpGorevler.FlowDirection = FlowDirection.TopDown;
            flpGorevler.Location = new Point(0, 60);
            flpGorevler.Name = "flpGorevler";
            flpGorevler.Size = new Size(888, 366);
            flpGorevler.TabIndex = 2;
            flpGorevler.WrapContents = false;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = SystemColors.MenuBar;
            btnGeri.Location = new Point(0, 2);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(56, 55);
            btnGeri.TabIndex = 1;
            btnGeri.Text = "←";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Location = new Point(43, 2);
            button1.Name = "button1";
            button1.Size = new Size(835, 55);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            // 
            // GunForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(876, 426);
            Controls.Add(lblGunAdi);
            Controls.Add(btnGeri);
            Controls.Add(btnGorevEkle);
            Controls.Add(flpGorevler);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GunForm";
            Text = "GunForm";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label lblGunAdi;
        private Button btnGorevEkle;
        private FlowLayoutPanel flpGorevler;
        private Button btnGeri;
        private Button button1;
    }
}
