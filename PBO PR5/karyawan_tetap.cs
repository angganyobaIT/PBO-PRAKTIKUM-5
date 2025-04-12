using System;

namespace PBO_PR5
{
    public class karyawan_tetap : Karyawan
    {
        public int bonus_tetap = 500000;
        public override double HitungGaji()
        {
            return Gaji_pokok + bonus_tetap;
        }   
    }
}
