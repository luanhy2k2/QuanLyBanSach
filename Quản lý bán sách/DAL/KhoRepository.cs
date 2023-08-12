using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Code;
using DAL.Interface;
using DAL.Helper;
namespace DAL
{
    public class KhoRepository: IKhoRepository
    {
        private IDatabaseHelper _dbHelper;
        public KhoRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public List<khoedit> TimKiem(int ten)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_kho_timkiem", "@string", ten);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<khoedit>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<khoedit> GetAll()
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_kho_get_all_data");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<khoedit>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public khoedit GetById(int id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_kho_get_by_id",
                     "@MaKho", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<khoedit>().FirstOrDefault();
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
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_kho_delete_by_id",
                "@MaKho", id);
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
        public bool Create(khoedit model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_kho_create",
                "@TenKho", model.TenKho, "@DiaChi", model.DiaChi, "@sanp_id", model.sanp_id, "@SoLuong", model.soLuong);

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

        public bool Update(khoedit model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_kho_update",
                "@MaKho", model.MaKho, "@TenKho", model.TenKho, "@DiaChi", model.DiaChi, "@sanp_id", model.sanp_id, "@SoLuong", model.soLuong);
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
