using Microsoft.AspNetCore.Mvc;
using BLL.Interface;
using Model;
using Microsoft.AspNetCore.Authorization;

namespace API_QuanTri.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SachController : Controller
    {
        private ISachBLL _sachBusiness;
        public SachController(ISachBLL sachBusiness)
        {
            _sachBusiness = sachBusiness;
        }

        [Route("timkiem/{ten}")]
        [HttpGet]
        public List<sachHienthi> TimKiem(string ten)
        {
            return _sachBusiness.TimKiem(ten);
        }
        [Route("get-by-id/{id}")]
        [HttpGet]
        public sachHienthi GetDatabyID(int id)
        {
            return _sachBusiness.GetById(id);
        }
        [Route("get-all-data")]
        [HttpGet]
        public List<sachHienthi> GetAll()
        {
            return _sachBusiness.GetAll();
        }
        [Route("update-sach")]
        [HttpPost]
        public SachModel Update([FromBody] SachModel model)
        {
            _sachBusiness.Update(model);
            return model;
        }

        [Route("create-sach")]
        [HttpPost]
        public SachModel Create([FromBody] SachModel model)
        {
            _sachBusiness.Create(model);
            return model;
        }
        [Route("create-sanpham")]
        [HttpPost]
        public SanPham CreateSanPham([FromBody] SanPham model)
        {
            _sachBusiness.CreateSanPham(model);
            return model;
        }
        [Route("delete-sach/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _sachBusiness.Delete(id);
            return Ok(new { data = "OK" });
        }

    }
}
