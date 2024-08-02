using asm2.DAL.Context;
using asm2.DAL.DomainClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2.DAL.Repositories
{
    public class XeMayRepository
    {
        DBContext _db= new DBContext();
        //Get All
        public List<LoaiXm> GetLoaiXe()
        {
            return _db.LoaiXms.ToList();
        }

        public List<XeMay> GetAll(string textSearch)
        {
            if (string.IsNullOrWhiteSpace(textSearch))
            {
                var listObj = _db.XeMays.ToList();

                return listObj;
            }
            else
            {
                var listObj = _db.XeMays.Where(x => x.Ten.Contains(textSearch)).ToList();

                return listObj;
            }


        }
        //Get By Id
        public XeMay? GetById(Guid id)
        {
            var obj = _db.XeMays.FirstOrDefault(x => x.Id == id);
            return obj;
        }
        //Add
        public bool Add(XeMay xeMay)
        {
            try
            {
                xeMay.Id = Guid.NewGuid();
                _db.Add(xeMay);
                _db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }


        //Delete
        public bool Delete(Guid id)
        {
            try
            {
                var obj = GetById(id);
                if (obj == null)
                {
                    return false;
                }

                _db.Remove(obj);
                _db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update(Guid id, XeMay xeMay)
        {
            try
            {
                var obj = GetById(id);
                if (obj == null)
                {
                    return false;
                }
                obj.Ma = xeMay.Ma;
                obj.Ten = xeMay.Ten;
                obj.GiaBan = xeMay.GiaBan;
                obj.IdLxm = xeMay.IdLxm;

                _db.XeMays.Update(obj);
                _db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool CheckDuplicateMaXe(string maXeMay)
        {
            var obj = _db.XeMays.FirstOrDefault(x => x.Ma == maXeMay);
            if (obj == null)
            {
                return false;
            }
            return true;
        }
        public bool ChecktypeGia(string GiaNhap)
        {

            try
            {
                if (Convert.ToDecimal(GiaNhap) != null)
                {
                    return true;
                }
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool checkValueGia(decimal giaNhap)
        {
            if (giaNhap > 0)
            {
                return true;
            }
            return false;
        }
        public bool CheckTenXe(string TenXeMay)
        {
            var obj = _db.XeMays.Any(x => x.Ten.Contains(TenXeMay.ToLower()));
            if (obj == false)
            {
                return false;
            }
            return true;
        }
    }
}

