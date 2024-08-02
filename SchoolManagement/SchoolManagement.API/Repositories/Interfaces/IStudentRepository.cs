using SchoolManagement.API.Models.Domain;

namespace SchoolManagement.API.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        List<Students> GetStudentDetails();
    }
}
