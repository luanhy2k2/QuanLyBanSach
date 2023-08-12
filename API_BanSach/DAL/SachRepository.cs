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
    public class SachRepository: ISachRepository
    {
        private IDatabaseHelper _dbHelper;
        public SachRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public sachHienthi GetDataById(int id)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_sanpham_get_by_id",
                     "@MaSanPham", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<sachHienthi>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<sachHienthi> TimKiem(string ten)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_sanphams_timkiem", "@string", ten);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<sachHienthi>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<sachHienthi> GetAll()
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_sanpham_get_all_data");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<sachHienthi>().ToList();
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
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_sanpham_delete_by_id",
                "@MaLoaisp", id);
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
        public bool Create(SachModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_sach_create",
                "@sanp_name", model.sanp_name, "@size", model.size, "@TG_id", model.TG_id, "@loai_id", model.loai_id, "@nsx_id", model.nsx_id,
                "@sotrang",  model.sotrang, "@tomtat", model.tomtat, "@namsx", model.namsx, "@image", model.image, "@gia", model.Gia);

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

        public bool Update(SachModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_sach_update", "@sanp_id", model.sanp_id,
                "@sanp_name", model.sanp_name, "@size", model.size, "@TG_id", model.TG_id, "@loai_id", model.loai_id, "@nsx_id", model.nsx_id,
                "@sotrang", model.sotrang, "@tomtat", model.tomtat, "@Image", model.image, "@namsx", model.namsx, "@gia", model.Gia);
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


        public bool CreateSanPham(SanPham model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_sanpham_create",
                "@sanp_name", model.sanp_name, "@size", model.size, "@TG_id", model.TG_id, "@loai_id", model.loai_id, "@nsx_id", model.nsx_id,
                "@sotrang", model.sotrang, "@tomtat", model.tomtat, "@namsx", model.namsx, "@Image", model.image, "@GiaCa", model.GiaCa, "@NgayBatDau", model.NgayBatDau, "@NgayKetThuc", model.NgayKetThuc,
                "@ListAnh", model.ListAnh != null ? MessageConvert.SerializeObject(model.ListAnh) : null);
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
