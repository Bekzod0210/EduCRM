using EduCRM.Data;
using EduCRM.Interfaces;
using EduCRM.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EduCRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MentorController : ControllerBase
    {
        private readonly IMentorRepository _mentorRepository;
        private readonly AppDbContext _appDbContext;

        public MentorController(IMentorRepository mentorRepository, AppDbContext appDbContext)
        {
            _mentorRepository = mentorRepository;
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> CreateGroup([FromForm] Group group)
        {
            return Ok(group);
        }

        

    }
}
