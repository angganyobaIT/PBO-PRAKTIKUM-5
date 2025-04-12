using System;

namespace PBO_PR5
{
    class Program
    {
        static void Main()
        {
            Karyawan karyawan = new Karyawan ();

            Console.Write("Masukkan nama karyawan: ");
            string nama = Console.ReadLine();

            Console.Write("Masukkan ID karyawan: "); // SETIAP ID KARYAWAN MEMILIKI KODE JENIS KARYAWAN "ttp" untuk karyawan tetap, "mgg" untuk karyawan magang, "ktr" untuk karyawan kontrak
            string id = Console.ReadLine();

            Console.Write("Masukkan gaji pokok: ");
            double gajiPokok = Convert.ToDouble(Console.ReadLine());

            // Menentukan jenis karyawan berdasarkan ID
            if (id.ToLower().Contains("ktr"))
            {
                Console.WriteLine("ID Karyawan yang dimasukkan adalah Karyawan Kontrak");

                if  (gajiPokok > 200000)
                {
                    karyawan = new KaryawanKontrak();
                    karyawan.Nama = nama;
                    karyawan.Id = id;
                    karyawan.Gaji_pokok = gajiPokok;
                    karyawan.TampilkanInfo();
                }
                else
                { 
                   Console.WriteLine("Gaji pokok yang diberikan tidak boleh kurang dari 200000");
                    return;   
                }  
            }

            else if (id.ToLower().Contains( "ttp"))
            {
                karyawan = new karyawan_tetap();
                Console.WriteLine("ID Karyawan yang dimasukkan adalah Karyawan Tetap");
                karyawan.Nama = nama;
                karyawan.Id = id;
                karyawan.Gaji_pokok = gajiPokok;
                karyawan.TampilkanInfo();
            }

            else if (id.ToLower().Contains("mgg"))
            {
                karyawan = new karyawan_magang();
                Console.WriteLine("ID Karyawan yang dimasukkan adalah Karyawan Magang");
                karyawan.Nama = nama;
                karyawan.Id = id;
                karyawan.Gaji_pokok = gajiPokok;
                karyawan.TampilkanInfo();
            }

            else
            {
                Console.WriteLine("ID Karyawan yang di input tidak valid");
                return;
            }
        }
    }
}


