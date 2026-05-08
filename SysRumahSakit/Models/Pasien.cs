using System;
using System.Collections.Generic;
using System.Text;

namespace SysRumahSakit.Models
{
    class Pasien : Orang
    {
        public string Keluhan { get; set; }

        public Pasien(string nama, int umur, string keluhan) : base(nama, umur)
        {
            Keluhan = keluhan;
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang menunggu pemeriksaan di ruang tunggu.");
        }

        public void CekKeluhan()
        {
            Console.WriteLine($"Keluhan pasien {Nama}: {Keluhan}");
        }
    }
}
