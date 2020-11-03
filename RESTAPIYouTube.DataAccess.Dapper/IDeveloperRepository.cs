using RESTAPIYouTube.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RESTAPIYouTube.DataAccess.Dapper
{
    public interface IDeveloperRepository
    {
        Task<IEnumerable<Developer>> GetAllDevelopersAsync();
        Task<Developer> GetDeveloperByIdAsync(int Id);
        Task<Developer> GetDeveloperByEmailAsync(string Email);
        void AddDeveloper(Developer developer);
        void UpdateDeveloper(Developer developer);
        void DeleteDeveloper(int Id);
    }
}
