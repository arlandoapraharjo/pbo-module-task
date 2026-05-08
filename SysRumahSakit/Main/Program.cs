using SysRumahSakit.Models;
using SysRumahSakit;

RumahSakit rs = new RumahSakit();

// buat beberapa objek orang
Dokter dokter1 = new Dokter("Rusdi Sutomo", 45, "Kardiologi");
Perawat perawat1 = new Perawat("Angela Collins", 30, "Keperawatan Umum");
PasienAnak pasienAnak1 = new PasienAnak("Sinyo Kecil", 7, "Demam sawit tinggi");
PasienDewasa pasienDewasa1 = new PasienDewasa("Christina Aguilera", 35, "Sawit kepala kronis");

// tambah ke rumah sakit
Console.WriteLine("---Pendaftaran---");
rs.TambahOrang(dokter1);
rs.TambahOrang(perawat1);
rs.TambahOrang(pasienAnak1);
rs.TambahOrang(pasienDewasa1);

Console.WriteLine("\n---Daftar Orang---");
rs.DaftarOrang();

Console.WriteLine("\nSoal 1:");
dokter1.Aktivitas();
pasienAnak1.Aktivitas();

Console.WriteLine("\nSoal 2:");
dokter1.Diagnosa();
Console.WriteLine("\nSoal 3:");
dokter1.InfoOrang();
dokter1.CekSpesialis();

Console.WriteLine("\nSoal 4:");
pasienAnak1.Menangis();

Console.WriteLine("\nSoal 5");
Orang orang = new Perawat("Rina Coraline", 28, "ICU");
orang.Aktivitas();
