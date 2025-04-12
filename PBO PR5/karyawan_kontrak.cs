using System;

namespace PBO_PR5
{
    public class karyawan_kontrak : Karyawan
    {
        public int potongan_Kontrak = 200000;

        public override double HitungGaji()
        {
            return Gaji_pokok - potongan_Kontrak;
        }
        
    }
}
