using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Code
{
    public class kho
    {
        public KhoModel khomodel { get; set; }
        public ChiTietKhoModel ChiTietKhoModel { get; set; }
    }
    public class khoedit
    {
        public int MaKho { get; set; }
        public string TenKho { get; set; }
        public string DiaChi { get; set; }
        public int sanp_id { get; set; }
        public int soLuong { get; set; }
    }
}
