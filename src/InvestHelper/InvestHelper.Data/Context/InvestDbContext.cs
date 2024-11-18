using Microsoft.EntityFrameworkCore;

namespace InvestHelper.Data.Context
{
    public class InvestDbContext:DbContext
    {
        public InvestDbContext(DbContextOptions<InvestDbContext> options) : base(options)
        {
        }
    }
}
