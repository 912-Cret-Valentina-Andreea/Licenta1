using elearning.Entities;
using elearning.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace elearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly IClassService _classService;

        public ClassController(IClassService classService)
        {
            _classService = classService;
        }

        [HttpGet("list-classes")]
        public async Task<ActionResult<List<Classes>>> GetAllClasses()
        {
            var classes = await _classService.GetAllClasses();
            return (classes == null) ? NotFound("No classes available") : classes;
        }

        [HttpPost("create-class")]
        public async Task<ActionResult<List<Classes>>> CreateClass([FromBody]Classes newClass)
        {
            await _classService.CreateClass(newClass);
            var classes = await _classService.GetAllClasses();
            return classes;
        }
    }
}
