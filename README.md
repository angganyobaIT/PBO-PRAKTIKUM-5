Jadi secara keseluruhan kode yang saya buat mengandung 3 subclass dan 1 superclass, yang mana di masing masing subclass terdiri dari 1 method turunan yaitu method HitungGaji, dan didalam superclass terdapat 2 method yaitu TampilkanInfo dan HitungGaji

3.1 Penjelasan source code Karyawan:
Kelas karyawan memiliki 3 atribut dengan access modifier bertipe private hal tersebut ditandai dari penggunaan kata ”private” sebelum pemanggilan tipe data

        private string _nama;
        private string _id;
        private double _gajiPokok;

kemudian “public string nama”, “public string id”, dan “public double Gaji_Pokok” termasuk kedalam  properties yang mana “get” ini difungsikan untuk menampung atribut yang memiliki unsur private tersebut get { return _nama; }, sementara “set” difungsikan agar variable _nama dapat memiliki value set { _nama = value; }, selain itu “set” berfungsi untuk menentukan kriteria seperti apa yang bisa dimiliki oleh suatu atribut misalkan atribut _nama. Dan untuk menjalankan properties tersebut dapat dilakukan dengan cara memanggil nama dari properties tersebut didalam object (konsep yang sama berlaku di “public string id” dan “public double Gaji_Pokok”). 

Di dalam class karyawan terdapat 2 method yaitu HitungGaji dan TampilkanInfo. Fungsi dari method HitungGaji yang ada didalam kelas karyawan yaitu hanya sebagai wadah untuk menyimpan operasi perhitungan gaji di masing-masing jenis karyawan, dengan cara menerapkan metode polymorphism yaitu override. Untuk bisa menggunakan metode override, perlu penambahan keyword “virtual” di  method utama ”public virtual double HitungGaji()”. Setiap jenis karyawan bisa menggunakan method HitungGaji ini untuk menyimpan karakteristik perhitungan gaji yang dimiliki di masing-masing jenis karyawan dengan memberi keyword “override” pada method di dalam masing-masing  kelas turunan dari karyawan “public override double HitungGaji()”. Dan method yang kedua yang ada didalam kelas karyawan, yaitu TampilkanInfo. Method ini berguna untuk menampilkan info total gaji yang diterima karyawan. Untuk bisa memanggil info yang ada di method ini, perlu beberapa pemanggilan properties dan method, seperti Nama, Id, dan method HitungGaji (Mengapa method HitungGaji yang dilakukan pemanggilan? Karena di method ini yang menyimpan hasil akhir dari kalkulasi gaji pokok)
        
        public void TampilkanInfo()
        {
            Console.WriteLine("\n=== Informasi Penerimaan Gaji Karyawan ===");
            Console.WriteLine($"Nama       : {Nama}");
            Console.WriteLine($"ID         : {Id}");
            Console.WriteLine($"Gaji Akhir : {HitungGaji()}");
        }

3.2 Penjelasan Source Code Subclass (karyawan_tetap, karyawan_kontrak, dan karyawan_magang)

Semua subclass jenis karyawan memiliki warisan dari superclass karyawan yaitu berupa method HitungGaji yang mana method tersebut sekaligus penerapan dari konsep polymorphisme “public override double HitungGaji()”, di dalam method inilah setiap jenis karyawan memiliki kalkulasi berbeda-beda terhadap variabel “Gaji_pokok” namun tetap didalam satu method yang sama yaitu “HitungGaji”. Selain cara kalkulasi variabel Gaji_pokok perbedaan lainnya yaitu pada atribut yang dimiliki setiap subclass seperti di dalam subclass karyawan_tetap memiliki atribut yaitu “bonus_tetap” dengan value 500000 “public int bonus_tetap = 500000;”, kemudian terdapat subclass karyawan_kontrak, yang didalamnya memiliki atribut potongan_kontrak dengan value 200000 “public int potongan_Kontrak = 200000;”, dan subclass terakhir yaitu karyawan_magang di dalam subclass ini tidak memiliki atribut apa pun sebab tidak adanya kalkulasi variabel “Gaji_pokok” di dalam subclass ini, sehingga method di kelas ini bertugas hanya mengembalikan nilai yang ada di dalam Gaji_pokok.

3.3 Penjelasan Source Code Object

Dibagian inilah user bisa menginput suatu nilai serta dilakukan beberapa pemrosesan. 
Hal pertama dibagian object ini yaitu meminta input nama, id, dan gaji dari user. Variabel “nama” akan menampung input nama pegawai dari user,  variabel “id” akan menampung input id pegawai dari user, dan variabel “gajiPokok” akan menampung gaji pegawai dari user. Nama variabel ini yang nantinya akan digunakan untuk dimasukan di logika perkondisian dibawah.

            Console.Write("Masukkan nama karyawan: ");
            string nama = Console.ReadLine();

            Console.Write("Masukkan ID karyawan: "); 
            string id = Console.ReadLine();

            Console.Write("Masukkan gaji pokok: ");
            double gajiPokok = Convert.ToDouble(Console.ReadLine());

Terdapat sedikit perlakuan khusus untuk input gaji pokok, karena penggunaan Console.ReadLine maka tipe data yang dihasilkan sudah pasti berbentuk string, agar tipe data berubah menjadi double maka perlu dilakukan parse/mengubah tipe data menjadi double (double karena permintaan soal yang mana atribut gaji pokok memiliki tipe data double). 

Untuk menentukan jenis karyawan yang dimasukan oleh user apakah termasuk karyawan tetap, karyawan kontrak, atau karyawan magang, disini saya memanfaatkan id untuk mengenali jenis karyawan yang diinput. Saya asumsikan di suatu perusahaan, id yang dibuat merupakan gabungan antara angka dan singkatan dari jenis yang karyawan tersebut jalani disuatu perusahaan, sehingga terdapat 3 jenis yaitu id dengan awalan “ttp” untuk karyawan tetap diikuti angka, id dengan awalan “ktr” untuk karyawan tetap diikuti angka,, dan id dengan awalan “mgg” untuk karyawan magang diikuti angka.

            if (id.ToLower().Contains("ktr")) //=> perkondisian 1
            {
                Console.WriteLine("ID Karyawan yang dimasukkan adalah Karyawan Kontrak");

                if  (gajiPokok > 200000) //=> perkondisian 2
                {
                    karyawan = new karyawan_kontrak();
                    karyawan.Nama = nama;
                    karyawan.Id = id;
                    karyawan.Gaji_pokok = gajiPokok;
                    karyawan.TampilkanInfo();
                }
                else //=> perkondisian 2
                { 
                   Console.WriteLine("Gaji pokok yang diberikan tidak boleh kurang dari 200000");
                    return;   
                }  
            }

            else if (id.ToLower().Contains( "ttp")) //=> perkondisian 1
            {
                karyawan = new karyawan_tetap();
                Console.WriteLine("ID Karyawan yang dimasukkan adalah Karyawan Tetap");
                karyawan.Nama = nama;
                karyawan.Id = id;
                karyawan.Gaji_pokok = gajiPokok;
                karyawan.TampilkanInfo();
            }

            else if (id.ToLower().Contains("mgg")) //=> perkondisian 1
            {
                karyawan = new karyawan_magang();
                Console.WriteLine("ID Karyawan yang dimasukkan adalah Karyawan Magang");
                karyawan.Nama = nama;
                karyawan.Id = id;
                karyawan.Gaji_pokok = gajiPokok;
                karyawan.TampilkanInfo();
            }

            else //=> perkondisian 1
            {
                Console.WriteLine("ID Karyawan yang di input tidak valid");
                return;

Hampir perkondisian yang terjadi diatas memiliki tugas yang mirip. Perkondisian diatas bertugas dengan menyesuaikan keyword id apa yang ada didalam input dari user (“ktr”, “ttp”, “mgg“) dan menjalankan kondisi yang ada di dalamnya, jika input id dari user diluar dari keyword yang ada di dalam logika perkondisian maka akan masuk kedalam kondisi else yang mana akan memunculkan pesan "ID Karyawan yang di input tidak valid”. 

Saya akan menjelaskan lebih detail pada perkondisian untuk karyawan kontrak sebab didalamnya terdapat nested if dan memiliki kompleksitas lebih tinggi dibanding perkondisian jenis karyawan lainnya, akan tetapi saya tetap akan menjelaskan fungsi yang memiliki kesamaan di jenis karyawan lainnya. 

            if (id.ToLower().Contains("ktr"))
            {
                Console.WriteLine("ID Karyawan yang dimasukkan adalah Karyawan Kontrak");  // => (1)

                if  (gajiPokok > 200000)
                {
                    karyawan = new karyawan_kontrak();
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
Misalkan input id yang diberikan oleh user yaitu “ktr00192” karena input yang diberikan user mengandung keyword “ktr” maka akan masuk kedalam perkondisian karyawan kontrak (sama seperti perkondisian diatas). 

Untuk bisa mengetahui keyword apa yang dimasukan oleh user, kode inilah yang memiliki peran:

                if (id.ToLower().Contains("ktr"))

didalam kode diatas hal pertama yang dilakukan yaitu menjadikan id yang di input oleh user menjadi huruf kecil “id.ToLower()”, hal ini bertujuan agar jika user tidak sengaja menginput karakter dengan huruf kapital didalamnya maka akan dianggap menjadi huruf kecil dan hal kedua yang dilakukan melakukan pencarian keyword khusus seperti (“ttp”, “ktr”, “mgg”), hal tersebut dilakukan oleh kode contains “.Contains("ktr")”

setelah berhasil lolos di syarat pertama maka akan memunculkan pesan “ID Karyawan yang dimasukkan adalah Karyawan Kontrak”. Dan masuk ke syarat yang kedua (syarat kedua ini hanya ada didalam karyawan kontrak)

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

Di perkondisian yang kedua (kode diatas) perlu dilakukan validasi kembali pada variabel gaji_Pokok yang dimasukan oleh user. Mengapa perkondisian ini hanya ada didalam karyawan kontrak? Karena di dalam jenis karyawan kontrak terdapat kalkulasi pengurangan variabel gaji_Pokok dengan potongan kontrak sebesar 200.000. karena faktor inilah, yang saya hindari jika gaji_Pokok yang diinput lebih kecil dari potongan kontrak maka hasil yang ditampilkan akan minus, sehingga diperlukan perkondisian yang menentukan jika variabel gaji_Pokok harus lebih besar dari 200.000. Jika user menginput gaji_Pokok kurang dari 200.000 maka akan ada pesan "Gaji pokok yang diberikan tidak boleh kurang dari 200000" dan melakukan return agar pesan dari else di perkondisian 1 tidak muncul.

Jika perkondisian 1 dan 2 telah benar (dalam kondisi pegawai kontrak) maka akan di lakukan eksekusi kode yang ada didalamnya (hal ini juga terjadi untuk keyword “ttp” dan “mgg”)


                {
                    karyawan = new karyawan_kontrak(); //=> bagian ini ada di jenis karyawan lainnya
                    karyawan.Nama = nama;		   //=> bagian ini ada di jenis karyawan lainnya
                    karyawan.Id = id;			   //=> bagian ini ada di jenis karyawan lainnya
                    karyawan.Gaji_pokok = gajiPokok;  	   //=> bagian ini ada di jenis karyawan lainnya
                    karyawan.TampilkanInfo();		   //=> bagian ini ada di jenis karyawan lainnya
                }              
                
Hal yang terjadi di dalam fungsi ini yaitu karena saat ini object masih berada didalam class karyawan maka perlu diteruskan ke dalam karyawan_kontrak (sesuai jenis karyawan yang terpilih) agar menggunakan method yang ada didalam class tersebut, variabel nama yang didalamnya telah memiliki value nama akan dimasukkan kedalam method Nama yang ada di dalam class karyawan, variabel id yang didalamnya telah memiliki value id akan dimasukkan kedalam method Id, dan variabel gajiPokok yang didalamnya telah memuat gaji karyawan akan dimasukkan kedalam method Gaji_pokok. Dan yang terakhir setelah semuanya telah dimasukan dan tersimpan didalam method dan properties selanjutnya hanya dilakukan pemanggilan method yang menyimpan data tersebut yaitu di dalam method TampilkanInfo().
