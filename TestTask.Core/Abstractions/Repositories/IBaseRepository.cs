using System.Linq;
using System.Threading.Tasks;

namespace TestTask.Core.Abstractions.Repositories
{
    public interface IBaseRepository<TEntity, TId>
    {
        public IQueryable<TEntity> GetAll();

        public Task<TEntity> GetById(TId Id);

        public Task Insert(TEntity Entity);

        public TEntity Update(TEntity Entity);

        public Task Delete(TId Id);
    }
}
