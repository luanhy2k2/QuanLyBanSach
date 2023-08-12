using BLL.Interface;
using Microsoft.AspNetCore.Mvc;
using Model.Code;
using Model;
using Microsoft.AspNetCore.Authorization;

namespace API_QuanTri.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class HoaDonBanController : Controller
    {
        private IHoaDonBanBLL _donhangBLL;
        public HoaDonBanController(IHoaDonBanBLL donhangBLL)
        {
            _donhangBLL = donhangBLL;
        }
        
        [Route("Create_HoaDon")]
        [HttpPost]
        public HoaDonBanModel CreateDonHang([FromBody] HoaDonBanModel model)
        {
            _donhangBLL.CreateHoaDon(model);
            return model;
        }
        [Route("Create_ChiTiet")]
        [HttpPost]
        public ChiTetHoaDonBanModel CreateChiTiet([FromBody] ChiTetHoaDonBanModel model)
        {
            _donhangBLL.CreateChiTiet(model);
            return model;
        }

        [Route("get-all-data/{soluong}")]
        [HttpGet]
        public List<HienThiHoaDonBan> GetAll(int soluong)
        {
            return _donhangBLL.GetAll(soluong);
        }

        [Route("get-chitiet/{id}")]
        [HttpGet]
        public List<ChiTietHoaDonBan> getChiTiet(int id)
        {
            return _donhangBLL.getChiTiet(id);
        }

        [Route("get-hoadon/{id}")]
        [HttpGet]
        public getHoaDon getHoaDon(int id)
        {
            return _donhangBLL.getHoaDon(id);
        }

        [Route("get-data-hoadon/{sl}")]
        [HttpGet]
        public List<hoadonbanmd> hoadonban(int sl)
        {
            return _donhangBLL.hoadonban(sl);
        }


        [Route("timkiem/{ten}")]
        [HttpGet]
        public List<HienThiHoaDonBan> TimKiem(string ten)
        {
            return _donhangBLL.TimKiem(ten);
        }
        
        [Route("update-hoadon")]
        [HttpPost]
        public HoaDonBanModel Update([FromBody] HoaDonBanModel model)
        {
            _donhangBLL.UpdateHoaDon(model);
            return model;
        }
        [Route("update-chitiet")]
        [HttpPost]
        public ChiTetHoaDonBanModel UpdateChiTiet([FromBody] ChiTetHoaDonBanModel model)
        {
            _donhangBLL.UpdateChiTiet(model);
            return model;
        }
        [Route("delete-hoadon/{id}")]
        [HttpDelete]
        public IActionResult DeleteDonHang(int id)
        {
            _donhangBLL.DeleteHoaDon(id);
            return Ok(new { data = "OK" });
        }
        [Route("delete-chitiet/{id}")]
        [HttpDelete]
        public IActionResult DeleteChiTiet(int id)
        {
            _donhangBLL.DeleteChiTiet(id);
            return Ok(new { data = "OK" });
        }
    }
}
