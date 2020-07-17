using ProjectService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectService.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly MicroservicesContext _context;

        public ProjectRepository()
        {
            _context = new MicroservicesContext();
        }
        public void AddProject(Project p)
        {
            _context.Project.Add(p);
            _context.SaveChanges();
        }
    }
}
