using System;
using System.ComponentModel;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Projeto_Windows_Forms
{
    // Classe Listagem que herda de Form;
    public partial class Listagem : Form
    {
        // Lista Global onde será guardada os professores;
        public static BindingList<Professor> Professores =
            new BindingList<Professor>();
        // Esse trecho define onde o JSON será salvo;
        static string caminhoArquivo =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "professores.json"
            );
        // Construtor da classe Listagem;
        public Listagem()
        {
            //inicializa o formulario listagem
            InitializeComponent();
            // Carrega o Json para mostrar no GridView;
            CarregarJson();
            // Cria automaticamente as colunas com os dados que forem informados;
            dataGridView2.AutoGenerateColumns = true;
            // Mostra os dados da lista professores no GridView;
            dataGridView2.DataSource = Professores;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // Metodo de carregar o Json
        private static void CarregarJson()
        {
            // Se o arquivo JSON ainda não existe, saia do método e não faça nada;
            if (!File.Exists(caminhoArquivo))
            {
                return;
            }
            
            // lê todo o conteúdo do arquivo JSON
            // para depois converter em objetos C#;
            string json = File.ReadAllText(caminhoArquivo);

            // Desserializa o arquivo "professores.json",
            // Transforma em objetos Professor e coloca numa lista;
            // BindingList<Professor> notifica DataGridView;
            // lista é do tipo BindingList<Professor>;
            var lista = JsonSerializer.Deserialize<BindingList<Professor>>(json);

            // Se lista for diferente de null, a desserialização deu certo
            // A lista (que veio do Json) vai para a Lista Global de Professores
            if (lista != null)
            {
                Professores = lista;
            }
        }

        // Metodo de salvar o Json
        public static void SalvarJson()
        {
            // Serialização da lista Professores em arquivo JSON;
            // "json" é uma string que guarda o conteúdo que vai para o arquivo 
            string json = JsonSerializer.Serialize(
                Professores,
                // Opção de quebrar linhas dentro do arquivo JSON
                new JsonSerializerOptions { WriteIndented = true } //determina a estrutura do arquivo
            );
            // Grava o texto JSON no disco no caminho escolhido (caminhoArquivo);
            // Cria o arquivo se não existir;
            File.WriteAllText(caminhoArquivo, json);
        }
    }
}