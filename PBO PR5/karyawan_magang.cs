using System;

namespace PBO_PR5
{
    public class karyawan_magang : Karyawan
    {
        // Ga ada bonus atau potongan
        public override double HitungGaji()
        {
            return Gaji_pokok; 
        }
    }
}
