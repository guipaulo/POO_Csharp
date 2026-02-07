using System;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_Windows_Forms
{
    // Classe Cadastro que herda de Form;
    public partial class Cadastro : Form
    {
        // Construtor da classe Cadastro;
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click_1(object sender, EventArgs e) 
        { 
        
        }

        private void label2_Click(object sender, EventArgs e) 
        { 
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // button1_Click é o Botão de CADASTRAR;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Declara onde está a matricula para verificar se ela já existe;
                string matricula = textBox1.Text.Trim();

                // Booleano que retorna TRUE se matricula já existe;
                bool jaExiste = Listagem.Professores
                    .Any(p => p.Matricula == matricula);

                // Booleano que retorna TRUE se existe campo vazio na hora do cadastro
                bool campoVazio = string.IsNullOrWhiteSpace(textBox1.Text) 
                    || string.IsNullOrWhiteSpace(textBox2.Text) 
                    || string.IsNullOrWhiteSpace(textBox3.Text);

                // Verifica se jaExiste é TRUE e dispara a exceção ErroJaExisteMatricula;
                if (jaExiste)
                {
                    throw new ErroJaExisteMatricula(
                        "Já existe um professor com essa matrícula"
                    );
                }

                // Se não existe matricula, Verifica se campoVazio é TRUE e dispara a exceção ErroCampoVazio;
                else if (campoVazio)
                {
                    throw new ErroCampoVazio(
                        "Existem campos vazios. Preencha todos os campos!"
                    );
                }
                else
                {
                    // Se não disparar as excessões, ele cria um prof new Professor e cadastra a matricula,
                    // nome e campus;
                    // Trim() remove espaços em branco;
                    Professor prof = new Professor
                    {
                        Matricula = matricula,
                        Nome = textBox2.Text.Trim(),
                        Campus = textBox3.Text.Trim()
                    };
                    // Esse prof criado vai para a Listagem.Professores
                    // que é a lista global que guarda todos os professores;
                    // Por fim, chama o método SalvarJson da Listagem para guardar no arquivo json;
                    Listagem.Professores.Add(prof);
                    Listagem.SalvarJson();

                    // Mensagem para informar se o registro foi salvo;
                    MessageBox.Show("Registro salvo com sucesso!");
                }
            }
            // Catch do erro de já existir uma matricula. Mostra uma MensageBox do WindowsForms;
            catch (ErroJaExisteMatricula erroMatricula)
            {
                MessageBox.Show(
                    erroMatricula.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            // Catch do erro de existir um campo vazio. Mostra uma MensageBox do WindowsForms;
            catch (ErroCampoVazio erroVazio)
            {
                MessageBox.Show(
                    erroVazio.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        // button2_Click é o Botão de EXCLUIR;
        private void button2_Click(object sender, EventArgs e)
        {
            //
            try
            {   // Booleano que retorna TRUE se matricula está vazia na hora de excluir;
                bool CampoMatriculaVazia = string.IsNullOrWhiteSpace(textBox1.Text);

                // Verifica se CampoMatriculaVazia é TRUE e dispara a exceção ErroCampoVazio;
                if (CampoMatriculaVazia)
                {
                    throw new ErroCampoVazio(
                        "Informe a matrícula para excluir."
                    );
                }

                // Declara onde está a matricula para verificar se ela está na Listagem.Professores;
                string matricula = textBox1.Text.Trim();

                // Ele busca na lista se a matricula existe (a primeira ocorrência);
                var professor = Listagem.Professores
                    .FirstOrDefault(p => p.Matricula == matricula);

                // Se não encontra, ele dispara a exceção ErroNaoExisteProfessor;
                if (professor == null)
                {
                    throw new ErroNaoExisteProfessor(
                        "Não existe professor com essa matrícula"
                    );
                }

                // Se encontra, ele remove o professor da Listagem de Professores e salva no Json;
                Listagem.Professores.Remove(professor);
                Listagem.SalvarJson();

                MessageBox.Show("Registro excluído com sucesso!");
            }

            // Catch do erro de existir um campo vazio (matricula). Mostra uma MensageBox do WindowsForms;
            catch (ErroCampoVazio erroVazio)
            {
                MessageBox.Show(
                    erroVazio.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            // Catch do erro de não existir o professor com a matricula informada. Mostra uma MensageBox do WindowsForms;
            catch (ErroNaoExisteProfessor erroProfessor)
            {
                MessageBox.Show(
                    erroProfessor.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
