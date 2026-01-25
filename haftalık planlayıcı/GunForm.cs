using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace HaftalikAjanda
{
    public partial class GunForm : Form
    {
        private string gunAdi;
        private Form1 anaForm;

        public GunForm(string gunAdi, Form1 form)
        {
            InitializeComponent();
            this.gunAdi = gunAdi;
            this.anaForm = form;

            lblGunAdi.Text = gunAdi;
            lblGunAdi.Font = new Font("Modern No. 20", 18, FontStyle.Bold);

            OrtalaGunEkrani();

            // Daha önce kaydedilmiş görevleri yükle
            if (anaForm.Gorevler.ContainsKey(gunAdi))
            {
                foreach (Gorev gorev in anaForm.Gorevler[gunAdi])
                {
                    GorevPanelOlustur(gorev);
                }
            }

            // Görev sayısını güncelle
            anaForm.GorevSayisiniGuncelle(gunAdi);
        }

        // Pencere boyutu değiştiğinde ortala
        private void GunForm_Resize(object sender, EventArgs e)
        {
            OrtalaGunEkrani();
        }

        private void OrtalaGunEkrani()
        {
            // Gün adı label
            lblGunAdi.Left = (this.ClientSize.Width - lblGunAdi.Width) / 2;
            lblGunAdi.Top = 20;

            // Görevler FlowLayoutPanel
            flpGorevler.Left = (this.ClientSize.Width - flpGorevler.Width) / 2;
            flpGorevler.Top = 70;

            // Görev ekle butonu
            btnGorevEkle.Left = (this.ClientSize.Width - btnGorevEkle.Width) / 2;
            btnGorevEkle.Top = flpGorevler.Bottom + 10;
        }

        private void btnGorevEkle_Click(object sender, EventArgs e)
        {
            string gorevMetni = Interaction.InputBox("Görevi yaz:", "Yeni Görev Ekle", "");
            if (string.IsNullOrWhiteSpace(gorevMetni)) return;

            Gorev yeniGorev = new Gorev(gorevMetni);

            if (!anaForm.Gorevler.ContainsKey(gunAdi))
                anaForm.Gorevler[gunAdi] = new List<Gorev>();

            anaForm.Gorevler[gunAdi].Add(yeniGorev);

            GorevPanelOlustur(yeniGorev);

            // Görev sayısını güncelle
            anaForm.GorevSayisiniGuncelle(gunAdi);
        }

        private void GorevPanelOlustur(Gorev gorev)
        {
            Panel gorevPanel = new Panel();
            gorevPanel.Width = flpGorevler.Width - 25;
            gorevPanel.Height = 45;

            Button btnGorev = new Button();
            btnGorev.Text = gorev.Metin;
            btnGorev.Width = gorevPanel.Width - 50;
            btnGorev.Height = 40;
            btnGorev.Location = new Point(0, 0);
            btnGorev.BackColor = gorev.Renk;
            btnGorev.TextAlign = ContentAlignment.MiddleLeft;
            btnGorev.AutoEllipsis = true;        // Üç nokta görünmesi için
            btnGorev.AutoSize = false;
            btnGorev.MaximumSize = new Size(gorevPanel.Width - 50, 100);

            Button btnAyar = new Button();
            btnAyar.Text = "⋮";
            btnAyar.Width = 40;
            btnAyar.Height = 40;
            btnAyar.Location = new Point(btnGorev.Width + 5, 0);

            Panel menuPanel = new Panel();
            menuPanel.Width = gorevPanel.Width;
            menuPanel.Height = 40;
            menuPanel.Location = new Point(0, 45);
            menuPanel.Visible = false;

            Button btnYapildi = new Button() { Text = "Yapıldı", BackColor = Color.LightGreen, Width = 90, Height = 35, TextAlign = ContentAlignment.MiddleCenter };
            Button btnDevamEdiyor = new Button() { Text = "Devam Ediyor", BackColor = Color.Khaki, Width = 180, Height = 35, TextAlign = ContentAlignment.MiddleCenter };
            Button btnYapilmadi = new Button() { Text = "Yapılmadı", BackColor = Color.LightCoral, Width = 90, Height = 35, TextAlign = ContentAlignment.MiddleCenter };
            Button btnSil = new Button() { Text = "Sil", Width = 60, Height = 35, TextAlign = ContentAlignment.MiddleCenter };

            FlowLayoutPanel flpMenu = new FlowLayoutPanel();
            flpMenu.Dock = DockStyle.Fill;
            flpMenu.Controls.Add(btnYapildi);
            flpMenu.Controls.Add(btnDevamEdiyor);
            flpMenu.Controls.Add(btnYapilmadi);
            flpMenu.Controls.Add(btnSil);

            menuPanel.Controls.Add(flpMenu);

            btnAyar.Click += (s, e) =>
            {
                menuPanel.Visible = !menuPanel.Visible;
                gorevPanel.Height = menuPanel.Visible ? 85 : 45;
            };

            btnYapildi.Click += (s, e) => { gorev.Renk = Color.LightGreen; btnGorev.BackColor = gorev.Renk; };
            btnDevamEdiyor.Click += (s, e) => { gorev.Renk = Color.Khaki; btnGorev.BackColor = gorev.Renk; };
            btnYapilmadi.Click += (s, e) => { gorev.Renk = Color.LightCoral; btnGorev.BackColor = gorev.Renk; };

            btnSil.Click += (s, e) =>
            {
                flpGorevler.Controls.Remove(gorevPanel);
                anaForm.Gorevler[gunAdi].Remove(gorev);
                anaForm.GorevSayisiniGuncelle(gunAdi);
            };

            gorevPanel.Controls.Add(btnGorev);
            gorevPanel.Controls.Add(btnAyar);
            gorevPanel.Controls.Add(menuPanel);
            flpGorevler.Controls.Add(gorevPanel);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            anaForm.Controls["pnlGunEkran"].Visible = false;
            anaForm.Controls["pnlAnaEkran"].Visible = true;
            anaForm.Controls["pnlAnaEkran"].BringToFront();
        }

        private void flpGorevler_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
