using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HaftalikAjanda
{
    public partial class Form1 : Form
    {
        public Dictionary<string, List<Gorev>> Gorevler = new Dictionary<string, List<Gorev>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlAnaEkran.Visible = true;
            pnlGunEkran.Visible = false;
            OrtalaAnaEkran();
        }
        private void OrtalaAnaEkran()
        {
            pnlAnaEkran.Left = (this.ClientSize.Width - pnlAnaEkran.Width) / 2;
            pnlAnaEkran.Top = (this.ClientSize.Height - pnlAnaEkran.Height) / 2;
        }
        private void GunAc(string gunAdi)
        {
            pnlGunEkran.Controls.Clear();

            GunForm gunForm = new GunForm(gunAdi, this);
            gunForm.TopLevel = false;
            gunForm.FormBorderStyle = FormBorderStyle.None;
            gunForm.Dock = DockStyle.Fill;

            pnlGunEkran.Controls.Add(gunForm);
            gunForm.Show();

            pnlAnaEkran.Visible = false;
            pnlGunEkran.Visible = true;
        }

        private void btnPazartesi_Click(object sender, EventArgs e)
        {
            GunAc("Pazartesi");
        }

        private void btnSali_Click(object sender, EventArgs e)
        {
            GunAc("Salı");
        }

        private void btnCarsamba_Click(object sender, EventArgs e)
        {
            GunAc("Çarşamba");
        }

        private void btnPersembe_Click(object sender, EventArgs e)
        {
            GunAc("Perşembe");
        }

        private void btnCuma_Click(object sender, EventArgs e)
        {
            GunAc("Cuma");
        }

        private void btnCumartesi_Click(object sender, EventArgs e)
        {
            GunAc("Cumartesi");
        }

        private void btnPazar_Click(object sender, EventArgs e)
        {
            GunAc("Pazar");
        }

        public void GorevSayisiniGuncelle(string gunAdi)
        {
            int sayi = 0;
            if (Gorevler.ContainsKey(gunAdi))
                sayi = Gorevler[gunAdi].Count;

            string text = sayi + " görev";

            switch (gunAdi)
            {
                case "Pazartesi":
                    btnPazartesiSayisi.Text = text;
                    break;
                case "Salı":
                    btnSaliSayisi.Text = text;
                    break;
                case "Çarşamba":
                    btnCarsambaSayisi.Text = text;
                    break;
                case "Perşembe":
                    btnPersembeSayisi.Text = text;
                    break;
                case "Cuma":
                    btnCumaSayisi.Text = text;
                    break;
                case "Cumartesi":
                    btnCumartesiSayisi.Text = text;
                    break;
                case "Pazar":
                    btnPazarSayisi.Text = text;
                    break;
            }
        }
    }
}
