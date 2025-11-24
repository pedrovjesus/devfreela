using devfreela.Application.Services.Interfaces;
using devfreela.Application.ViewModels;
using devfreela.Infrastructure.Persistence;

namespace devfreela.Application.Services
{
    public class UserService : IUserService
    {
        private readonly DevfreelaDbContext _dbContext;

        public UserService(DevfreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<UserViewModel> GetAll()
        {
            var users = _dbContext.Users;

            return users
                .Select(u => new UserViewModel(
                    u.Id,
                    u.FullName,
                    u.Email,
                    u.BirthDate,
                    u.CreatedAt
                )).ToList();
        }
    }
}
