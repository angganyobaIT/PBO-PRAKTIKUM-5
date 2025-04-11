using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_PR5
{
    public class karyawan_tetap : Karyawan
    {
        private int bonusTetap = 500000;

        public override double HitungGaji()
        {

            return GajiPokok + bonusTetap;

        }
        //public void TampilkanInfo()
        //{
        //}
    }

}
