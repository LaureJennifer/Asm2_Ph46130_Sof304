using asm2.DAL.Context;
using asm2.DAL.DomainClass;
using asm2.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2.BLL.Services
{
    public class LoaiXeServices
    {
        LoaiXeMayRepository _loaiXerepository = new LoaiXeMayRepository();
        public List<LoaiXm> GetAll()
        {
            return _loaiXerepository.GetAll();
        }
    }
}
