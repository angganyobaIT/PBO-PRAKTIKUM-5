
using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;


namespace PBO_PR5
{
    class Program
    {
        static void Main()
        {
            Karyawan karyawan = null; // Inisialisasi karyawan sebagai null

            Console.Write("Masukkan nama karyawan: ");
            string nama = Console.ReadLine();

            Console.Write("Masukkan ID karyawan: "); // SETIAP ID KARYAWAN MEMILIKI KODE JENIS KARYAWAN "ttp" untuk karyawan tetap, "mgg" untuk karyawan magang, "ktr" untuk karyawan kontrak
            string id = Console.ReadLine();

            Console.Write("Masukkan gaji pokok: ");
            double gajiPokok = Convert.ToDouble(Console.ReadLine());

            // Menentukan jenis karyawan berdasarkan ID
            if (id.ToLower().Contains("ktr"))
            {
                karyawan = new KaryawanKontrak();
                Console.WriteLine("ID Karyawan yang dimasukkan adalah Karyawan Kontrak");
            }

            else if (id.ToLower().Contains( "ttp"))
            {
                karyawan = new karyawan_tetap();
                Console.WriteLine("ID Karyawan yang dimasukkan adalah Karyawan Tetap");

            }
            else if (id.ToLower().Contains("mgg"))
            {
                karyawan = new karyawan_magang();
                Console.WriteLine("ID Karyawan yang dimasukkan adalah Karyawan magang");
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
}


