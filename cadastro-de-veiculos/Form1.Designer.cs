namespace cadastro_de_veiculos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            novoCadastroToolStripMenuItem = new ToolStripMenuItem();
            visualizarCadastrosToolStripMenuItem = new ToolStripMenuItem();
            excluirCadastrosToolStripMenuItem = new ToolStripMenuItem();
            menuToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoCadastroToolStripMenuItem, visualizarCadastrosToolStripMenuItem, excluirCadastrosToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(82, 24);
            cadastroToolStripMenuItem.Text = "&Cadastro";
            // 
            // novoCadastroToolStripMenuItem
            // 
            novoCadastroToolStripMenuItem.Name = "novoCadastroToolStripMenuItem";
            novoCadastroToolStripMenuItem.Size = new Size(224, 26);
            novoCadastroToolStripMenuItem.Text = "&Novo veículo";
            novoCadastroToolStripMenuItem.Click += novoCadastroToolStripMenuItem_Click;
            // 
            // visualizarCadastrosToolStripMenuItem
            // 
            visualizarCadastrosToolStripMenuItem.Name = "visualizarCadastrosToolStripMenuItem";
            visualizarCadastrosToolStripMenuItem.Size = new Size(224, 26);
            visualizarCadastrosToolStripMenuItem.Text = "&Visualizar cadastros";
            // 
            // excluirCadastrosToolStripMenuItem
            // 
            excluirCadastrosToolStripMenuItem.Name = "excluirCadastrosToolStripMenuItem";
            excluirCadastrosToolStripMenuItem.Size = new Size(224, 26);
            excluirCadastrosToolStripMenuItem.Text = "E&xcluir cadastros";
            excluirCadastrosToolStripMenuItem.Click += excluirCadastrosToolStripMenuItem_Click;
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "&Menu";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(224, 26);
            sairToolStripMenuItem.Text = "&Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Cadastro de veículos";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem novoCadastroToolStripMenuItem;
        private ToolStripMenuItem visualizarCadastrosToolStripMenuItem;
        private ToolStripMenuItem excluirCadastrosToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}