using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.API.Models.DTO;
using SchoolManagement.API.Repositories.Interfaces;

namespace SchoolManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenRepository _tokenRepository;

        public AuthController(IUserRepository userRepository,ITokenRepository tokenRepository)
        {
            _userRepository = userRepository;
            _tokenRepository = tokenRepository;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> LoginAsync(LoginRequestDto loginRequestDto)
        {
            var user = await _userRepository.Authenticate(loginRequestDto.UserName,loginRequestDto.Password);
            if (user!=null)
            {
                var token = await _tokenRepository.CreateToken(user);
                return Ok(token)    ;
            }
            return BadRequest("Login Failed.");

        }
    }
}
