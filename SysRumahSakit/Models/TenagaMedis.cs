using System;
using System.Collections.Generic;
using System.Text;

namespace SysRumahSakit.Models
{
    class TenagaMedis : Orang
    {
        public string Spesialisasi { get; set; }

        public TenagaMedis(string nama, int umur, string spesialisasi) : base(nama, umur)
        {
            Spesialisasi = spesialisasi;
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang bertugas sebagai tenaga medis.");
        }

        public void CekSpesialis() 
        {
            Console.WriteLine($"{Nama}, Spesialisasi: {Spesialisasi}");
        }
    }
}
