using ProjectService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectService.Repositories
{
    interface IProjectRepository
    {
        void AddProject(Project p);
        List<Project> GetAll();

        Project GetById(int id);
        void DeleteProject(int id);
        void UpdateProject(Project obj);

    }
}
