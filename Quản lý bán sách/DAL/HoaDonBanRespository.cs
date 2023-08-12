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

namespace DAL
{
    public class HoaDonBanRepository : IHoaDonBanRespository
    {
        private IDatabaseHelper _dbHelper;
        public HoaDonBanRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public bool DeleteChiTiet(int id)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "[sp_chitiethoadonban_delete_by_id]",
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
        public bool DeleteHoaDon(int id)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "[sp_hoadonban_delete_by_id]",
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
        public bool UpdateHoaDon(HoaDonBanModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "[sp_hoadonban_update]", "@SoHoaDon", model.SoHoaDon, "@NgayBan", model.NgayBan, "@MaKhachHang", model.MaKhachHang);

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
        public bool UpdateChiTiet(ChiTetHoaDonBanModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_chitiethoadonban_update", "@MaChiTietHoaDonBan", model.MaChiTietHoaDonBan, "@sanp_id", model.sanp_id, "@SoLuong", model.SoLuong, "@GiaBan", model.GiaBan, "@SoHoaDon", model.SoHoaDon);

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
        public bool CreateHoaDon(HoaDonBanModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "[sp_hoadonban_create]", "@NgayBan", model.NgayBan, "@MaKhachHang", model.MaKhachHang);

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
        public List<HienThiHoaDonBan> GetAll(int soluong)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_hoadonban_get_all_data", "@SoLuong", soluong);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<HienThiHoaDonBan>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<ChiTietHoaDonBan> getChiTiet(int ma)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_hoadonban_chitiet_id", "@ma", ma);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<ChiTietHoaDonBan>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<hoadonbanmd> hoadonban(int ma)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_hoadonban_all", "@ma", ma);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<hoadonbanmd>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public getHoaDon getHoaDon(int ma)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_hoadonban_id", "@ma", ma);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<getHoaDon>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<HienThiHoaDonBan> TimKiem(string soluong)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "[sp_hoadonban_timkiem]", "@ma", soluong);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<HienThiHoaDonBan>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public bool CreateChiTiet(ChiTetHoaDonBanModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "[sp_chitiethoadonban_create]", "@SoHoaDon", model.SoHoaDon, "@sanp_id", model.sanp_id, "@SoLuong", model.SoLuong, "@GiaBan", model.GiaBan);

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
