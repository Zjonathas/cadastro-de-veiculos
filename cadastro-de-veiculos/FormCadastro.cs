using cadastro_de_veiculos.Models;
using cadastro_de_veiculos.Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cadastro_de_veiculos
{
    public partial class FormCadastro : Form
    {
        private static readonly CultureInfo CulturaBrasil = CultureInfo.GetCultureInfo("pt-BR");
        private readonly VeiculoRepositorio _repositorio = new();

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

        private void LimparCamposDetalhes()
        {
            txtAnoFab.Text = string.Empty;
            txtCor.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtPreco.Text = string.Empty;
            cbTipoComb.SelectedIndex = -1;
            cbTipoComb.Text = string.Empty;
        }

        public void LimparForm()
        {
            txtPlaca.Text = string.Empty;
            LimparCamposDetalhes();
        }

        private static string NormalizarPlaca(string? placa) =>
            placa?.Trim().Replace("-", string.Empty).ToUpperInvariant() ?? string.Empty;

        private static Veiculo? LocalizarVeiculoPorPlaca(IEnumerable<Veiculo> veiculos, string placaBusca)
        {
            var veiculo = veiculos.FirstOrDefault(v =>
                string.Equals(v.Placa?.Trim(), placaBusca, StringComparison.OrdinalIgnoreCase));
            if (veiculo is not null)
            {
                return veiculo;
            }

            var placaNormalizada = NormalizarPlaca(placaBusca);
            if (string.IsNullOrEmpty(placaNormalizada))
            {
                return null;
            }

            return veiculos.FirstOrDefault(v =>
                NormalizarPlaca(v.Placa) == placaNormalizada);
        }

        private void PreencherCampos(Veiculo veiculo)
        {
            txtPlaca.Text = veiculo.Placa ?? string.Empty;
            txtMarca.Text = veiculo.Marca ?? string.Empty;
            txtModelo.Text = veiculo.Modelo ?? string.Empty;
            txtAnoFab.Text = veiculo.AnoFabricacao.ToString();
            txtCor.Text = veiculo.Cor ?? string.Empty;
            txtPreco.Text = veiculo.Preco.ToString("F2", CulturaBrasil);

            var tipoCombustivel = veiculo.TipoCombustivel ?? string.Empty;
            int indiceCombustivel = cbTipoComb.FindStringExact(tipoCombustivel);
            if (indiceCombustivel >= 0)
            {
                cbTipoComb.SelectedIndex = indiceCombustivel;
            }
            else
            {
                cbTipoComb.SelectedIndex = -1;
                cbTipoComb.Text = tipoCombustivel;
            }
        }

        private bool TryObterPlacaInformada(string titulo, string mensagemVazia, out string placaBusca)
        {
            placaBusca = txtPlaca.Text.Trim();
            if (!string.IsNullOrWhiteSpace(placaBusca))
            {
                return true;
            }

            MessageBox.Show(mensagemVazia, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtPlaca.Focus();
            return false;
        }

        private void ExibirAvisoVeiculoNaoEncontrado(string titulo)
        {
            MessageBox.Show(
                "Nenhum veículo encontrado com a placa informada.",
                titulo,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            txtPlaca.Focus();
            txtPlaca.SelectAll();
        }

        /// <summary>
        /// Busca um veículo cadastrado pela placa informada e preenche os campos do formulário.
        /// </summary>
        public void BuscarVeiculo()
        {
            const string titulo = "Busca de Veículo";
            if (!TryObterPlacaInformada(titulo, "Informe a placa do veículo para buscar.", out var placaBusca))
            {
                return;
            }

            try
            {
                var listaVeiculos = _repositorio.CarregarDados();
                var veiculoEncontrado = LocalizarVeiculoPorPlaca(listaVeiculos, placaBusca);

                if (veiculoEncontrado is null)
                {
                    LimparCamposDetalhes();
                    ExibirAvisoVeiculoNaoEncontrado(titulo);
                    return;
                }

                PreencherCampos(veiculoEncontrado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro ao buscar os dados do veículo:\n{ex.Message}",
                    "Falha na Busca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarVeiculo();
        }

        /// <summary>
        /// Exclui o veículo correspondente à placa informada após confirmação do usuário.
        /// </summary>
        public void ExcluirVeiculo()
        {
            const string titulo = "Exclusão de Veículo";
            if (!TryObterPlacaInformada(titulo, "Informe a placa do veículo para excluir.", out var placaBusca))
            {
                return;
            }

            try
            {
                var listaVeiculos = _repositorio.CarregarDados();
                var veiculoEncontrado = LocalizarVeiculoPorPlaca(listaVeiculos, placaBusca);

                if (veiculoEncontrado is null)
                {
                    ExibirAvisoVeiculoNaoEncontrado(titulo);
                    return;
                }

                var confirmacao = MessageBox.Show(
                    $"Deseja realmente excluir o veículo {veiculoEncontrado}?",
                    "Confirmar Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacao != DialogResult.Yes)
                {
                    return;
                }

                listaVeiculos.Remove(veiculoEncontrado);
                _repositorio.SalvarDados(listaVeiculos);
                LimparForm();

                MessageBox.Show(
                    "Veículo excluído com sucesso!",
                    titulo,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtPlaca.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro ao excluir o veículo:\n{ex.Message}",
                    "Falha na Exclusão",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirVeiculo();
        }

        private void btnLimparForm_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private static bool TryConverterPreco(string texto, out decimal preco)
        {
            var valor = texto.Trim();
            if (!valor.Contains(',')
                && valor.Count(c => c == '.') == 1
                && valor.Split('.')[1].Length <= 2)
            {
                return decimal.TryParse(valor, NumberStyles.Number, CultureInfo.InvariantCulture, out preco);
            }

            return decimal.TryParse(valor, NumberStyles.Number, CulturaBrasil, out preco);
        }

        private bool ValidarCamposCadastro(out int anoFabricacao, out decimal preco)
        {
            anoFabricacao = 0;
            preco = 0;

            (Control Campo, string Nome)[] camposObrigatorios =
            [
                (txtPlaca, "Placa"),
                (txtMarca, "Marca"),
                (txtCor, "Cor"),
                (cbTipoComb, "Tipo de combustível"),
                (txtModelo, "Modelo"),
                (txtAnoFab, "Ano de fabricação"),
                (txtPreco, "Preço")
            ];

            foreach (var (campo, nome) in camposObrigatorios)
            {
                if (string.IsNullOrWhiteSpace(campo.Text))
                {
                    MessageBox.Show(
                        $"O campo \"{nome}\" é obrigatório.",
                        "Cadastro de Veículo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    campo.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(NormalizarPlaca(txtPlaca.Text)))
            {
                MessageBox.Show(
                    "Informe uma placa válida.",
                    "Cadastro de Veículo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtPlaca.Focus();
                txtPlaca.SelectAll();
                return false;
            }

            int anoMaximo = DateTime.Now.Year + 1;
            if (!int.TryParse(txtAnoFab.Text.Trim(), NumberStyles.Integer, CulturaBrasil, out anoFabricacao)
                || anoFabricacao < 1886
                || anoFabricacao > anoMaximo)
            {
                MessageBox.Show(
                    $"Informe um ano de fabricação válido (entre 1886 e {anoMaximo}).",
                    "Cadastro de Veículo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtAnoFab.Focus();
                txtAnoFab.SelectAll();
                return false;
            }

            if (!TryConverterPreco(txtPreco.Text, out preco) || preco <= 0)
            {
                MessageBox.Show(
                    "Informe um preço válido maior que zero.",
                    "Cadastro de Veículo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtPreco.Focus();
                txtPreco.SelectAll();
                return false;
            }

            return true;
        }

        public void CadastrarVeiculos()
        {
            if (!ValidarCamposCadastro(out int anoFabricacao, out decimal preco))
            {
                return;
            }

            try
            {
                var listaVeiculos = _repositorio.CarregarDados();
                var placa = txtPlaca.Text.Trim().ToUpperInvariant();

                if (LocalizarVeiculoPorPlaca(listaVeiculos, placa) is not null)
                {
                    MessageBox.Show(
                        "Já existe um veículo cadastrado com a placa informada.",
                        "Cadastro de Veículo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtPlaca.Focus();
                    txtPlaca.SelectAll();
                    return;
                }

                var veiculo = new Veiculo(
                    placa,
                    txtMarca.Text,
                    txtModelo.Text,
                    anoFabricacao,
                    txtCor.Text,
                    preco,
                    cbTipoComb.Text.Trim());

                listaVeiculos.Add(veiculo);
                _repositorio.SalvarDados(listaVeiculos);
                LimparForm();

                MessageBox.Show(
                    "Veículo cadastrado com sucesso!",
                    "Cadastro de Veículo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtPlaca.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro ao cadastrar o veículo:\n{ex.Message}",
                    "Falha no Cadastro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCadastraVeiculo_Click(object sender, EventArgs e)
        {
            CadastrarVeiculos();
        }
    }
}
