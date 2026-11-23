//<<<<<<< HEAD
﻿using cadastro_de_veiculos.Persistencia;
//=======
//>>>>>>> b71b822cfa4e085a4d227292ae4721a62a910c3
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


        private void excluirCadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirCadastro();
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
            AbrirListagem();
        }

        private void txtVisuCadastro_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
