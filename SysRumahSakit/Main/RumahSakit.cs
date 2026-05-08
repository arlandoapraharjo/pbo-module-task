using System;
using System.Collections.Generic;
using System.Text;

namespace SysRumahSakit
{
    class RumahSakit
    {
        private List<Orang> daftarOrang = new List<Orang>();
        
        public void TambahOrang(Orang orang)
        {
            daftarOrang.Add(orang);
            Console.WriteLine($"{orang.Nama} telah ditambahkan ke daftar rumah sakit.");
        }

        public void DaftarOrang()
        {
            Console.WriteLine("Daftar Seluruh Orang di Rumah Sakit:");
            foreach (var orang in daftarOrang)
            {
                orang.InfoOrang();
                orang.Aktivitas();
            }
        }
    }
}
