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

        public void DeleteProject(int id)
        {
            Project p = _context.Project.Find(id);
            _context.Project.Remove(p);
            _context.SaveChanges();
        }

        public List<Project> GetAll()
        {
            return _context.Project.ToList();
        }

        public Project GetById(int id)
        {
            return _context.Project.Find(id);
        }

        public void UpdateProject(Project obj)
        {
            _context.Project.Update(obj);
            _context.SaveChanges();
        }
    }
}
