using Microsoft.AspNetCore.Mvc;
using Model;
using BLL.Interface;
using Microsoft.AspNetCore.Authorization;

namespace API_QuanTri.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class GiaSachController : Controller
    {
        private IGiaSachBLL _GiaSachBusiness;
        public GiaSachController(IGiaSachBLL GiaSachBusiness)
        {
            _GiaSachBusiness = GiaSachBusiness;
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public GiaCaModel GetDatabyID(int id)
        {
            return _GiaSachBusiness.GetById(id);
        }
        [Route("get-all-data")]
        [HttpGet]
        public List<GiaCaModel> GetAll()
        {
            return _GiaSachBusiness.GetAll();
        }
        [Route("update-GiaSach")]
        [HttpPost]
        public GiaCaModel Update([FromBody] GiaCaModel model)
        {
            _GiaSachBusiness.Update(model);
            return model;
        }

        [Route("create-GiaSach")]
        [HttpPost]
        public GiaCaModel Create([FromBody] GiaCaModel model)
        {
            _GiaSachBusiness.Create(model);
            return model;
        }
        [Route("delete-GiaSach")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _GiaSachBusiness.Delete(id);
            return Ok(new { data = "OK" });
        }
    }
}
