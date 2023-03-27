using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IUsersRepository : IRepository<Users>
    {
        public Users GetByPassword(string email, string password);

        public int GetNumberOfUsers();

        public Task<bool> CheckEmailExistsAsync(string email);

        public Task<List<Users>> GetArtistAsync();

        public Task<Jobs> GetJobByNameAsync(string name);

        public Task<List<Users>> GetUsersByJobIdAsync(int jobId);
        
        public string GenerateRandomPassword(int length);

        //public Users GetByPassword(string name, string email, string password);
    }
}
