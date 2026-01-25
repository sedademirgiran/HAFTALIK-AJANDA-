using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace HaftalikAjanda
{
    partial class GorevEkleForm
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

        private void InitializeComponent()
        {
            grpGorev = new GroupBox();
            lblGorev = new Label();
            txtGorev = new TextBox();
            btnEkle = new Button();
            btnIptal = new Button();
            grpGorev.SuspendLayout();
            SuspendLayout();
            // 
            // grpGorev
            // 
            grpGorev.Controls.Add(lblGorev);
            grpGorev.Controls.Add(txtGorev);
            grpGorev.Location = new Point(20, 20);
            grpGorev.Name = "grpGorev";
            grpGorev.Size = new Size(260, 100);
            grpGorev.TabIndex = 0;
            grpGorev.TabStop = false;
            grpGorev.Text = "Görev Bilgisi";
            // 
            // lblGorev
            // 
            lblGorev.AutoSize = true;
            lblGorev.Location = new Point(10, 30);
            lblGorev.Name = "lblGorev";
            lblGorev.Size = new Size(51, 20);
            lblGorev.TabIndex = 0;
            lblGorev.Text = "Görev:";
            // 
            // txtGorev
            // 
            txtGorev.Location = new Point(70, 27);
            txtGorev.Name = "txtGorev";
            txtGorev.Size = new Size(170, 27);
            txtGorev.TabIndex = 1;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(40, 140);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(90, 30);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(150, 140);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(90, 30);
            btnIptal.TabIndex = 2;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // GorevEkleForm
            // 
            ClientSize = new Size(298, 192);
            Controls.Add(grpGorev);
            Controls.Add(btnEkle);
            Controls.Add(btnIptal);
            Name = "GorevEkleForm";
            Text = "Görev Ekle";
            grpGorev.ResumeLayout(false);
            grpGorev.PerformLayout();
            ResumeLayout(false);
        }

        private GroupBox grpGorev;
        private Label lblGorev;
        private TextBox txtGorev;
        private Button btnEkle;
        private Button btnIptal;
    }
}
