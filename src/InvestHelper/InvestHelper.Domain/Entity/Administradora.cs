namespace InvestHelper.Domain.Entity
{
    public class Administradora : Entidade
    {
        public string Nome { get; set; }
        public string CNPJ { get; set; }        
        public ICollection<FundoImobiliario> FundosImobiliarios { get; set; } = new List<FundoImobiliario>();
    }
}
