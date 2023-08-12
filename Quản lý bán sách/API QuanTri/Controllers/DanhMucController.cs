using Microsoft.AspNetCore.Mvc;
using BLL.Interface;
using BLL;
using Model;
using Model.Code;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace API_QuanTri.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
   
    
    public class DanhMucController : ControllerBase
    {
        
       
        private  IDanhMucBLL _danhmucBusiness;
        public DanhMucController(IDanhMucBLL danhmucBusiness)
        {
            _danhmucBusiness = danhmucBusiness;
        }
        
        [Route("get-all-data/{sl}")]
        [HttpGet]
        public List<DanhMucModel> GetAll(int sl)
        {
            return _danhmucBusiness.GetAll(sl).ToList();
        }
        [Route("get-by-id/{id}")]
        [HttpGet]
        public DanhMucModel GetDatabyID(int id)
        {
            return _danhmucBusiness.GetDatabyID(id);
        }
        [Route("update-danhmuc")]
        [HttpPost]
        public DanhMucModel Update([FromBody] DanhMucModel model)
        {
            _danhmucBusiness.Update(model);
            return model;
        }

        [Route("create-danhmuc")]
        [HttpPost]
        public DanhMucModel Create([FromBody] DanhMucModel model)
        {
            _danhmucBusiness.Create(model);
            return model;
        }
        [Route("delete-danhmuc/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _danhmucBusiness.Delete(id);
            return Ok(new { data = "OK" });
        }
        [Route("search-DauSach")]
        [HttpGet]
        public async Task<IActionResult> Search(int page, int pageSize, string? tenDanhMuc)
        {
            var response = new ResponseSearch();
            try
            {

                long total = 0;
                var data = new List<DanhMucModel>();
                if (tenDanhMuc == null) tenDanhMuc = "";

                data = _danhmucBusiness.Search(page, pageSize, out total, tenDanhMuc);
                response.TotalItems = total;
                response.Data = data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Ok(response);
        }
    }
}
