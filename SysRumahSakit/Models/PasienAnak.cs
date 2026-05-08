using System;
using System.Collections.Generic;
using System.Text;

namespace SysRumahSakit.Models
{
    class PasienAnak : Pasien
    {
        public PasienAnak(string nama, int umur, string keluhan) : base(nama, umur, keluhan) { }

        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} (pasien anak) sedang bermain di ruang tunggu anak.");
        }

        public void Menangis()
        {
            Console.WriteLine($"{Nama} menangis karena takut disuntik oleh dokter.");
        }
    }
}
