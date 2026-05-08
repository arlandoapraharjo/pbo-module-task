using System;
using System.Collections.Generic;
using System.Text;

namespace SysRumahSakit.Models
{
    class PasienDewasa : Pasien
    {
        public PasienDewasa(string nama, int umur, string keluhan) : base(nama, umur, keluhan) { }

        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} (pasien dewasa) sedang mengisi formulir pendaftaran.");
        }

        public void Konsultasi()
        {
            Console.WriteLine($"{Nama} sedang berkonsultasi dengan dokter mengenai keluhannya: {Keluhan}.");
        }
    }
}
