using Microsoft.EntityFrameworkCore;
using SchoolManagement.API.Data;
using SchoolManagement.API.Models.Domain;
using SchoolManagement.API.Models.DTO;
using SchoolManagement.API.Repositories.Interfaces;

namespace SchoolManagement.API.Repositories.Services
{
    public class StudentRepository : IStudentRepository
    {
        private readonly SchoolManagementDbContext _dbcontext;
        public StudentRepository(SchoolManagementDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public List<Students> GetStudentDetails()
        {
            var students = _dbcontext.Students.ToList();
            return students;
        }
    }
}
