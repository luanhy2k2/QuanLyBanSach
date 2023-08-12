using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL.Interface;
using DAL.Helper;
namespace DAL
{
    public partial class DanhMucRepository: IDanhMucRepository
    {
        private IDatabaseHelper _dbHelper;
        public DanhMucRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public List<DanhMucModel> GetAll(int soluong)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_danhmuc_get_all_data", "@SoLuong", soluong);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<DanhMucModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DanhMucModel GetDatabyID(int id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_danhmuc_get_by_id",
                     "@MaDanhMuc", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<DanhMucModel>().FirstOrDefault();
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
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_danhmuc_delete_by_id",
                "@MaDanhMuc", id);
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
        public List<DanhMucModel> Search(int pageIndex, int pageSize, out long total, string tenDanhMuc)
        {
            string msgError = "";
            total = 0;
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_danhmuc_search",
                    "@page_index", pageIndex,
                    "@page_size", pageSize,
                    "@tendanhmuc", tenDanhMuc
                  );
                if (!string.IsNullOrEmpty(msgError)) throw new Exception(msgError);

                if (dt.Rows.Count > 0) { total = (long)dt.Rows[0]["RecordCount"]; }

                return dt.ConvertTo<DanhMucModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Create(DanhMucModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_danhmuc_create",
                "@TenDanhMuc", model.tenDanhMuc);
               
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

        public bool Update(DanhMucModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_danhmuc_update",
                "@MaDanhMuc", model.maDanhMuc,
                "@TenDanhMuc", model.tenDanhMuc);
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
