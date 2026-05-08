namespace SysRumahSakit.Models
{
    class Dokter : TenagaMedis
    {
        public Dokter(string nama, int umur, string spesialisasi) : base(nama, umur, spesialisasi) { }

        public override void Aktivitas()
        {
            Console.WriteLine($"Dr. {Nama} sedang melakukan pemeriksaan kepada pasien.");
        }

        public void Diagnosa()
        {
            Console.WriteLine($"Dr. {Nama} sedang mendiagnosis penyakit pasien dengan spesialisasi {Spesialisasi}.");
        }
    }
}
