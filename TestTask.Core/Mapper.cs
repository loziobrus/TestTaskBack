using AutoMapper;
using TestTask.Core.DTO;
using TestTask.Core.Entities;

namespace TestTask.Core
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<AnnouncementDto, Announcement>().ReverseMap();
        }
    }
}
