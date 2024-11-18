using InvestHelper.Domain.Interface;
using InvestHelper.Domain.Entity;
using InvestHelper.Data.Context;

namespace InvestHelper.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : Entidade
    {
        private readonly InvestDbContext _dbContext;
        public Repository(InvestDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> Criar(T entidade)
        {
            _dbContext.ChangeTracker.AutoDetectChangesEnabled = false;
            _dbContext.Add(entidade);
            await _dbContext.SaveChangesAsync();
            return entidade.Id;
        }

        public async Task<bool> Deletar(Guid id)
        {
            _dbContext.Remove(id);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<T> Editar(T entidade)
        {
            _dbContext.Update(entidade);
            await _dbContext.SaveChangesAsync();
            return entidade;
        }

        public async Task<T> Obter(Guid id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }
    }
}
