using System;
using System.Collections.Generic;
using System.Text;

namespace SysRumahSakit
{
    class Orang
    {
        public string Nama { get; set; }
        public int Umur { get; set; }

        public Orang (string Nama, int Umur)
        {
            this.Nama = Nama;
            this.Umur = Umur;
        }

        public virtual void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang beraktivitas di rumah sakit.");
        }

        public void InfoOrang()
        {
            Console.WriteLine($"Nama: {Nama}, Umur: {Umur}");
        }
    }
}
