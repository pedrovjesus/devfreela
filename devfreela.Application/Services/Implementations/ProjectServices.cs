using devfreela.Application.Services.Interfaces;
using devfreela.Application.ViewModel;
using devfreela.Application.InputModels;
using devfreela.Infrastructure.Persistence;
using devfreela.Core.Entities;
using System.Collections.Generic;

namespace devfreela.Application.Services.Implementations
{
    public class ProjectService : IProjectService
    {
        private readonly DevfreelaDbContext _dbContext;

        public ProjectService(DevfreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(NewProjectInputModel inputModel)
        {
            var project = new Project(inputModel.Title, inputModel.Description, inputModel.IdClient, inputModel.IdFreelancer, inputModel.TotalCost);
            _dbContext.Projects.Add(project);

            return project.id;
        }

        public void CreateComment(CreateCommentInputModel inputModel)
        {
            var comment = new ProjectComment(inputModel.Content, inputModel.IdUser, inputModel.IdProject);
            _dbContext.ProjectComments.Add(comment);
            
        }

        public void Delete(int id)
        {
            // Apenas esqueleto
        }

        public List<ProjectViewModel> GetAll(string query)
        {
            // Retornando lista vazia para evitar erros de build
            return new List<ProjectViewModel>();
        }

        public ProjectDetailsViewModel GetById(int id)
        {
            // Retornando null apenas para compilar
            return null;
        }

        public void Update(UpdateProjectInputModel inputModel)
        {
            // Apenas esqueleto
        }

        public void Start(int id)
        {
            // Apenas esqueleto
        }

        public void Finish(int id)
        {
            // Apenas esqueleto
        }
    }
}
