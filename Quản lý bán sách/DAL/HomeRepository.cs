using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL.Interface;
using DAL.Helper;
using Model.Code;

namespace DAL
{
    public class HomeRepository:IHomeRepository
    {
        private IDatabaseHelper _dbHelper;
        public HomeRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public List<SachModel> sanphammoi(int soluong)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_sanphammoitaiban_get_all_data", "@SoLuong", soluong);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<SachModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<SachModel> GetByTg(int id)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_home_get_sanpham_by_tacgia", "@matacgia", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<SachModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<SachModel> GetByNhasx(int id)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_home_get_sanpham_by_nhasx", "@matacgia", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<SachModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<SachModel> GetByLoaisp(int id)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_home_get_sanpham_by_loáip", "@MaLoaisp", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<SachModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<SachModel> SachCungTacGia(int id, int soluong)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_home_sach_cungtacgia", "@MaTacGia", id, "@SoLuong", soluong);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<SachModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<LoaispModel> GetLoaiSpByDanhMuc(int id)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_home_get_loaisp_by_danhmuc", "@MaDanhMuc", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<LoaispModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<DanhMucModel> GetDanhMuc(int soluong)
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
        public List<banchay> banchay(int soluong)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_banchay_get_by_id", "@SoLuong", soluong);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<banchay>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<SachModel> GetSpByLoai(int ten, int soluong)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_home_getsp_by_loai", "@SoLuong", soluong, "@Ten", ten);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<SachModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<SachModel> TimKiem(string ten)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_home_timkiem_sanpham", "@string", ten);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<SachModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
