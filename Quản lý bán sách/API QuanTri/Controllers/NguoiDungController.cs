using Microsoft.AspNetCore.Mvc;
using Model;
using BLL.Interface;
using API_QuanTri.Helpers;
using Model.Code;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http;
using System.Text;
using System.Security.Cryptography;
using Microsoft.Extensions.Configuration;
using Project4.Modify;

namespace API_QuanTri.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NguoiDungController : Controller
    {
        public static TaiKhoanModel taiKhoan1 = new TaiKhoanModel();
        private INguoiDung _nguoidungBusiness;
        private readonly IConfiguration configuration;
        private readonly AppSettings _appSettings;
        public NguoiDungController(IOptions<AppSettings> appSettings,INguoiDung nguoidungBusiness)
        {
            _appSettings = appSettings.Value;
            _nguoidungBusiness = nguoidungBusiness;
        }
        [Route("timkiem/{ten}")]
        [HttpGet]
        public List<ThongTinNhanVien> TimKiem(string ten)
        {
            return _nguoidungBusiness.TimKiem(ten);
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public NguoiDung GetDatabyID(int id)
        {
            return _nguoidungBusiness.GetById(id);
        }
        [Route("get-all-data/{soluong}")]
        [HttpGet]
        public List<ThongTinNhanVien> GetAll(int soluong)
        {
            return _nguoidungBusiness.GetAll(soluong);
        }
        [Route("update-NguoiDung")]
        [HttpPost]
        public ThongTinNhanVien Update([FromBody] ThongTinNhanVien model)
        {
            _nguoidungBusiness.Update(model);
            return model;
        }

        [Route("create-NguoiDung")]
        [HttpPost]
        public ThongTinNhanVien Create([FromBody] ThongTinNhanVien model)
        {
            _nguoidungBusiness.Create(model);
            return model;
        }
        [Route("delete-NguoiDung/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _nguoidungBusiness.Delete(id);
            return Ok(new { data = "OK" });
        }
      
        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Authenticate(tk model)
        {
            var Taikhoan = model.TaiKhoan;
            var Matkhau = model.MatKhau;
            var query = _nguoidungBusiness.Authenticate(Taikhoan, Matkhau);


            // return null if user not found
            if (query == null)
                return Ok(new { message = "Tài khoản hoặc mật khẩu không đúng" });

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, query.hoTen.ToString()),
                    new Claim(ClaimTypes.Role, query.loaiQuyen),
                    new Claim(ClaimTypes.DenyOnlyWindowsDeviceGroup, query.matKhau)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var tmp = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(tmp);
            return Ok(new { maNguoiDung = query.maNguoiDung, hoTen = query.hoTen, taiKhoan = query.taiKhoan, Token = token });
        }
        //[AllowAnonymous]
        //[HttpPost("logins")]
        //public IActionResult login(tk model)
        //{
        //    var Taikhoan = model.TaiKhoan;
        //    var Matkhau = model.MatKhau;
        //    var query = _nguoidungBusiness.Authenticate(Taikhoan, Matkhau);


        //    // return null if user not found
        //    if (query == null)
        //        return Ok(new { message = "Tài khoản hoặc mật khẩu không đúng" });
        //    string token = CreateToken(taiKhoan1);
        //    return Ok(token);

        //    // authentication successful so generate jwt token

        //}
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
