
using System;
using System.Media;
using System.Windows.Forms;



namespace Urna
{
    public partial class FIM : Form
    {
        private Dictionary<string, Candidato> _dicCandidato;


        public FIM()
        {
            InitializeComponent();
            _dicCandidato = new Dictionary<string, Candidato>();
            _dicCandidato.Add("13", new Candidato() { Id = 13, Nome = "Pica-pau Maluco", Partido = "Hehehe", Foto = Properties.Resources.Pica_Pau_Maluco });
            _dicCandidato.Add("17", new Candidato() { Id = 17, Nome = "Scooby-doo", Partido = "Misterio", Foto = Properties.Resources.Scooby });
            _dicCandidato.Add("22", new Candidato() { Id = 22, Nome = "Perna Longa", Partido = "Velhinho", Foto = Properties.Resources.Perna_longa });
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistrarDigito("3");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            RegistrarDigito("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            RegistrarDigito("2");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            RegistrarDigito("4");
        }

        private void bnt5_Click(object sender, EventArgs e)
        {
            RegistrarDigito("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            RegistrarDigito("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            RegistrarDigito("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            RegistrarDigito("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            RegistrarDigito("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            RegistrarDigito("0");
        }
        private void RegistrarDigito(string digito)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                textBox1.Text = digito;
            else
            {
                textBox2.Text = digito;
                PreencherCamposCandidato(textBox1.Text, textBox2.Text);
            }
        }

        private void PreencherCamposCandidato(string d1, string d2)
        {


            if (_dicCandidato.ContainsKey(d1 + d2))
            {
                nome_aparente.Text = _dicCandidato[d1 + d2].Nome;
                Partido_Aparecer.Text = _dicCandidato[d1 + d2].Partido;
                pictureBox3.Image = _dicCandidato[d1 + d2].Foto;
            }
            else
            {
                MessageBox.Show("Candidato não encontrado!");
            }
        }

        private void bnt_confirma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Favor informar o candidato.");
                return;
            }

            panel1.Visible = true;
            limparCampos();

            relogio.Tick += new EventHandler(AcaoFinal);
            relogio.Interval = 3000;
            relogio.Enabled = true;
            relogio.Start();
        }

        private void Btn_Corrige_Click(object sender, EventArgs e)
        {
            limparCampos();
            relogio.Stop();
            relogio.Enabled = false;
        }

        private void AcaoFinal(Object myObject, EventArgs myEventArgs)
        {
            relogio.Stop();
            relogio.Enabled = false;
            panel1.Visible = false;
        }


        private void limparCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            nome_aparente.Text = "";
            Partido_Aparecer.Text = "";
            pictureBox3.Image = null;
        }

        private void Btn_Branco_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            limparCampos();

            

            relogio.Tick += new EventHandler(AcaoFinal);
            relogio.Interval = 1500;
            relogio.Enabled = true;
            relogio.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void nome_aparente_Click(object sender, EventArgs e)
        {

        }

        private void Partido_Aparecer_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Presidente_Click(object sender, EventArgs e)
        {

        }
        public class Candidato
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Partido { get; set; }
            public Image Foto { get; set; }
        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void relogio_Tick(object sender, EventArgs e)
        {

        }
    }
}
