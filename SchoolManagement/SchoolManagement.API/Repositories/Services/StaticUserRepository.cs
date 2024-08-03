using SchoolManagement.API.Models.Domain;
using SchoolManagement.API.Repositories.Interfaces;

namespace SchoolManagement.API.Repositories.Services
{
    public class StaticUserRepository : IUserRepository
    {
        private List<User> users = new List<User>
        {
            new User
            {
                Id=Guid.NewGuid(),
                UserName="reader@gmail.com",
                Email="reader@gmail.com",
                Password="reader@123"
            },
            new User
            {
                Id=Guid.NewGuid(),
                UserName="readerwriter@gmail.com",
                Email="readerwriter@gmail.com",
                Password="readerwriter@123"
            }   
        };

        public async Task<User> Authenticate(string userName, string password)
        {
            return users.Find(x => x.UserName.Equals(userName, StringComparison.InvariantCultureIgnoreCase) && x.Password.Equals(password, StringComparison.InvariantCultureIgnoreCase));
            
        }
    }
}
