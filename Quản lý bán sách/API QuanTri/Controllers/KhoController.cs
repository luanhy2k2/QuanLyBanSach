using Microsoft.AspNetCore.Mvc;
using Model.Code;
using BLL.Interface;
using Model;
using Microsoft.AspNetCore.Authorization;

namespace API_QuanTri.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class KhoController : ControllerBase
    {
        private IKhoBLL _KhoBusiness;
        public KhoController(IKhoBLL KhoBusiness)
        {
            _KhoBusiness = KhoBusiness;
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public khoedit GetDatabyID(int id)
        {
            return _KhoBusiness.GetById(id);
        }
        [Route("get-all-data")]
        [HttpGet]
        public List<khoedit> GetAll()
        {
            return _KhoBusiness.GetAll();
        }
        [Route("update-Kho")]
        [HttpPost]
        public khoedit Update([FromBody] khoedit model)
        {
            _KhoBusiness.Update(model);
            return model;
        }

        [Route("create-Kho")]
        [HttpPost]
        public khoedit Create([FromBody] khoedit model)
        {
            _KhoBusiness.Create(model);
            return model;
        }
        [Route("delete-Kho/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _KhoBusiness.Delete(id);
            return Ok(new { data = "OK" });
        }
        [Route("timkiem/{ten}")]
        [HttpGet]
        public List<khoedit> TimKiem(int ten)
        {
            return _KhoBusiness.TimKiem(ten);
        }
    }
}
