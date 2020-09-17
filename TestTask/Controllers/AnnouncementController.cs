using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestTask.Core.Abstractions.Services;
using TestTask.Core.DTO;

namespace TestTask.Controllers
{
    [EnableCors("AllowMyOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementController : ControllerBase
    {
        private readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService service)
        {
            _announcementService = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AnnouncementDto>> GetAnnouncements()
        {
            try
            {
                var result = _announcementService.GetAll();
                return Ok(result);
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
            catch
            {
                return Problem();
            }
        }

        [HttpGet("{id}")]
        public ActionResult<AnnouncementDto> GetAnnouncement(int id)
        {
            try
            {
                var result = _announcementService.GetById(id);
                return Ok(result);
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
            catch
            {
                return Problem();
            }
        }

        [HttpPut("{id}")]
        public ActionResult<AnnouncementDto> EditAnnouncement(int id, AnnouncementDto announcement)
        {
            try
            {
                var result = _announcementService.Update(announcement);
                return Ok(result);
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
            catch 
            {
                return Problem();
            }
        }

        [HttpPost]
        public async Task<ActionResult<AnnouncementDto>> AddAnnouncement(AnnouncementDto announcement)
        {
            try
            {
                await _announcementService.Insert(announcement);
                return Ok(announcement);
            }
            catch 
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAnnouncement(int id)
        {
            try
            {
                await _announcementService.Delete(id);
                return NoContent();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
            catch
            {
                return Problem();
            }
        }
    }
}