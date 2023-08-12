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
    public class NhaSanXuatRepository : INhaSanXuatRepository
    {
        private IDatabaseHelper _dbHelper;
        public NhaSanXuatRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public List<NhaSanXuatModel> TimKiem(string ten)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_nhasanxuat_timkiem", "@string", ten);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<NhaSanXuatModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public NhaSanXuatModel GetById(int id)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_nhasanxuat_get_by_id",
                     "@MaNhaSanXuat", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<NhaSanXuatModel>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<NhaSanXuatModel> GetAll(int soluong)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_nhasanxuat_get_all_data", "@SoLuong", soluong );
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<NhaSanXuatModel>().ToList();
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
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_nhasanxuat_delete_by_id",
                "@MaNhaSanXuat", id);
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
        public bool Create(NhaSanXuatModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_nhasanxuat_create",
                "@nsx_name", model.nsx_name, "@diachi", model.diachi, "@sdt", model.sdt);

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

        public bool Update(NhaSanXuatModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_nhasanxuat_update",
                "@nsx_name", model.nsx_name, "@diachi", model.diachi, "@sdt", model.sdt);
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
