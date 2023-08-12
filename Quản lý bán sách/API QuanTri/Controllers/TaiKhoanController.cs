using Microsoft.AspNetCore.Mvc;
using Model;
using BLL.Interface;
using Microsoft.AspNetCore.Authorization;

namespace API_QuanTri.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class TaiKhoanController : Controller
    {
        private ITaiKhoanBLL _taikhoanBusiness;
        public TaiKhoanController(ITaiKhoanBLL taikhoanBusiness)
        {
            _taikhoanBusiness = taikhoanBusiness;
        }
        [Route("get-all-data")]
        [HttpGet]
        public List<TaiKhoan> GetAll()
        {
            return _taikhoanBusiness.GetAll();
        }
        [Route("get-by-id/{id}")]
        [HttpGet]
        public TaiKhoan GetDatabyID(int id)
        {
            return _taikhoanBusiness.GetById(id);
        }
        [Route("update-taikhoan")]
        [HttpPost]
        public TaiKhoan Update([FromBody] TaiKhoan model)
        {
            _taikhoanBusiness.Update(model);
            return model;
        }

        [Route("create-taikhoan")]
        [HttpPost]
        public TaiKhoan Create([FromBody] TaiKhoan model)
        {
            _taikhoanBusiness.Create(model);
            return model;
        }
        [Route("delete-taikhoan")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _taikhoanBusiness.Delete(id);
            return Ok(new { data = "OK" });
        }
    }
}
