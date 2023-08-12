using Microsoft.AspNetCore.Mvc;
using BLL.Interface;
using BLL;
using Model;
using Model.Code;

namespace API_NguoiDung.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class HomeController : ControllerBase
    {
        private ISachBLL _sachBusiness;
        private IHomeBLL _homeBLL;
        private ILoaispBLL _loaispBusiness;
        public HomeController(ILoaispBLL loaispBusiness, ISachBLL sachBusiness, IHomeBLL homeBLL)
        {
            _loaispBusiness = loaispBusiness;
            _sachBusiness = sachBusiness;
            _homeBLL = homeBLL;
        }
        [Route("get-all-data-loaisp/{sl}")]
        [HttpGet]
        public List<LoaispModel> ListLoaiSp(int sl)
        {
            
            return _loaispBusiness.GetAll(sl);
        }
        //[Route("get-all-data-sach")]
        //[HttpGet]
        //public List<SachModel> GetAll()
        //{
        //    return _sachBusiness.GetAll();
        //}
        [Route("get-data-sach-by-tacgia/{id}")]
        [HttpGet]
        public List<SachModel> GetByTg(int id)
        {
            return _homeBLL.GetByTg(id);
        }
        [Route("get-data-sach-by-nhasx/{id}")]
        [HttpGet]
        public List<SachModel> GetByNhasx(int id)
        {
            return _homeBLL.GetByNhasx(id);
        }
        [Route("get-data-sach-by-id/{id}")]
        [HttpGet]
        public sachHienthi GetById(int id)
        {
            return _sachBusiness.GetById(id);
        }
        [Route("sach-cung-tacgia/{id}/{soluong}")]
        [HttpGet]
        public List<SachModel> SachCungTacGia(int id, int soluong)
        {
            return _homeBLL.SachCungTacGia(id, soluong);
        }
        //[Route("get-loaisp-by-danhmuc/{id}")]
        //[HttpGet]
        //public List<LoaispModel> GetLoaiSpByDanhMuc(int id)
        //{
        //    return _homeBLL.GetLoaiSpByDanhMuc(id);
        //}
        [Route("get-danhmuc/{soluong}")]
        [HttpGet]
        public List<DanhMucModel> GetDanhMuc(int soluong)
        {
            return _homeBLL.GetDanhMuc(soluong);
        }
        [Route("get-all-sanphammoi/{soluong}")]
        [HttpGet]
        public List<SachModel> sanphammoi(int soluong)
        {
            return _homeBLL.sanphammoi(soluong);
        }
        [Route("get-all-banchay/{soluong}")]
        [HttpGet]
        public List<banchay> banchay(int soluong)
        {
            return _homeBLL.banchay(soluong);
        }
        [Route("get-sanpham-by-loai/{ten}/{soluong}")]
        [HttpGet]
        public List<SachModel> GetSpByLoai(int ten, int soluong)
        {
            return _homeBLL.GetSpByLoai(soluong, ten);
        }
        //[Route("get-sanpham-by-loaisp")]
        //[HttpGet]
        //public List<SachModel> GetByLoaiSp(int id)
        //{
        //    return _homeBLL.GetByLoaiSp(id);
        //}

        [Route("timkiem-sanpham-theo-ten/{ten}")]
        [HttpGet]
        public List<SachModel> TimKiem(string ten)
        {
            return _homeBLL.TimKiem(ten);
        }
    }
}
