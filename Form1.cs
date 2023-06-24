using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Cadastro
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas;
        public Form1()
        {
            InitializeComponent();
            pessoas = new List<Pessoa>();
            comboEc.Items.Add("Casado(a)");
            comboEc.Items.Add("Solteiro(a)");
            comboEc.Items.Add("Viuvo(a)");
            comboEc.Items.Add("Separado(a)");

            comboEc.SelectedIndex = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboEc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int index  = -1;

            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa.Nome == textNome.Text)
                {
                    index = pessoas.IndexOf(pessoa);
                }
            }
            if (textNome.Text == "")
            {
                MessageBox.Show("Preencha o campo nome!");
                textNome.Focus();
                return;
            }
            if (txtTelefone.Text == "(  )      -")
            {
                MessageBox.Show("Preencha o campo telefone!");
                txtTelefone.Focus();
                return;
            }

            char sexo;

            if (radioM.Checked)
            {
                sexo = 'M';
            }

            else if (radioF.Checked)
            {
                sexo = 'F';
            }

            else
            {
                sexo = 'O';
            }

            Pessoa P = new Pessoa();
            P.Nome = textNome.Text;
            P.Datanascimento = txtData.Text;
            P.EstadoCivil = comboEc.SelectedItem.ToString();
            P.Telefone = txtTelefone.Text;
            P.CasaPropria = checkCasa.Checked;
            P.veiculo = checVeiculo.Checked;
            P.Sexo = sexo;

            if (index < 0)
            {
                pessoas.Add(P);
            }
            else
            {
                pessoas[index] = P;
            }

            btnLimpar_Click(btnLimpar, EventArgs.Empty);
            Listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int idice = Lista.SelectedIndex;
            pessoas.RemoveAt(idice);
            Listar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textNome.Text = "";
            txtData.Text = "";
            comboEc.SelectedIndex = 1;
            txtTelefone.Text = "";
            checkCasa.Checked = false;
            checVeiculo.Checked = false;
            radioM.Checked = true;
            radioF.Checked = false;
            radioO.Checked = false;
            textNome.Focus();
        }

        private void Listar()
        {
            Lista.Items.Clear();

            foreach (Pessoa adicionar in pessoas)
            {
                Lista.Items.Add(adicionar.Nome);
            }
        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indice = Lista.SelectedIndex;
            Pessoa p = pessoas[indice];

            txtData.Text = p.Datanascimento;
            textNome.Text = p.Nome;
            comboEc.SelectedItem = p.EstadoCivil;
            txtTelefone.Text = p.Telefone;
            checkCasa.Checked = p.CasaPropria;
            checVeiculo.Checked = p.veiculo;

            switch (p.Sexo)
            {
                case 'M':
                    radioF.Checked = true;
                    break;
                case 'F':
                    radioF.Checked = true;
                    break;
                default: 
                    radioO.Checked = true;
                    break;
            }
        }
    }
}
