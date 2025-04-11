
//using System;
//using System.Linq.Expressions;
//using System.Runtime.InteropServices;
//using System.Security.Cryptography.X509Certificates;
//using System.Security.Policy;

//namespace PBO_PR5
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Karyawan karyawan = new Karyawan();

//            Console.Write("Masukkan nama karyawan :");
//            karyawan.tambah_nama(Console.ReadLine());
//            Console.WriteLine(karyawan.Nama);

//            Console.Write("Masukkan id karyawan :");
//            karyawan.tambah_id(Console.ReadLine());
//            Console.WriteLine(karyawan.Id);

//            //karyawan.jenis_karyawan = Console.ReadLine();
//            //Console.Write("Masukkan jenis karyawan :");
//            //karyawan.jeniskaryawan = Console.ReadLine();

//            Console.Write("Masukkan gaji karyawan :");
//            karyawan.gaji_pokok(int.Parse(Console.ReadLine()));
//            Console.WriteLine(karyawan.GajiPokok);


//        }

//        public class Karyawan
//        {
//            //public string jenis;
//            public string jenis_karyawan;
//            private string _nama;
//            private string _id;
//            private double _gajiPokok;


//            public string Nama
//            {
//                get { return this._nama; }
//                set { this._nama = value; } // Setter
//            }
//            // Public property untuk 
//            public string Id
//            {
//                get { return this._id; }
//                set
//                {
//                    if (Id.ToLower() == "ktr")
//                    {
//                        karyawan_kontrak karyawankontrak = new karyawan_kontrak();
//                    }
//                } // Setter
//            }

//            // Public property untuk Gaji Pokok
//            public double GajiPokok
//            {
//                get { return this._gajiPokok; }
//                set { this._gajiPokok = value; } // Setter
//            }

//            public void tambah_nama(string nama)  // METHOD YANG DIGUNAKAN UNTUK TAMBAH NAMA
//            {
//                this._nama = nama; // Mengatur nama melalui field langsung
//                Console.WriteLine($"Nama telah ditambahkan: {nama}");
//            }
//            public void tambah_id(string id) // METHOD YANG DIGUNAKAN UNTUK TAMBAH ID
//            {
//                this._id = id; // Mengatur ID melalui field langsung
//                Console.WriteLine($"ID telah ditambahkan: {id}");
//            }
//            public void gaji_pokok(double gajiPokok) // METHOD YANG DIGUNAKAN UNTUK TAMBAH GAJI POKOK 
//            {
//                this._gajiPokok = gajiPokok; // Mengatur gaji pokok melalui field langsung
//                Console.WriteLine($"Gaji pokok telah ditambahkan: {gajiPokok}");
//            }

//            public virtual void gajiakhir(double gajipokok) // METHOD YANG FUNGSINYA MENJADI TEMPAT OVERRIDE SEMUA CLASS
//            {
//                Console.WriteLine($"{Nama} merupakan pegawai ");
//            }


//            class karyawan_tetap : Karyawan
//            {
//                public int gaji;
//                public int bonus = 500000;

//                public override void gajiakhir(double gajipokok)
//                {
//                    gajipokok += bonus;

//                }
//            }

//            class karyawan_kontrak : Karyawan
//            {
//                int potongan_kontrak = 200000;
//                public override void gajiakhir(double gajipokok)
//                {
//                    gajipokok -= potongan_kontrak;

//                }
//            }
//            class karyawan_magang : Karyawan
//            {
//                public override void gajiakhir(double gajipokok)
//                {
//                    Console.WriteLine();
//                }
//            }


//        }
//    }
//}




//using System;

//namespace PBO_PR5
//{
//    class Program
//    {
//        static void Main()
//        {
//            Karyawan karyawan = new Karyawan();

//            Console.Write("Masukkan nama karyawan: ");
//            karyawan.Nama = Console.ReadLine();

//            Console.Write("Masukkan ID karyawan (ktr/tetap/magang): ");
//            karyawan.Id = Console.ReadLine();

//            Console.Write("Masukkan gaji pokok: ");
//            karyawan.GajiPokok = Convert.ToDouble(Console.ReadLine());

//            // Menentukan jenis karyawan berdasarkan ID
//            if (karyawan.Id.ToLower() == "ktr")
//            {
//                karyawan = new KaryawanKontrak();
//                public void TampilkanInfo();
//            }
//            else if (karyawan.Id.ToLower() == "tetap")
//            {
//                karyawan = new KaryawanTetap();
//                public void TampilkanInfo();

//            }
//            else if (karyawan.Id.ToLower() == "magang")
//            {
//                karyawan = new KaryawanMagang();
//                public void TampilkanInfo();
//            }

//        }
//    }

//    public class Karyawan
//    {
//        private string _nama;
//        private string _id;
//        private double _gajiPokok;

//        // Menggunakan getter dan setter agar tetap bisa diakses
//        public string Nama
//        {
//            get { return _nama; }
//            set { _nama = value; }
//        }

//        public string Id
//        {
//            get { return _id; }
//            set { _id = value; }
//        }

//        public double GajiPokok
//        {
//            get { return _gajiPokok; }
//            set { _gajiPokok = value; }
//        }

//    //public virtual string namapegawai()
//    //{
//    //    return _nama;
//    //}
//    public string inputnama()
//    {
//        return Nama;
//    }

//    public string inputid()
//    {
//        return Id;
//    }
//    public virtual double HitungGaji()
//    {
//        return GajiPokok;
//    }

//    }

//    public class KaryawanTetap : Karyawan
//    {
//        public int bonusTetap = 500000;

//        public override double HitungGaji()
//        {
//            return GajiPokok + bonusTetap;
//        }

//        public void TampilkanInfo()
//        {
//            Console.WriteLine("\n=== Informasi Karyawan ===");
//            Console.WriteLine($"Nama       : {inputnama()}");
//            Console.WriteLine($"ID         : {inputid()}");
//            Console.WriteLine($"Gaji Akhir : {HitungGaji()}");
//        }
//    }

//    public class KaryawanKontrak : Karyawan
//    {
//        private int potonganKontrak = 200000;

//        public override double HitungGaji()
//        {
//            return GajiPokok - potonganKontrak;
//        }

//        public void TampilkanInfo()
//        {
//            Console.WriteLine("\n=== Informasi Karyawan ===");
//            Console.WriteLine($"Nama       : {inputnama()}");
//            Console.WriteLine($"ID         : {inputid()}");
//            Console.WriteLine($"Gaji Akhir : {HitungGaji()}");
//        }
//    }

//    public class KaryawanMagang : Karyawan
//    {
//        public override double HitungGaji()
//        {
//            return GajiPokok; // Tidak ada bonus atau potongan
//        }
//        public void TampilkanInfo()
//        {
//            Console.WriteLine("\n=== Informasi Karyawan ===");
//            Console.WriteLine($"Nama       : {inputnama()}");
//            Console.WriteLine($"ID         : {inputid()}");
//            Console.WriteLine($"Gaji Akhir : {HitungGaji()}");
//        }
//    }
//}   


using System;

namespace PBO_PR5
{
    class Program
    {
        static void Main()
        {
            Karyawan karyawan = null; // Inisialisasi karyawan sebagai null

            Console.Write("Masukkan nama karyawan: ");
            string nama = Console.ReadLine();

            Console.Write("Masukkan ID karyawan (ktr/ttp/mgg): ");
            string id = Console.ReadLine();

            Console.Write("Masukkan gaji pokok: ");
            double gajiPokok = Convert.ToDouble(Console.ReadLine());

            // Menentukan jenis karyawan berdasarkan ID
            if (id.ToLower() == "ktr")
            {
                karyawan = new KaryawanKontrak();
                Console.WriteLine("Karyawan Kontrak");
            }
            else if (id.ToLower() == "ttp")
            {
                karyawan = new KaryawanTetap();
                Console.WriteLine("Karyawan Tetap");
            }
            else if (id.ToLower() == "mgg")
            {
                karyawan = new KaryawanMagang();
            }

            // Set properti karyawan
            if (karyawan != null)
            {
                karyawan.Nama = nama;
                karyawan.Id = id;
                karyawan.GajiPokok = gajiPokok;

                // Tampilkan informasi karyawan
                karyawan.TampilkanInfo();
            }
            else
            {
                Console.WriteLine("ID karyawan tidak valid.");
            }
        }
    }

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

        public double GajiPokok
        {
            get { return _gajiPokok; }
            set { _gajiPokok = value; }
        }

        public virtual double HitungGaji()
        {
            return GajiPokok;
        }

        public virtual void TampilkanInfo()
        {
            Console.WriteLine("\n=== Informasi Karyawan ===");
            Console.WriteLine($"Nama       : {Nama}");
            Console.WriteLine($"ID         : {Id}");
            Console.WriteLine($"Gaji Akhir : {HitungGaji()}");
        }
    }

    public class KaryawanTetap : Karyawan
    {
        private int bonusTetap = 500000;

        public override double HitungGaji()
        {
            return GajiPokok + bonusTetap;
        }
        public void TampilkanInfo()
        {
        }
    }


    public class KaryawanKontrak : Karyawan
    {
        private int potonganKontrak = 200000;

        public override double HitungGaji()
        {
            return GajiPokok - potonganKontrak;
        }
        public void TampilkanInfo()
        {
            
        }
    }

    public class KaryawanMagang : Karyawan
    {
        public override double HitungGaji()
        {
            return GajiPokok; // Tidak ada bonus atau potongan
        }
        public virtual void TampilkanInfo()
        {
            
        }
    }
}






//class karyawan_kontrak
//{
//}
//class karyawan_magang
//{
//}

//public class Karyawan
//{
//    private string _nama;
//    private string _id;
//    private double _gaji;
//    public string inputuser;

//    public string nama
//    {
//        get { return (_nama); }
//        set { _nama = value; }


//    }

//    public string id
//    {
//        get { return (_id); }
//        set { _id = value; }
//    }
//    public double gaji
//    {
//        get { return (_gaji); }
//        set { _gaji = value; }
//    }




//    //public double gaji
//    //{
//    //    get { return gaji; }
//    //    set { gaji = value; }

//    //}
//}
//public class karyawantetap
//    {
//        public int bonus = 500000;
//        public int gaji_akhir;
//        public double gaji
//        {
//            //Console.WriteLine()
//            get { return (gaji + bonus + gaji_akhir); }
//            set { gaji_akhir = gaji += bonus; }
//        }
//        public void gajiakhir()
//        {
//            get{ }
//            Console.WriteLine("Total gaji akhir karyawan tetap sebesar");
//        }
//    }
//public class karyawankontrak
//    {

//    }
//public class karyawanmagang
//    {

//    }


//public decimal hitunggaji(_gaji)
//{
//    get{ return Console.ReadLine() }
//    //Console.WriteLine(gaji);
//    //}
//}

//    class Karyawankontrak : Karyawan
//{

//    public (string nama, string id, double _gaji) :base (nama, id, _gaji)
//}

