
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
    public class HoaDonNhapRepository:IHoaDonNhapRepository
    {
        private IDatabaseHelper _dbHelper;
        public HoaDonNhapRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public hienThiHoaDonNhap GetById(int id)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_hoadonnhap_get_by_id",
                     "@SoHoaDon", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<hienThiHoaDonNhap>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public getHoaDonNhap getHoaDonNhap(int id)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_hoadonnhap_id",
                     "@ma", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<getHoaDonNhap>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<hienThiHoaDonNhap> TimKiem(int ten)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_hoadonnhap_timkiem", "@string", ten);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<hienThiHoaDonNhap>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<hoadonnhap> HoaDonNhap(int ten)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_hoadonnhap_all", "@ma", ten);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<hoadonnhap>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<getChiTietHoaDonNhap> getChiTietHoaDonNhap(int ten)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_hoadonnhap_chitiet_id", "@ma", ten);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<getChiTietHoaDonNhap>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<hienThiHoaDonNhap> GetAll(int soluong)
        {
            string msgError = "";

            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_hoadonnhap_get_all_data", "@SoLuong", soluong);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);

                return dt.ConvertTo<hienThiHoaDonNhap>().ToList();
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
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_hoadonnhap_delete_by_id",
                "@SoHoaDon", id);
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
        public bool Create(hoadonnhapss model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_hoadonnhap_create",
                "@MaNguoiDung", model.hoadonnhap.MaNguoiDung, "@nsx_id", model.hoadonnhap.nsx_id,
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
        public bool taomoi(hdnmodel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_hoadonnhap_tao",
                //"@loai_id", model.loai_id,
                "@MaNguoiDung", model.maNguoiDung, "@nsx_id", model.nsx_id, "@sanp_id", model.sanp_id, "@SoLuong", model.soLuong, "@DonGia", model.donGia);
                
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

        public bool taoChiTiet(ChiTietHoaDonNhapModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_chitiethoadonnhap_create",
                //"@loai_id", model.loai_id,
                "@soHoaDon", model.soHoaDon, "@sanp_id", model.sanp_id, "@soLuong", model.soLuong, "@donGia", model.donGia);

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
        public bool Update(edithdnmodel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_hoadonnhap_update", "@SoHoaDon", model.soHoaDon,
                //"@loai_id", model.loai_id,
                "@MaNguoiDung", model.maNguoiDung, "@NgayNhap", model.ngayNhap, "@nsx_id", model.nsx_id, "@sanp_id", model.sanp_id, "@SoLuong", model.soLuong, "@DonGia", model.donGia);

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
