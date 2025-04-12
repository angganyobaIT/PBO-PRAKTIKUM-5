using System;

namespace PBO_PR5
{
    public class Karyawan
    {
        private string _nama;
        private string _id;
        private double _gajiPokok;

        public string Nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public double Gaji_pokok
        {
            get { return _gajiPokok; }
            set { _gajiPokok = value; }
        }

        public virtual double HitungGaji()
        {
            return Gaji_pokok;
        }

        public virtual void TampilkanInfo()
        {
            Console.WriteLine("\n=== Informasi Penerimaan Gaji Karyawan ===");
            Console.WriteLine($"Nama       : {Nama}");
            Console.WriteLine($"ID         : {Id}");
            Console.WriteLine($"Gaji Akhir : {HitungGaji()}");
        }
    }
}
