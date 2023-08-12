using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace BLL.Interface
{
    public interface ISachBLL
    {
        bool Create(SachModel model);
        bool Update(SachModel model);
        bool Delete(int id);
        sachHienthi GetById(int id);
        List<sachHienthi> GetAll();
        List<sachHienthi> TimKiem(string ten);
        bool CreateSanPham(SanPham model);
    }
}
