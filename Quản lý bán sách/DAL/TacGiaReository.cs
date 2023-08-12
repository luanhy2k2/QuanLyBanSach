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
    public class TacGiaReository: ITacGiaRepository
    {
        private IDatabaseHelper _dbHelper;
        public TacGiaReository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public List<TacGiaModel> TimKiem(string ten)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_tacgia_timkiem", "@string", ten);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<TacGiaModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<TacGiaModel> GetAll(int soluong)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_tacgia_get_all_data", "@SoLuong", soluong);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<TacGiaModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public TacGiaModel GetById(int id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_tacgia_get_by_id",
                     "@MaTacGia", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<TacGiaModel>().FirstOrDefault();
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
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_tacgia_delete_by_id",
                "@MaTacGia", id);
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
        public bool Create(TacGiaModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_tacgia_create",
                "@TenTacGia", model.TG_name, "@Diachi", model.TG_diachi, "@sdt", model.sdt);

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

        public bool Update(TacGiaModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_tacgia_update",
                "@MaTacGia", model.TG_id,
                "@TenTacGia", model.TG_name,
                "@Diachi", model.TG_diachi,
                "@sdt", model.sdt);
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
