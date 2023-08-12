using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL.Interface
{
    public partial interface IGiaSachRepository
    {
        GiaCaModel GetById(int id);
        bool Create(GiaCaModel model);
        bool Update(GiaCaModel model);
        bool Delete(int id);
        List<GiaCaModel> GetAll();
    }
}
