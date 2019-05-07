using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInherit
{
    public class Murid : Orang
    {
        public int Kelas { get; set; }
        public string JenisKelamin { get; set; }

        public Murid(string nama, int umur, int kelas, int jenis)
            : base(nama, umur)
        {
            Nama = nama;
            Umur = umur;
            Kelas = kelas;
            JenisKelamin = jenis == 1 ? "Laki - Laki" : "Perempuan";
        }
    }
}
