using System;
using System.Windows.Forms;

namespace HaftalikAjanda
{
    public partial class GorevEkleForm : Form
    {
        public string GirilenGorev { get; private set; }

        public GorevEkleForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGorev.Text))
            {
                MessageBox.Show("Görev boş olamaz!");
                return;
            }

            GirilenGorev = txtGorev.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
