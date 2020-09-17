using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestTask.Core.Abstractions.Repositories;

namespace TestTask.Core.Abstractions
{
    public interface IUnitOfWork
    {
        public IAnnouncementRepository AnnouncementRepository { get; }

        public void Save();
        public Task SaveAsync();
    }
}
