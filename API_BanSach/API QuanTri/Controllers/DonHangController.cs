using Microsoft.AspNetCore.Mvc;
using BLL.Interface;
using BLL;
using Model;
using Model.Code;
using Microsoft.AspNetCore.Authorization;

namespace API_NguoiDung.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DonHangController : ControllerBase
    {
        private IDonHangBLL _donhangBLL;
        public DonHangController(IDonHangBLL donhangBLL)
        {
            _donhangBLL = donhangBLL;
        }
        [Route("create-DonHang")]
        [HttpPost]
        public DonHang Create([FromBody] DonHang model)
        {
            _donhangBLL.Create(model);
            return model;
        }
        [Route("Create_DonHang")]
        [HttpPost]
        public DonHangModel CreateDonHang([FromBody] DonHangModel model)
        {
            _donhangBLL.CreateDonHang(model);
            return model;
        }

        [Route("add_hoadonban")]
        [HttpPost]
        public addHoaDonBan CreateDonHang([FromBody] addHoaDonBan model)
        {
            _donhangBLL.addHoaDon(model);
            return model;
        }


        [Route("Create_ChiTiet")]
        [HttpPost]
        public ChiTietDonHang CreateChiTiet([FromBody] ChiTietDonHang model)
        {
            _donhangBLL.CreateChiTiet(model);
            return model;
        }

        [Route("get-all-data/{soluong}")]
        [HttpGet]
        public List<hienthiDonHang> GetAll(int soluong)
        {
            return _donhangBLL.GetAll(soluong);
        }


        [Route("get_donHang_byId/{id}")]
        [HttpGet]
        public getDonHang getDonHangById(int id)
        {
            return _donhangBLL.getDonHangById(id);
        }

        [Route("get_ChiTiet_byId/{id}")]
        [HttpGet]
        public List<getChiTietDonhang> getChiTietDonHangById(int id)
        {
            return _donhangBLL.getChiTietDonHangById(id);
        }







        [Route("timkiem/{ten}")]
        [HttpGet]
        public List<hienthiDonHang> TimKiem(string ten)
        {
            return _donhangBLL.TimKiem(ten);
        }

        [Route("donhang/{sl}")]
        [HttpGet]
        public List<getdonhang> DonHang(int sl)
        {
            return _donhangBLL.DonHang(sl);
        }


        [Route("get-by-id/{id}")]
        [HttpGet]
        public GetByIdDonHang GetDatabyID(int id)
        {
            return _donhangBLL.GetById(id);
        }

        [Route("get-khachhang-by-id/{id}")]
        [HttpGet]
        public KhachHangModel getKhachHangById(int id)
        {
            return _donhangBLL.getKhachHangById(id);
        }

        [Route("get-chitiet-by-id/{id}")]
        [HttpGet]
        public List<ChiTiet> getChiTietById(int id)
        {
            return _donhangBLL.getChiTietById(id);
        }


        [Route("update-donhang")]
        [HttpPost]
        public DonHangModel Update([FromBody] DonHangModel model)
        {
            _donhangBLL.UpdateDonHang(model);
            return model;
        }
        [Route("update-chitiet")]
        [HttpPost]
        public ChiTietDonHang UpdateChiTiet([FromBody] ChiTietDonHang model)
        {
            _donhangBLL.UpdateChiTiet(model);
            return model;
        }
        [Route("delete-donhang/{id}")]
        [HttpDelete]
        public IActionResult DeleteDonHang(int id)
        {
            _donhangBLL.DeleteDonHang(id);
            return Ok(new { data = "OK" });
        }
        [Route("delete-chitiet/{id}")]
        [HttpDelete]
        public IActionResult DeleteChiTiet(int id)
        {
            _donhangBLL.DeleteChiTiet(id);
            return Ok(new { data = "OK" });
        }

        //[Route("search")]
        //[HttpPost]
        ////public DonHang Search([FromBody] Dictionary<string, object> formData)
        ////{
        ////    var response = new ResponseModel();
        ////    try
        ////    {
        ////        var page = int.Parse(formData["page"].ToString());
        ////        var pageSize = int.Parse(formData["pageSize"].ToString());
        ////        int? MaDanhMuc = null;
        ////        if (formData.Keys.Contains("TenKhachHang") && !string.IsNullOrEmpty(Convert.ToString(formData["TenKhachHang"]))) { TenKhachHang = Convert.ToInt32(formData["M"]); }
        ////        string TenDanhMuc = "";
        ////        if (formData.Keys.Contains("TenDanhMuc") && !string.IsNullOrEmpty(Convert.ToString(formData["TenDanhMuc"]))) { TenDanhMuc = Convert.ToString(formData["TenDanhMuc"]); }
        ////        string option = "";
        ////        if (formData.Keys.Contains("option") && !string.IsNullOrEmpty(Convert.ToString(formData["option"]))) { option = Convert.ToString(formData["option"]); }
        ////        long total = 0;
        ////        var data = _danhmucBusiness.Search(page, pageSize, out total, MaDanhMuc, TenDanhMuc, option);
        ////        response.TotalItems = total;
        ////        response.Data = data;
        ////        response.Page = page;
        ////        response.PageSize = pageSize;
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        throw new Exception(ex.Message);
        ////    }
        ////    return response;
        ////}
    }
}
