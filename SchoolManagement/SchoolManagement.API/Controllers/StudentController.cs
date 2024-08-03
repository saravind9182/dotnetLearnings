using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.API.Models.Domain;
using SchoolManagement.API.Models.DTO;
using SchoolManagement.API.Repositories.Interfaces;

namespace SchoolManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }   
        [HttpGet]
        public IActionResult GetAll()
        {
            var students = _studentRepository.GetStudentDetails();
            var studentDto = new List<StudentDetailsDto>();
            students.ToList().ForEach(student =>
            {
                var stuDto = new StudentDetailsDto
                {
                    Id = student.Id,
                    Name = student.Name,
                    Age = student.Age,
                    DOB = student.DOB,
                    Class = student.Class,
                    MobileNo = student.MobileNo,
                    DriverId = student.DriverId
                };
                studentDto.Add(stuDto);
            });
            return Ok(studentDto);
        }
    }
}
