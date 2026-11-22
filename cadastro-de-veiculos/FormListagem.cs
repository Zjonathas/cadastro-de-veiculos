using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using cadastro_de_veiculos.Models;
using cadastro_de_veiculos.Persistencia;

namespace cadastro_de_veiculos
{
    public partial class FormListagem : Form
    {
        private readonly VeiculoRepositorio _repositorio;
        private static readonly CultureInfo CulturaBrasil = CultureInfo.GetCultureInfo("pt-BR");

        public FormListagem()
        {
            InitializeComponent();
            _repositorio = new VeiculoRepositorio();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            dgvVeiculos.ReadOnly = true;
            dgvVeiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVeiculos.MultiSelect = false;
            dgvVeiculos.AllowUserToAddRows = false;
            dgvVeiculos.AllowUserToDeleteRows = false;
            dgvVeiculos.AutoGenerateColumns = false;
            dgvVeiculos.Columns.Clear();

            // Configuração visual dos cabeçalhos
            dgvVeiculos.EnableHeadersVisualStyles = false;
            dgvVeiculos.ColumnHeadersHeight = 35;
            dgvVeiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVeiculos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvVeiculos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvVeiculos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvVeiculos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Coluna Placa
            var colPlaca = new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Veiculo.Placa),
                HeaderText = "Placa",
                Width = 110
            };
            colPlaca.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colPlaca.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVeiculos.Columns.Add(colPlaca);

            // Coluna Marca
            dgvVeiculos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Veiculo.Marca),
                HeaderText = "Marca",
                Width = 120
            });

            // Coluna Modelo
            dgvVeiculos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Veiculo.Modelo),
                HeaderText = "Modelo",
                Width = 130
            });

            // Coluna Ano de Fabricação
            var colAno = new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Veiculo.AnoFabricacao),
                HeaderText = "Ano Fab.",
                Width = 90
            };
            colAno.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colAno.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVeiculos.Columns.Add(colAno);

            // Coluna Cor
            dgvVeiculos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Veiculo.Cor),
                HeaderText = "Cor",
                Width = 100
            });

            // Coluna Preço formatada como moeda (R$ 0,00)
            var colPreco = new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Veiculo.Preco),
                HeaderText = "Preço",
                Width = 120
            };
            colPreco.DefaultCellStyle.Format = "C2";
            colPreco.DefaultCellStyle.FormatProvider = CulturaBrasil;
            colPreco.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colPreco.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvVeiculos.Columns.Add(colPreco);

            // Coluna Tipo de Combustível
            dgvVeiculos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Veiculo.TipoCombustivel),
                HeaderText = "Combustível",
                Width = 120
            });
        }

        public void CarregarVeiculos()
        {
            try
            {
                List<Veiculo> veiculos = _repositorio.CarregarDados();
                dgvVeiculos.DataSource = null;
                dgvVeiculos.DataSource = veiculos;

                if (veiculos.Count == 0)
                {
                    lbTotal.Text = "Nenhum veículo cadastrado no momento.";
                }
                else
                {
                    lbTotal.Text = $"Total de veículos cadastrados: {veiculos.Count}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro ao carregar os dados dos veículos do disco:\n{ex.Message}",
                    "Falha no Carregamento",
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

