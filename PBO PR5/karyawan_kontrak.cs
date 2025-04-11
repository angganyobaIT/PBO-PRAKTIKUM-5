using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_PR5
{
    public class KaryawanKontrak : Karyawan
    {
        private int potonganKontrak = 200000;

        public override double HitungGaji()
        {
            return GajiPokok - potonganKontrak;
        }
        //public void TampilkanInfo()
        //{

        //}
    }
}
