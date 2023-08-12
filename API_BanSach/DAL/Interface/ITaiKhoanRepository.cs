using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL.Interface
{
    public partial interface ITaiKhoanRepository
    {
        TaiKhoan GetById(int id);
        bool Create(TaiKhoan model);
        bool Update(TaiKhoan model);
        bool Delete(int id);
        List<TaiKhoan> GetAll();
    }
}
