using devfreela.Application.Services.Interfaces;
using devfreela.Application.ViewModels;
using devfreela.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devfreela.Application.Services.Implementations
{
    public class SkillService: ISkillsService
    {
        private readonly DevfreelaDbContext _dbContext;

        public SkillService(DevfreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<SkillViewModel> GetAll()
        {
            var skill = _dbContext.Skills;
            var skillViewModel = skill
                .Select(s => new SkillViewModel(s.Id, s.Description))
                .ToList();

            return skillViewModel;

        }

    }
}
