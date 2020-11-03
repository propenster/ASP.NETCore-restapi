using RESTAPIYouTube.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RESTAPIYouTube.Services
{
    public interface IDeveloperService
    {
        Task<IEnumerable<Developer>> GetAllDevelopers();
        Task<Developer> GetDeveloperById(int Id);
        Task<Developer> GetDeveloperByEmail(string Email);
        void AddDeveloper(Developer developer);
        void UpdateDeveloper(Developer developer);
        void DeleteDeveloper(int Id);

    }
}
