using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Core.Abstractions;
using TestTask.Core.Abstractions.Services;
using TestTask.Core.DTO;
using TestTask.Core.Entities;

namespace TestTask.Services
{
    public class AnnouncementService : IAnnouncementService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AnnouncementService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public List<AnnouncementDto> GetAll()
        {
            return _unitOfWork.AnnouncementRepository.GetAll().Select(el => _mapper.Map(el, new AnnouncementDto())).ToList();
        }

        public AnnouncementDto GetById(int Id)
        {
            var entity = _unitOfWork.AnnouncementRepository.GetAll().Where(x => x.Id == Id).ToList().FirstOrDefault();
            var dto = new AnnouncementDto();
            _mapper.Map(entity, dto);
            return dto;
        }

        public async Task<AnnouncementDto> Insert(AnnouncementDto announcementDto)
        {
            var entity = new Announcement();
            _mapper.Map(announcementDto, entity);
            await _unitOfWork.AnnouncementRepository.Insert(entity);
            await _unitOfWork.SaveAsync();
            _mapper.Map(entity, announcementDto);
            return announcementDto;
        }

        public AnnouncementDto Update(AnnouncementDto announcementDto)
        {
            var entity = new Announcement();
            _mapper.Map(announcementDto, entity);
            _unitOfWork.AnnouncementRepository.Update(entity);
            _unitOfWork.Save();
            _mapper.Map(entity, announcementDto);
            return announcementDto;
        }

        public async Task Delete(int Id)
        {
            await _unitOfWork.AnnouncementRepository.Delete(Id);
            await _unitOfWork.SaveAsync();
        }
    }
}
