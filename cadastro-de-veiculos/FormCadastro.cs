using cadastro_de_veiculos.Models;
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
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimparForm_Click(object sender, EventArgs e)
        {
            txtPlaca.Text = string.Empty;
            txtAnoFab.Text = string.Empty;
            txtCor.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtPreco.Text = string.Empty;
            cbTipoComb.Text = string.Empty;
        }

        public void CadastrarVeiculos()
        {
            var arquivo = new VeiculoRepositorio();
            var listaVeiculos = arquivo.CarregarDados();
            var veiculo = new Veiculo
            {
                Cor = txtCor.Text.Trim(),
                AnoFabricacao = Convert.ToInt32(txtAnoFab.Text),
                Marca = txtMarca.Text.Trim(),
                Modelo = txtModelo.Text.Trim(),
                Placa = txtPlaca.Text.Trim(),
                Preco = Convert.ToDecimal(txtPreco.Text),
                TipoCombustivel = cbTipoComb.Text
            };

            listaVeiculos.Add(veiculo);
            arquivo.SalvarDados(listaVeiculos);

            MessageBox.Show("Veículo cadastrado com sucesso!");

        }

        private void btnCadastraVeiculo_Click(object sender, EventArgs e)
        {
            CadastrarVeiculos();
        }
    }
}
