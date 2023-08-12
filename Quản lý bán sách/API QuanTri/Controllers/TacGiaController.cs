using Microsoft.AspNetCore.Mvc;

using BLL.Interface;
using BLL;
using Model;
using Microsoft.AspNetCore.Authorization;

namespace API_QuanTri.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TacGiaController : ControllerBase
    {
        private ITacGiaBLL _tacgiaBusiness;
        public TacGiaController(ITacGiaBLL tacgiaBusiness)
        {
            _tacgiaBusiness = tacgiaBusiness;
        }
        [Route("timkiem/{ten}")]
        [HttpGet]
        public List<TacGiaModel> TimKiem(string ten)
        {
            return _tacgiaBusiness.TimKiem(ten);
        }
        [Route("get-all-data/{soluong}")]
        [HttpGet]
        public List<TacGiaModel> GetAll(int soluong)
        {
            return _tacgiaBusiness.GetAll(soluong);
        }
        [Route("get-by-id/{id}")]
        [HttpGet]
        public TacGiaModel GetDatabyID(int id)
        {
            return _tacgiaBusiness.GetById(id);
        }
        [Route("update-tacgia")]
        [HttpPost]
        public TacGiaModel Update([FromBody] TacGiaModel model)
        {
            _tacgiaBusiness.Update(model);
            return model;
        }

        [Route("create-tacgia")]
        [HttpPost]
        public TacGiaModel Create([FromBody] TacGiaModel model)
        {
            _tacgiaBusiness.Create(model);
            return model;
        }
        [Route("delete-tacgia/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _tacgiaBusiness.Delete(id);
            return Ok(new { data = "OK" });
        }
    }
}
