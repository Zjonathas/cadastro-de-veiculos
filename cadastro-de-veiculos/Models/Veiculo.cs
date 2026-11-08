using System;

namespace cadastro_de_veiculos.Models
{
    [Serializable]
    public class Veiculo
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public string Cor {  get; set; }
        public decimal Preco { get; set; }
        public string TipoCombustivel { get; set; }

        public Veiculo()
        {

        }

        public Veiculo(string placa, string marca, string modelo, int anoFabricacao, string cor, decimal preco, string tipoCombustivel)
        {
            Placa = placa?.ToUpper().Trim();
            Marca = marca?.Trim();
            Modelo = modelo?.Trim();
            AnoFabricacao = anoFabricacao;
            Cor = cor?.Trim();
            Preco = preco;
            TipoCombustivel = tipoCombustivel;
        }

        // Representação textual do objeto
        public override string ToString()
        {
            return $"{Placa} - {Marca} {Modelo} ({AnoFabricacao})";
        }
    }
}