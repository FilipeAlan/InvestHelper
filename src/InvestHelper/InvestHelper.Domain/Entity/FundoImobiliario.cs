
namespace InvestHelper.Domain.Entity
{
    public class FundoImobiliario : Entidade
    {
        public Administradora Administradora { get; set; }
        public int AdministradoraId { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Setor { get; set; }
        public decimal ValorPatrimonial { get; set; }
        public decimal PrecoAtual { get; set; }
        public decimal DividendYield { get; set; }
        public int LiquidezDiaria { get; set; }
        public decimal VacanciaFisica { get; set; }
        public decimal VacanciaFinanceira { get; set; }
        public int QuantidadeImoveis { get; set; }
        public bool GestaoAtiva { get; set; }
        public DateTime DataConstituicao { get; set; }
        public decimal DistribuicaoMedia { get; set; }
        public string TipoFundo { get; set; }
    }
}
