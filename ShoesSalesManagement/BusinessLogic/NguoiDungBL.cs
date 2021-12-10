using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class NguoiDungBL
    {
        NguoiDungDA nguoiDungDA = new NguoiDungDA();

        public List<NguoiDung> GetAll()
        {
            return nguoiDungDA.GetAll();
        }
    }
}
