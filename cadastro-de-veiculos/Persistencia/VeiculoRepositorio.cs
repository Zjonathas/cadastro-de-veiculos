using System.Text.Json;
using cadastro_de_veiculos.Models;

namespace cadastro_de_veiculos.Persistencia
{
    public class VeiculoRepositorio
    {
        private const string NomeArquivo = "veiculos.json";

        private static readonly JsonSerializerOptions OpcoesJson = new()
        {
            PropertyNameCaseInsensitive = true
        };

        public string CaminhoArquivoPadrao =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, NomeArquivo);

        public void SalvarDados(List<Veiculo> veiculos)
        {
            ArgumentNullException.ThrowIfNull(veiculos);

            var opcoes = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var conteudo = JsonSerializer.Serialize(veiculos, opcoes);
            File.WriteAllText(CaminhoArquivoPadrao, conteudo);
        }

        public List<Veiculo> CarregarDados()
        {
            return CarregarDados(CaminhoArquivoPadrao);
        }

        public List<Veiculo> CarregarDados(string caminhoArquivo)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(caminhoArquivo);

            if (!File.Exists(caminhoArquivo))
            {
                return new List<Veiculo>();
            }

            var conteudo = File.ReadAllText(caminhoArquivo);

            if (string.IsNullOrWhiteSpace(conteudo))
            {
                return new List<Veiculo>();
            }

            return JsonSerializer.Deserialize<List<Veiculo>>(conteudo, OpcoesJson)
                ?? new List<Veiculo>();
        }
    }
}
