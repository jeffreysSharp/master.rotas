namespace Master.Rotas.Business.Models
{
    public class Rota : Entity
    {
        public string Origem { get; set; }
        public string Destino { get; set; }
        public double Valor { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
