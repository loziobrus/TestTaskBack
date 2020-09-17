using System.Threading.Tasks;
using TestTask.Core.Abstractions;
using TestTask.Core.Abstractions.Repositories;
using TestTask.DAL.Repositories;

namespace TestTask.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TestTaskApiContext _dbContext;

        private AnnouncementRepository _announcementRepository;

        public UnitOfWork(TestTaskApiContext context)
        {
            _dbContext = context;
        }

        public IAnnouncementRepository AnnouncementRepository => _announcementRepository ??= new AnnouncementRepository(_dbContext);

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
