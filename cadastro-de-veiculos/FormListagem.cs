using System;
using System.Collections.Generic;
using System.Windows.Forms;
using cadastro_de_veiculos.Models;
using cadastro_de_veiculos.Persistencia;

namespace cadastro_de_veiculos
{
    public partial class FormListagem : Form
    {
        private readonly VeiculoRepositorio _repositorio;

        public FormListagem()
        {
            InitializeComponent();
            _repositorio = new VeiculoRepositorio();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            dgvVeiculos.AutoGenerateColumns = false;
            dgvVeiculos.Columns.Clear();

            dgvVeiculos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Veiculo.Placa),
                HeaderText = "Placa",
                Width = 100
            });

            dgvVeiculos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Veiculo.Marca),
                HeaderText = "Marca",
                Width = 120
            });

            dgvVeiculos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Veiculo.Modelo),
                HeaderText = "Modelo",
                Width = 130
            });

            dgvVeiculos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Veiculo.AnoFabricacao),
                HeaderText = "Ano",
                Width = 70
            });

            dgvVeiculos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Veiculo.Cor),
                HeaderText = "Cor",
                Width = 90
            });

            var colPreco = new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Veiculo.Preco),
                HeaderText = "Preço",
                Width = 110
            };
            colPreco.DefaultCellStyle.Format = "C2";
            dgvVeiculos.Columns.Add(colPreco);

            dgvVeiculos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Veiculo.TipoCombustivel),
                HeaderText = "Combustível",
                Width = 110
            });
        }

        public void CarregarVeiculos()
        {
            try
            {
                List<Veiculo> veiculos = _repositorio.CarregarDados();
                dgvVeiculos.DataSource = null;
                dgvVeiculos.DataSource = veiculos;
                lbTotal.Text = $"Total de veículos: {veiculos.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro ao carregar veículos: {ex.Message}",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void FormListagem_Load(object sender, EventArgs e)
        {
            CarregarVeiculos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarVeiculos();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

