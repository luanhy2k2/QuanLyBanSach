using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL.Helper;
using DAL.Interface;
namespace DAL
{
    public class TaiKhoanRepository : ITaiKhoanRepository
    {
        private IDatabaseHelper _databaseHelper;
        public TaiKhoanRepository(IDatabaseHelper _dbhelper)
        {
            _databaseHelper = _dbhelper;
        }
        public List<TaiKhoan> GetAll()
        {
            string msgErorr = "";
            try
            {
                var dt = _databaseHelper.ExecuteSProcedureReturnDataTable(out msgErorr, "sp_taikhoan_get_all_data");
                if(!string.IsNullOrEmpty(msgErorr))
                    throw new Exception(msgErorr);
                return dt.ConvertTo<TaiKhoan>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TaiKhoan GetById(int id)
        {
            
            string msgErorr = "";
            try
            {
                var dt = _databaseHelper.ExecuteSProcedureReturnDataTable(out msgErorr, "sp_taikhoan_get_by_id", "@MaTaiKhoan", id);
                if(!string.IsNullOrEmpty(msgErorr))
                    throw new Exception(msgErorr);
                return dt.ConvertTo<TaiKhoan>().FirstOrDefault();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool Create(TaiKhoan model)
        {
            string msgError = "";
            try
            {
                var result = _databaseHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_create_create",
                "@MaNguoiDung", model.MaNguoiDung, "@TaiKhoan", model.taiKhoan, "@MatKhau", model.matKhau, "@NgayBatDau", model.NgayBatDau, "@NgayKetThuc", model.NgayKetThuc,"@TrangThai", model.TrangThai, "@LoaiQuyen", model.LoaiQuyen);

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
        public bool Delete(int id)
        {
            string msgError = "";
            try
            {
                var result = _databaseHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_taikhoan_delete_by_id",
                "@MaTaiKhoan", id);
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
        public bool Update(TaiKhoan model)
        {
            string msgError = "";
            try
            {
                var result = _databaseHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_taikhoan_update", @"MaTaiKhoan", model.MaTaiKhoan,
                "@MaNguoiDung", model.MaNguoiDung, "@TaiKhoan", model.taiKhoan, "@MatKhau", model.matKhau, "@NgayBatDau", model.NgayBatDau, "@NgayKetThuc", model.NgayKetThuc, "@TrangThai", model.TrangThai, "@LoaiQuyen", model.LoaiQuyen);
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
