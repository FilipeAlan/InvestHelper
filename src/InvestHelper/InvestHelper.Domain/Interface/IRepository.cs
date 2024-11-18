using InvestHelper.Domain.Entity;

namespace InvestHelper.Domain.Interface
{
    public interface IRepository<T> where T: Entidade
    {
        public Task<Guid> Criar(T entidade);
        public Task<T> Obter(Guid id);
        public Task<T> Editar(T entidade);
        public Task<bool> Deletar(Guid id);
    }
}
