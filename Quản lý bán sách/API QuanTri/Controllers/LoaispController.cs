using Microsoft.AspNetCore.Mvc;
using Model;
using BLL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Code;
using Microsoft.AspNetCore.Authorization;

namespace API_QuanTri.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LoaispController : ControllerBase
    {
        private ILoaispBLL _loaispBusiness;
        public LoaispController(ILoaispBLL loaispBusiness)  
        {
            _loaispBusiness = loaispBusiness;
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public LoaispModel GetDatabyID(int id)
        {
            return _loaispBusiness.GetById(id);
        }
        [Route("get-loaisp/{soluong}")]
        [HttpGet]
        public IActionResult GetAll(int soluong)
        {
            try
            {
                var listDanhMuc = _loaispBusiness.GetAll(soluong).ToList();
                return Ok(listDanhMuc);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
           
        }
        [Route("timkiem/{ten}")]
        [HttpGet]
        public List<LoaispModel> TimKiem(string ten)
        {
            return _loaispBusiness.TimKiem(ten);
        }
        [Route("update-loaisp")]
        [HttpPost]
        public LoaispModel Update([FromBody] LoaispModel model)
        {
            _loaispBusiness.Update(model);
            return model;
        }

        [Route("create-loaisp")]
        [HttpPost]
        public LoaispModel Create([FromBody] LoaispModel model)
        {
            _loaispBusiness.Create(model);
            return model;
        }
        [Route("delete-loaisp/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _loaispBusiness.Delete(id);
            return Ok(new { data = "OK" });
        }
    }
}
