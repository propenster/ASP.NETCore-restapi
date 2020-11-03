using RESTAPIYouTube.DataAccess.Dapper;
using RESTAPIYouTube.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RESTAPIYouTube.Services
{
    public class DeveloperService : IDeveloperService
    {

        protected readonly IDeveloperRepository _developerRepository;

        public DeveloperService(IDeveloperRepository developerRepository)
        {
            _developerRepository = developerRepository;
        }

        public void AddDeveloper(Developer developer)
        {
            _developerRepository.AddDeveloper(developer);
        }

        public void DeleteDeveloper(int Id)
        {
            _developerRepository.DeleteDeveloper(Id);
        }

        public Task<IEnumerable<Developer>> GetAllDevelopers()
        {
            return _developerRepository.GetAllDevelopersAsync();
        }

        public Task<Developer> GetDeveloperByEmail(string Email)
        {
            return _developerRepository.GetDeveloperByEmailAsync(Email);
        }

        public Task<Developer> GetDeveloperById(int Id)
        {
            return _developerRepository.GetDeveloperByIdAsync(Id);
        }

        public void UpdateDeveloper(Developer developer)
        {
            _developerRepository.UpdateDeveloper(developer);
        }
    }
}
