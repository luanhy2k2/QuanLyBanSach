 using Microsoft.AspNetCore.Mvc;
using BLL.Interface;
using BLL;
using Model;
using Model.Code;

namespace API_NguoiDung.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
        [Route("get-by-id/{id}")]
        [HttpGet]
        public GetByIdDonHang GetDatabyID(int id)
        {
            return _donhangBLL.GetById(id);
        }
        [Route("timkiem/{ten}")]
        [HttpGet]
        public List<hienthiDonHang> TimKiem(string ten)
        {
            return _donhangBLL.TimKiem(ten);
        }
        [Route("timkiem_nguoidung/{sdt}")]
        [HttpGet]
        public List<hienthiDonHang> TimKiemNguoiDung(string sdt)
        {
            return _donhangBLL.TimKiemNguoiDung(sdt);
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
