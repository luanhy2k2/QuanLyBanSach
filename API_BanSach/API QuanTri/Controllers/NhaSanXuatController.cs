using Microsoft.AspNetCore.Mvc;
using Model;
using BLL.Interface;
using Microsoft.AspNetCore.Authorization;

namespace API_QuanTri.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class NhaSanXuatController : ControllerBase
    {
        private INhaSanXuatBLL _loaispBusiness;
        public NhaSanXuatController(INhaSanXuatBLL loaispBusiness)
        {
            _loaispBusiness = loaispBusiness;
        }
        [Route("timkiem/{ten}")]
        [HttpGet]
        public List<NhaSanXuatModel> TimKiem(string ten)
        {
            return _loaispBusiness.TimKiem(ten);
        }
        [Route("get-by-id/{id}")]
        [HttpGet]
        public NhaSanXuatModel GetDatabyID(int id)
        {
            return _loaispBusiness.GetById(id);
        }
        [Route("get-all-data/{soluong}")]
        [HttpGet]
        public List<NhaSanXuatModel> GetAll(int soluong)
        {
            return _loaispBusiness.GetAll(soluong);
        }
        [Route("update-nhasanxuat")]
        [HttpPost]
        public NhaSanXuatModel Update([FromBody] NhaSanXuatModel model)
        {
            _loaispBusiness.Update(model);
            return model;
        }

        [Route("create-nhasanxuat")]
        [HttpPost]
        public NhaSanXuatModel Create([FromBody] NhaSanXuatModel model)
        {
            _loaispBusiness.Create(model);
            return model;
        }
        [Route("delete-nhasanxuat/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _loaispBusiness.Delete(id);
            return Ok(new { data = "OK" });
        }
    }
}
