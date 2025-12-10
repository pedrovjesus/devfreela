using devfreela.Application.InputModels;
using devfreela.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace devfreela.API.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        // GET api/projects?query=net core
        [HttpGet]
        public IActionResult Get(string query)
        {
           var projects = _projectService.GetAll(query);
            return Ok(projects);
        }

        // GET api/projects/{id}
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var project = _projectService.GetById(id); 
            if (project == null)
            {
                return NotFound();
            }
            return Ok(project);
        }

        // POST api/projects
        [HttpPost]
        public IActionResult Post([FromBody] NewProjectInputModel inputModel)
        {
            if(inputModel == null)
            {
                return BadRequest();
            }
            if(inputModel.Title.Length > 50)
            {
                return BadRequest();
            }
            if(inputModel.Description.Length > 500)
            {
                return BadRequest();
            }
            var id = _projectService.Create(inputModel);
            return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
        }

        // PUT api/projects/{id}
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] object model)
        {
            var project = _projectService.GetById(id);
            if (project == null)
            {
                return NotFound();
            }
            _projectService.Update(project);
            return NoContent();
        }

        // DELETE api/projects/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var project = _projectService.GetById(id);
            if (project == null)
            {
                return NotFound();
            }
            _projectService.Delete(id);
            return NoContent();
        }

        // PATCH api/projects/{id}/start
        [HttpPatch("{id}/start")]
        public IActionResult StartProject(int id)
        {
            var project = _projectService.GetById(id);
            if (project == null)
            {
                return NotFound();
            }
           _projectService.Start(id);
            return NoContent();
        }

        // PATCH api/projects/{id}/finish
        [HttpPatch("{id}/finish")]
        public IActionResult FinishProject(int id)
        {
            var project = _projectService.GetById(id);
            if (project == null)
            {
                return NotFound();
            }
            _projectService.Finish(id);
            return NoContent();
        }
    }
}
