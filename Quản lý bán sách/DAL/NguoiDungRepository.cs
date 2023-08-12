using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL.Interface;
using DAL.Helper;
using Model.Code;
using System.Security.Claims;

namespace DAL
{
    public class NguoiDungRepository:INguoiDungRepository
    {
        private IDatabaseHelper _dbHelper;
        public NguoiDungRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public ThongTinNhanVien Authenticate(string taikhoans, string matkhau)
        {

            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_user_get_data", "@taikhoan", taikhoans, "@matkhau", matkhau);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<ThongTinNhanVien>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<ThongTinNhanVien> TimKiem(string ten)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_nguoidung_timkiem", "@string", ten);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<ThongTinNhanVien>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ThongTinNhanVien> GetAll(int soluong)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_nguoidung_get_all_data", "@SoLuong", soluong);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<ThongTinNhanVien>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public NguoiDung GetById(int id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_nguoidung_get_by_id",
                     "@MaNguoiDung", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<NguoiDung>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete(int id)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_nguoidung_delete_by_id",
                "@MaNguoiDung", id);
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
        public bool Create(ThongTinNhanVien model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_nguoidung_create",
                "@HoTen", model.hoTen, "@NgaySinh", model.ngaySinh, "@GioiTinh", model.gioiTinh, "@DiaChi", model.diaChi, "@Email", model.email, "@SDT", model.sdt,
                "@TaiKhoan", model.taiKhoan, "@MatKhau", model.matKhau, "@TrangThai", model.trangThai, "@LoaiQuyen", model.loaiQuyen);

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


        public bool Update(ThongTinNhanVien model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_nguoidung_update", "@maNguoiDung", model.maNguoiDung,
               "@HoTen", model.hoTen, "@NgaySinh", model.ngaySinh, "@GioiTinh", model.gioiTinh, "@DiaChi", model.diaChi, "@Email", model.email, "@SDT", model.sdt,
               "@TaiKhoan", model.taiKhoan, "@MatKhau", model.matKhau, "@TrangThai", model.trangThai, "@LoaiQuyen", model.loaiQuyen);

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
    }
}
