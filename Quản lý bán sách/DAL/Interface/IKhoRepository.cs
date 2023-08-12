using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Code;

namespace DAL.Interface
{
    public partial interface IKhoRepository
    {
        bool Create(khoedit model);
        bool Update(khoedit model);
        bool Delete(int id);
        khoedit GetById(int id);
        List<khoedit> GetAll();
        List<khoedit> TimKiem(int ten);
    }
}
