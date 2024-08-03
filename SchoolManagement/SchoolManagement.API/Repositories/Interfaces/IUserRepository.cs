using SchoolManagement.API.Models.Domain;

namespace SchoolManagement.API.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User> Authenticate(string userName,string password);
    }
}
