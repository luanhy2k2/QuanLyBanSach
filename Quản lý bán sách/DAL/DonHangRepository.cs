using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL.Helper;
using Model.Code;
using DAL.Interface;
using Microsoft.VisualBasic;
using System.Reflection;

namespace DAL
{
    public class DonHangRepository:IDonHangRepository
    {
        private IDatabaseHelper _dbHelper;
        public DonHangRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public bool DeleteChiTiet(int id)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "[sp_chitietdonhang_delete_by_id]",
                "@ma", id);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeleteDonHang(int id)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "[sp_donhang_delete_by_id]",
                "@ma", id);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateDonHang(DonHangModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_donhang_update", "@maDonHang", model.MaDonHang, "@maKhachHang", model.MaKhachHang,
                    "@ngayDat", model.NgayDat, "@trangThai", model.TrangThai);

                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool CreateDonHang(DonHangModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_donhang_create", "@maKhachHang", model.MaKhachHang,
                    "@ngayDat", model.NgayDat, "@trangThai", model.TrangThai);

                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<getdonhang> DonHang(int soluong)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "[sp_getdonhang]", "@ma", soluong);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<getdonhang>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<hienthiDonHang> GetAll(int soluong)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "[sp_donhang_get_all_data]", "@soluong", soluong);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<hienthiDonHang>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
        public List<hienthiDonHang> TimKiem(string soluong)
        {
            string msgError = "";
           
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_donhang_timkiem", "@ma", soluong);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<hienthiDonHang>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<hienthiDonHang> TimKiemNguoiDung(string soluong)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_donhang_timkiem_nguoidung", "@ma", soluong);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<hienthiDonHang>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateChiTiet(ChiTietDonHang model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_chitietdonhang_update", "@maChiTietDonHang", model.MaChiTietDonHang, "@maDonHang", model.MaDonHang,
                    "@sanp_id", model.sanp_id, "@soLuong", model.soLuong, "@gia", model.gia);

                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool CreateChiTiet(ChiTietDonHang model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_chitietdonhang_create", "@maDonHang", model.MaDonHang,
                    "@sanp_id", model.sanp_id, "@soLuong", model.soLuong, "@gia", model.gia);

                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Create(DonHang model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_donhang_create",
                "@khach", model.KhachHang != null ? MessageConvert.SerializeObject(model.KhachHang) : null,
                "@listchitiet", model.listchitiet != null ? MessageConvert.SerializeObject(model.listchitiet) : null);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool addHoaDon (addHoaDonBan model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "add_hoadonban", "@NgayBan", model.NgayBan,"@MaKhachHang",model.MaKhachHang, "@MaDonHang",model.MaDonHang,

                "@listchitietdonhang", model.listchitietdonhang != null ? MessageConvert.SerializeObject(model.listchitietdonhang) : null);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public getDonHang getDonHangById(int id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_getdonhang_byid",
                     "@ma", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<getDonHang>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<getChiTietDonhang> getChiTietDonHangById(int id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_getchitietdonhang_byid",
                     "@ma", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<getChiTietDonhang>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public GetByIdDonHang GetById(int id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_donhang_get_by_id",
                     "@MaDonHang", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<GetByIdDonHang>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public KhachHangModel getKhachHangById(int id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_donhang_data_khachhang_id",
                     "@ma", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<KhachHangModel>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ChiTiet> getChiTietById(int id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_donhang_data_chitiet_id",
                     "@ma", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<ChiTiet>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DonHang> Search(int pageIndex, int pageSize, out long total, string TenKhachHang, int SDT, string Email, DateTime fr_NgayDat, DateTime to_NgayDat, string option)
        {
            string msgError = "";
            total = 0;
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_donhang_search",
                    "@page_index", pageIndex,
                    "@page_size", pageSize,
                    "@TenKhachHang", TenKhachHang,
                    "@SoDienThoai", SDT,
                    "@Email", Email,
                    "@fr_NgayDat", fr_NgayDat,
                    "@to_NgayDat", to_NgayDat,
                    "@option", option
                   );
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                if (dt.Rows.Count > 0) total = (long)dt.Rows[0]["RecordCount"];
                return dt.ConvertTo<DonHang>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
