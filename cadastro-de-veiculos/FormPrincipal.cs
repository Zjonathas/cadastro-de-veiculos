using cadastro_de_veiculos.Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cadastro_de_veiculos
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        public void AbrirCadastro()
        {
            var form = new FormCadastro();
            form.MdiParent = this;
            form.Show();
        }

        private void excluirCadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirCadastro();
            txtVisuCadastro.Visible = false;
            lbVisuVeiculos.Visible = false;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Saindo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void visualizarCadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtVisuCadastro.Visible = true;
            lbVisuVeiculos.Visible = true;
            txtVisuCadastro.Text = "Visualização";
        }

        private void txtVisuCadastro_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
