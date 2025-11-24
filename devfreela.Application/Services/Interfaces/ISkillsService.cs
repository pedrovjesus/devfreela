using devfreela.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devfreela.Application.Services.Interfaces
{
    public interface ISkillsService
    {
        List<SkillViewModel> GetAll();
    }
}
