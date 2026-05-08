using System;
using System.Collections.Generic;
using System.Text;

namespace SysRumahSakit.Models
{
    class Perawat : TenagaMedis
    {
        public Perawat(string nama, int umur, string spesialisasi) : base(nama, umur, spesialisasi) { }

        public override void Aktivitas()
        {
            Console.WriteLine($"Perawat {Nama} sedang merawat dan memantau kondisi pasien.");
        }

        public void CekPasien()
        {
            Console.WriteLine($"Perawat {Nama} sedang memeriksa kondisi dan kebutuhan pasien.");
        }
    }
}
