using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL.Interface;
namespace BLL.Interface
{
    public interface ITaiKhoanBLL
    {
        bool Create(TaiKhoan model);
        bool Update(TaiKhoan model);
        bool Delete(int id);
        TaiKhoan GetById(int id);
        List<TaiKhoan> GetAll();
    }
}
