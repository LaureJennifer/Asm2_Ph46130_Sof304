using asm2.BLL.Services;
using asm2.DAL.Context;
using asm2.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2.DAL.Repositories
{
    public class LoaiXeMayRepository
    {
        DBContext _db= new DBContext();

        public List<LoaiXm> GetAll()
        {
            return _db.LoaiXms.ToList();
        }

    }
}
