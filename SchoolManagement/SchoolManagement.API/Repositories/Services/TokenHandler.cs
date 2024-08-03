using Microsoft.IdentityModel.Tokens;
using SchoolManagement.API.Models.Domain;
using SchoolManagement.API.Repositories.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SchoolManagement.API.Repositories.Services
{
    public class TokenHandler : ITokenRepository
    {
        private readonly IConfiguration _configuration;

        public TokenHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public Task<string> CreateToken(User user)
        {

            var claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.GivenName, user.UserName));
            claims.Add(new Claim(ClaimTypes.Email, user.Email));

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims,
                expires:DateTime.Now.AddMinutes(5),
                signingCredentials:credentials
                );

            return Task.FromResult(new JwtSecurityTokenHandler().WriteToken(token));

        }
    }
}
