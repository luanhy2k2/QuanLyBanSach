using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Code;

namespace DAL.Interface
{
    public partial interface INguoiDungRepository
    {
        bool Create(ThongTinNhanVien model);
        ThongTinNhanVien Authenticate(string taikhoans, string matkhau);
        bool Update(ThongTinNhanVien model);
        bool Delete(int id);
        NguoiDung GetById(int id);
        List<ThongTinNhanVien> TimKiem(string ten);
        List<ThongTinNhanVien> GetAll(int soluong);
    }
}
