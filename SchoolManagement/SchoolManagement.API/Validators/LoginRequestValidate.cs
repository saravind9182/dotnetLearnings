using FluentValidation;
using SchoolManagement.API.Models.DTO;

namespace SchoolManagement.API.Validators
{
    public class LoginRequestValidate:AbstractValidator<LoginRequestDto>
    {
        public LoginRequestValidate()
        {
            RuleFor(x=>x.UserName).NotEmpty();
            RuleFor(x=>x.Password).NotEmpty();
        }
    }
}
