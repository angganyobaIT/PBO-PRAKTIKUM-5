using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_PR5
{
    public class karyawan_magang : Karyawan
    {
        public override double HitungGaji()
        {
            return GajiPokok; // Tidak ada bonus atau potongan
        }
        //public virtual void TampilkanInfo()
        //{

        //}
    }
}
