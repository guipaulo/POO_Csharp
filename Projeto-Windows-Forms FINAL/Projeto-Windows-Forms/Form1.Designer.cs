namespace Projeto_Windows_Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            MenuCadastros = new ToolStripMenuItem();
            CadastroProfessores = new ToolStripMenuItem();
            ListagemProfessores = new ToolStripMenuItem();
            listaDeProfessoresToolStripMenuItem = new ToolStripMenuItem();
            BotaoSair = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuCadastros, ListagemProfessores, BotaoSair });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuCadastros
            // 
            MenuCadastros.DropDownItems.AddRange(new ToolStripItem[] { CadastroProfessores });
            MenuCadastros.Name = "MenuCadastros";
            MenuCadastros.Size = new Size(66, 20);
            MenuCadastros.Text = "Cadastro";
            // 
            // CadastroProfessores
            // 
            CadastroProfessores.Name = "CadastroProfessores";
            CadastroProfessores.Size = new Size(176, 22);
            CadastroProfessores.Text = "Cadastrar Professor";
            CadastroProfessores.Click += CadastroProfessores_Click;
            // 
            // ListagemProfessores
            // 
            ListagemProfessores.DropDownItems.AddRange(new ToolStripItem[] { listaDeProfessoresToolStripMenuItem });
            ListagemProfessores.Name = "ListagemProfessores";
            ListagemProfessores.Size = new Size(67, 20);
            ListagemProfessores.Text = "Listagem";
            // 
            // listaDeProfessoresToolStripMenuItem
            // 
            listaDeProfessoresToolStripMenuItem.Name = "listaDeProfessoresToolStripMenuItem";
            listaDeProfessoresToolStripMenuItem.Size = new Size(177, 22);
            listaDeProfessoresToolStripMenuItem.Text = "Lista de Professores";
            listaDeProfessoresToolStripMenuItem.Click += listaDeProfessoresToolStripMenuItem_Click;
            // 
            // BotaoSair
            // 
            BotaoSair.Name = "BotaoSair";
            BotaoSair.Size = new Size(38, 20);
            BotaoSair.Text = "Sair";
            BotaoSair.Click += BotaoSair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Cadastro de Professores";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuCadastros;
        private ToolStripMenuItem CadastroProfessores;
        private ToolStripMenuItem ListagemProfessores;
        private ToolStripMenuItem BotaoSair;
        private ToolStripMenuItem listaDeProfessoresToolStripMenuItem;
    }
}
