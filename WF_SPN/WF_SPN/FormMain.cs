using Model;
using System.Text.RegularExpressions;

namespace WF_SPN
{
    public partial class FormMain : Form
    {
        private Data data;

        public FormMain()
        {
            this.data = new Data();
            InitializeComponent();
            this.dgvPBox.DataSource = data.ViewPBox();
            this.dgvSBox.DataSource = data.ViewSBox();
        }

        private void btCifra_Click(object sender, EventArgs e)
        {
            if ((Regex.IsMatch(this.tbTestoInChiaro.Text, "^[01]+$") && this.tbTestoInChiaro.Text.Length == 12) &&
                (Regex.IsMatch(this.tbChiave1.Text, "^[01]+$") && this.tbChiave1.Text.Length == 12) &&
                (Regex.IsMatch(this.tbChiave2.Text, "^[01]+$") && this.tbChiave2.Text.Length == 12))
            {
                this.tbRisCifrazione.Text = data.Cyfer.Cipher(this.tbTestoInChiaro.Text, this.tbChiave1.Text, this.tbChiave2.Text);
            }
            else
            {
                MessageBox.Show("Campi non inseriti correttamente!", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btDefault_Click(object sender, EventArgs e)
        {
            this.tbTestoInChiaro.Text = "001110101001";
            this.tbChiave1.Text = "011111000010";
            this.tbChiave2.Text = "111111111111";
        }

        private void btDecifra_Click(object sender, EventArgs e)
        {
            if ((Regex.IsMatch(this.tbRisCifrazione.Text, "^[01]+$") && this.tbRisCifrazione.Text.Length == 12) &&
                (Regex.IsMatch(this.tbChiave1.Text, "^[01]+$") && this.tbChiave1.Text.Length == 12) &&
                (Regex.IsMatch(this.tbChiave2.Text, "^[01]+$") && this.tbChiave2.Text.Length == 12))
            {
                this.tbRisDecifrazione.Text = data.Cyfer.DeCipher(this.tbRisCifrazione.Text, this.tbChiave1.Text, this.tbChiave2.Text);
            }
            else
            {
                MessageBox.Show("Campi non inseriti correttamente!", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btPulisci_Click(object sender, EventArgs e)
        {
            this.tbTestoInChiaro.Text = "";
            this.tbChiave1.Text = "";
            this.tbChiave2.Text = "";
            this.tbRisCifrazione.Text = "";
            this.tbRisDecifrazione.Text = "";
        }
    }
}