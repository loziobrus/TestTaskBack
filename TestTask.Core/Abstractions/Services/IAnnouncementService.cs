using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestTask.Core.DTO;

namespace TestTask.Core.Abstractions.Services
{
    public interface IAnnouncementService
    {
        public List<AnnouncementDto> GetAll();

        public AnnouncementDto GetById(int Id);

        public Task<AnnouncementDto> Insert(AnnouncementDto announcementDto);

        public AnnouncementDto Update(AnnouncementDto announcementDto);

        public Task Delete(int Id);
    }
}
