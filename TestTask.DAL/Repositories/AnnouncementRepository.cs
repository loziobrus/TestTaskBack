using System;
using System.Collections.Generic;
using System.Text;
using TestTask.Core.Abstractions.Repositories;
using TestTask.Core.Entities;

namespace TestTask.DAL.Repositories
{
    public class AnnouncementRepository : BaseRepository<Announcement, int>, IAnnouncementRepository
    {
        public AnnouncementRepository(TestTaskApiContext context) : base(context)
        { 
        }
    }
}
