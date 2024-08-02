using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class SinhVien
    {
        public SinhVien(string id, string maSV, string hoTen, string maLop, string tenLop)
        {
            Id = id;
            MaSV = maSV;
            HoTen = hoTen;
            MaLop = maLop;
            TenLop = tenLop;
        }

        public string Id { get; set; }
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string MaLop { get; set; }
        public string TenLop { get; set; }
       
    }
}
