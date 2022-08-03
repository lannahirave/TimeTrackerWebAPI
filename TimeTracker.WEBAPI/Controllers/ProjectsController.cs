using Microsoft.AspNetCore.Mvc;
using TimeTracker.BLL.ModelsDTO.DTORead;
using TimeTracker.BLL.ModelsDTO.DTOWrite;
using TimeTracker.BLL.Services.Abstract;

namespace TimeTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly ProjectBaseService _projectBaseService;

        public ProjectsController(ProjectBaseService projectBaseService)
        {
            _projectBaseService = projectBaseService;
        }
        // GET: api/Projects
        [HttpGet]
        public async Task<IActionResult> GetProjects()
        {
            try
            {
                var projects = await _projectBaseService.GetProjectsAsync();
                return Ok(projects);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/Projects/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult>GetProjectById(int id)
        {
            try
            {
                var project = await _projectBaseService.GetProjectByIdAsync(id);
                return Ok(project);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/Projects
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProjectDtoWrite projectDtoWrite)
        {
            try
            {
                var project = await _projectBaseService.CreateProjectAsync(projectDtoWrite);
                return Ok(project);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Projects/5
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] ProjectDtoRead projectDtoRead)
        {
            try
            {
                var project = await _projectBaseService.UpdateProjectAsync(projectDtoRead);
                return Ok(project);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/Projects/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _projectBaseService.DeleteProjectAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
