using SchoolManagement.API.Models.Domain;

namespace SchoolManagement.API.Repositories.Interfaces
{
    public interface ITokenRepository
    {
        Task<string> CreateToken(User user);
    }
}
