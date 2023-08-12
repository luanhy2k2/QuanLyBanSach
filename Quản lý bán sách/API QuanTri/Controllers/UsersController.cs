using Microsoft.AspNetCore.Mvc;
using BanMayTinh_V2.Code;
using API_QuanTri.Helpers;
using Microsoft.Extensions.Options;

namespace API_QuanTri.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private ITools _tools;
        private readonly AppSettings _appSettings;
        public UsersController(IOptions<AppSettings> appSettings, ITools tools)
        {
            _appSettings = appSettings.Value;
            _tools = tools;
        }
        [Route("upload")]
        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            try
            {
                if (file.Length > 0)
                {
                    string filePath = file.FileName.Replace("-", "_").Replace("%", "");
                    var fullPath = _tools.CreatePathFile(filePath);
                    using (var fileStream = new FileStream(fullPath, FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                    return Ok(new { filePath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Không thể upload tệp");
            }
        }
    }
}
