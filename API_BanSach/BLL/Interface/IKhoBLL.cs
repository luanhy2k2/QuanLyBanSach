using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Code;

namespace BLL.Interface
{
    public interface IKhoBLL
    {
        bool Create(khoedit model);
        bool Update(khoedit model);
        bool Delete(int id);
        khoedit GetById(int id);
        List<khoedit> TimKiem(int ten);
        List<khoedit> GetAll();
    }
    

}

