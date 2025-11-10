using devfreela.Application.Services.Interfaces;
using devfreela.Application.ViewModels;
using devfreela.Application.InputModels;
using devfreela.Infrastructure.Persistence;



namespace devfreela.Application.Services.Implementations
{
    public class ProjectService : IProjectService
    {
        private readonly DevFreelaDbContext _dbContext;
        public ProjectService(DevFreelaDbContext dbContext) { }
        public int Create(NewProjectInputModel inputModel)
        {

            return 1;
        }

        public void CreateComment(CreateCommentInputModel inputModel)
        {
            // TODO
        }

        public void Delete(int id)
        {
            // TODO
        }

        public List<ProjectViewModel> GetAll(string query)
        {
            // TODO: 
            // Temporário:<ProjectViewModel>();
        }

        public ProjectDetailsViewModel GetById(int id)
        {
            // TODO
            return null;
        }

        public void Update(UpdateProjectInputModel inputModel)
        {
            // TODO
        }

        public void Start(int id)
        {
            // TODO
        }

        public void Finish(int id)
        {
            // TODO
        }
    }
}
