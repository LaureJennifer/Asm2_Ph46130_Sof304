using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bai2
{
    public class SinhVienPoly
    {
        List<SinhVien> _sinhVienPolys = new List<SinhVien>();
        public bool Add(SinhVien sinhvien)
        {
            _sinhVienPolys.Add(sinhvien);
            return true;

        }
        public void Update(string id,SinhVien sinhvien)
        {
            var obj = _sinhVienPolys.FirstOrDefault(x => x.Id == id);
            if (obj != null) 
            {
                obj.TenLop = sinhvien.TenLop;
                obj.MaLop = sinhvien.MaLop;
                obj.HoTen = sinhvien.HoTen;
                obj.MaSV = sinhvien.MaSV;
            }

        }
        public void Delete(string id)
        {
            var obj = _sinhVienPolys.FirstOrDefault(x => x.Id == id);
            if (obj != null)
            {
                _sinhVienPolys.Remove(obj);
            }

        }
        public SinhVien? FindByname(string hoTen)
        {
            var obj = _sinhVienPolys.FirstOrDefault(x => x.HoTen.ToLower() == hoTen.ToLower());
            return obj;

        }
        public SinhVien? FindByMaLop(string maLop)
        {
            var obj = _sinhVienPolys.FirstOrDefault(x => x.MaLop.ToLower() == maLop.ToLower());
            return obj;

        }
        
    }
}
