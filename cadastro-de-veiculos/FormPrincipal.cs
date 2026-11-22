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

        public void AbrirListagem()
        {
            foreach (Form child in MdiChildren)
            {
                if (child is FormListagem formAberto)
                {
                    formAberto.CarregarVeiculos();
                    formAberto.BringToFront();
                    formAberto.Focus();
                    return;
                }
            }

            var form = new FormListagem();
            form.MdiParent = this;
            form.Show();
        }

        private void visualizarCadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirListagem();
        }

        private void excluirCadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirCadastro();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
