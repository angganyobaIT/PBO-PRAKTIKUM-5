using System;

namespace PBO_PR5
{
    public class KaryawanKontrak : Karyawan
    {
        private int potongan_Kontrak = 200000;

        public override double HitungGaji()
        {
            return Gaji_pokok - potongan_Kontrak;
        }
        
    }
}
