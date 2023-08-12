using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL.Interface
{
    public partial interface ILoaispRepository
    {
        bool Create(LoaispModel model);
        bool Update(LoaispModel model);
        bool Delete(int id);
        LoaispModel GetById(int id);
        List<LoaispModel> GetAll(int soluong);
        List<LoaispModel> TimKiem(string ten);
    }
}
