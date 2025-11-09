using Microsoft.AspNetCore.Mvc;

namespace devfreela.API.Controllers
{
	[Route("api/projects")]
	[ApiController]
	public class ProjectsController : ControllerBase
	{
		// GET api/projects?query=net core
		[HttpGet]
		public IActionResult Get(string query)
		{
			return Ok("Listando todos os projetos...");
		}

		// GET api/projects/{id}
		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			return Ok($"Retornando o projeto com ID: {id}");
		}

		// POST api/projects
		[HttpPost]
		public IActionResult Post([FromBody] object createProject)
		{
			return CreatedAtAction(nameof(GetById), new { createProject.Id }, createProject);
		}

		// PUT api/projects/{id}
		[HttpPut("{id}")]
		public IActionResult Put(int id, [FromBody] object model)
		{
			return Ok($"Atualizando o projeto com ID: {id}");
		}

		// DELETE api/projects/{id}
		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			return Ok($"Projeto com ID: {id} removido.");
		}

		// PATCH api/projects/{id}/start
		[HttpPatch("{id}/start")]
		public IActionResult StartProject(int id)
		{
			return Ok($"Projeto com ID: {id} iniciado.");
		}

		// PATCH api/projects/{id}/finish
		[HttpPatch("{id}/finish")]
		public IActionResult FinishProject(int id)
		{
			return Ok($"Projeto com ID: {id} finalizado.");
		}
	}
}
