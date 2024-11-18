using InvestHelper.Data.Context;
using InvestHelper.Domain.Entity;

namespace InvestHelper.Data.Repository
{
    public class FundoImobiliarioRepository : Repository<FundoImobiliario>
    {
        public FundoImobiliarioRepository(InvestDbContext dbContext) : base(dbContext)
        {
        }
    }
}
