using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SachModel
    {
        public int sanp_id { get; set; }
        public string sanp_name { get; set; }
        
        public int Gia { get; set; }
        public string size { get; set; }
        public int TG_id { get; set; }
        public int loai_id { get; set; }
        public int nsx_id { get; set; }
        public int sotrang { get; set; }
        public string tomtat { get; set; }
        public DateTime namsx { get; set; }
        public string? image { get; set; }
      
        public string? Anh { get; set; }
    }
    public class sachHienthi
    {
        public int sanp_id { get; set; }
        public string sanp_name { get; set; }
        public string TG_name { get; set; }
        public string loai_name { get; set; }
        public string nsx_name { get; set; }
        public int Gia { get; set; }
        public string size { get; set; }
        public int TG_id { get; set; }
        public int loai_id { get; set; }
        public int nsx_id { get; set; }
        public int sotrang { get; set; }
        public string tomtat { get; set; }
        public DateTime namsx { get; set; }
        public string? image { get; set; }

        public string? Anh { get; set; }
    }
    public class ListAnh
    {
        public string Anh { get; set; }
    }
    public class SanPham
    {
        public int sanp_id { get; set; }
        public string sanp_name { get; set; }
        public string size { get; set; }
        public int TG_id { get; set; }
        public int loai_id { get; set; }
        public int nsx_id { get; set; }
        public int sotrang { get; set; }
        public string tomtat { get; set; }
        public DateTime namsx { get; set; }
        public string? image { get; set; }
        public int GiaCa { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public List<ListAnh> ListAnh { get; set; }
    }
}
