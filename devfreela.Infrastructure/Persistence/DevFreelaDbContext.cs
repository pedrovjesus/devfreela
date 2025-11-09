using devfreela.Core.Entities;
using System.Collections.Generic;

namespace devfreela.Infrastructure.Persistence
{
    public class DevfreelaDbContext
    {
        public DevfreelaDbContext()
        {
            Projects = new List<Projects>
            {
                new Project("Meu projeto ASPNET Core 1", "Minha Descrição de Projeto 1", 1, 1, 10000),
                new Project("Meu projeto ASPNET Core 2", "Minha Descrição de Projeto 2", 1, 1, 20000),
                new Project("Meu projeto ASPNET Core 3", "Minha Descrição de Projeto 3", 1, 1, 30000)
            };
            Users = new List<User>
            {
                new User("Luis1", "luis@dev.com.br", new DateTime(1992, 1, 1)),
                new User ("Robert", "robert@dev.com.br", new DateTime(1990, 1, 1)),
                new User ("anderson", "anderson@dev.com.br", new DateTime(1980, 1, 1))
            };
            Skills = new List<Skill>
            {
                new Skill("C#"),
                new Skill("Java"),
                new Skill("JavaScript"),
                new Skill("SQL")
            };
        }
        public List<Projects> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }

    }
}