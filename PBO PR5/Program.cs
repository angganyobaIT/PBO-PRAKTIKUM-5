
using System;

namespace PBO_PR5
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan();
            karyawan.TambahNama("SUTATANG");
            Console.WriteLine(karyawan.Nama); // Menampilkan nama dengan getter
        }
    }

    public class Karyawan
    {
        //public string jenis;
        private string _nama;
        private string _id;
        private double _gajiPokok;

        // Public property untuk Nama
        public string Nama
        {
            get { return this._nama; } // Getter
            //set { this._nama = value; } // Setter
        }

        // Method untuk menambahkan nama
        public void TambahNama(string nama)
        {
            this._nama = nama; // Mengatur nama melalui field langsung
            Console.WriteLine($"Nama telah ditambahkan: {nama}");
        }
    }
}


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
    
