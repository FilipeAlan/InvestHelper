using InvestHelper.Data.Context;
using InvestHelper.Domain.Entity;

namespace InvestHelper.Data.Repository
{
    public class AdministradoraRepository : Repository<Administradora>
    {
        public AdministradoraRepository(InvestDbContext dbContext) : base(dbContext)
        {
        }
    }
}
