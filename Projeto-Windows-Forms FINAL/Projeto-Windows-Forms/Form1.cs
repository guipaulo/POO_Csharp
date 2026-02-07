using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Projeto_Windows_Forms
{
    public partial class Form1 : Form
    {
        // Constutor do formulário;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void CadastroProfessores_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário Cadastro;
            // Transforma Cadastro em filho MDI;
            // Manda o formulário aparecer
            Cadastro cadastro = new Cadastro();
            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void listaDeProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário Listagem;
            // Transforma Listagem em filho MDI;
            // Manda o formulário aparecer
            Listagem listagem = new Listagem();
            listagem.MdiParent = this;
            listagem.Show();
        }

        private void BotaoSair_Click(object sender, EventArgs e)
        {
            // Cria o botão "Sair" para sair do programa;
            if (MessageBox.Show("Deseja sair?",
                "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}