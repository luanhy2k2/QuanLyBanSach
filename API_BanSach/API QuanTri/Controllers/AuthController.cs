using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Model;
using Project4.Modify;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace Project4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration configuration;
        public AuthController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public static TaiKhoanModel taiKhoan1 = new TaiKhoanModel();

        [HttpPost("Register")]
        public async Task<ActionResult<TaiKhoanModel>> Register(TaiKhoan request)
        {
            CreatePasswordHash(request.matKhau, out byte[] passwordHash, out byte[] passwordSalt);
            taiKhoan1.UserName = request.taiKhoan;
            taiKhoan1.PasswordHash = passwordHash;
            taiKhoan1.PasswordSalt = passwordSalt;
            return Ok(taiKhoan1);
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        [HttpPost("Login")]
        public async Task<ActionResult<string>> Login(tk request)
        {
            if (taiKhoan1.UserName != request.TaiKhoan)
            {
                return BadRequest("User not found");
            }
            if (!VerifyPasswordHash(request.MatKhau, taiKhoan1.PasswordHash, taiKhoan1.PasswordSalt))
            {
                return BadRequest("Wrong Password");
            }

            string token = CreateToken(taiKhoan1);
            return Ok(token);
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }

        private string CreateToken(TaiKhoanModel taikhoan)
        {
            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, taiKhoan1.UserName),
                new Claim(ClaimTypes.Role , "Admin")
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(configuration.GetSection("AppSettings:Token").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken
                (
                    claims: claims,
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: creds
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;
        }

        [HttpGet, Authorize]
        public ActionResult<string> GetClaims()
        {
            var userName = User?.Identity?.Name;
            var userName2 = User?.FindFirstValue(ClaimTypes.Name);
            var role = User?.FindFirstValue(ClaimTypes.Role);

            return Ok(new { userName, userName2, role });
        }
    }
}
