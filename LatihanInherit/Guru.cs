using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInherit
{
    public class Guru : Orang
    {
        public string IdGuru { get; set; }
        public string Mapel { get; set; }

        public Guru(string nama, int umur, string idguru, string mapel)
            : base(nama, umur)
        {
            Nama = nama;
            Umur = umur;
            IdGuru = idguru;
            Mapel = mapel;
        }
    }
}
