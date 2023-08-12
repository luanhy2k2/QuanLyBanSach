using Microsoft.AspNetCore.Mvc;
using BLL.Interface;
using Model;
using Model.Code;
using Microsoft.AspNetCore.Authorization;

namespace API_QuanTri.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class HoaDonNhapController : Controller
    {
        private IHoaDonNhapBLL _HoaDonNhapBusiness;
        public HoaDonNhapController(IHoaDonNhapBLL HoaDonNhapBusiness)
        {
            _HoaDonNhapBusiness = HoaDonNhapBusiness;
        }
        [Route("timkiem/{ten}")]
        [HttpGet]
        public List<hienThiHoaDonNhap> TimKiem(int ten)
        {
            return _HoaDonNhapBusiness.TimKiem(ten);
        }
        [Route("hoadonnhap_all/{sl}")]
        [HttpGet]
        public List<hoadonnhap> HoaDonNhap(int sl)
        {
            return _HoaDonNhapBusiness.HoaDonNhap(sl);
        }

        [Route("hoadonnhap_get/{sl}")]
        [HttpGet]
        public getHoaDonNhap getHoaDonNhap(int sl)
        {
            return _HoaDonNhapBusiness.getHoaDonNhap(sl);
        }
        [Route("hoadonnhap_chitiet/{sl}")]
        [HttpGet]
        public List<getChiTietHoaDonNhap> getChiTietHoaDonNhap(int sl)
        {
            return _HoaDonNhapBusiness.getChiTietHoaDonNhap(sl);
        }


        [Route("get-by-id/{id}")]
        [HttpGet]
        public hienThiHoaDonNhap GetDatabyID(int id)
        {
            return _HoaDonNhapBusiness.GetById(id);
        }
        [Route("get-all-data/{soluong}")]
        [HttpGet]
        public List<hienThiHoaDonNhap> GetAll(int soluong)
        {
            return _HoaDonNhapBusiness.GetAll(soluong);
        }
        [Route("update-HoaDonNhap")]
        [HttpPost]
        public edithdnmodel Update([FromBody] edithdnmodel model)
        {
            _HoaDonNhapBusiness.Update(model);
            return model;
        }

        //[Route("tao-HoaDonNhap")]
        //[HttpPost]
        //public hoadonnhapss tao([FromBody] hoadonnhapss model)
        //{
        //    _HoaDonNhapBusiness.Create(model);
        //    return model;
        //}
        [Route("create-HoaDonNhap")]
        [HttpPost]
        public hdnmodel Create([FromBody] hdnmodel model)
        {
            _HoaDonNhapBusiness.taomoi(model);
            return model;
        }
        [Route("create-ChiTietHoaDonNhap")]
        [HttpPost]
        public ChiTietHoaDonNhapModel CreateChiTiet([FromBody] ChiTietHoaDonNhapModel model)
        {
            _HoaDonNhapBusiness.CreateChiTiet(model);
            return model;
        }
        [Route("delete-HoaDonNhap/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _HoaDonNhapBusiness.Delete(id);
            return Ok(new { data = "OK" });
        }
    }
}
