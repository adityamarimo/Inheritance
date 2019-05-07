using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInherit
{
    class Program
    {
        static void Main(string[] args)
        {
            Orang orang = new Orang("adit", 18);
            orang.GetOutput();

            Guru guru = new Guru("zulfikar", 30, "190399382", "Sejarah");
            guru.GetOutput();

            Murid murid = new Murid("Nabil", 10, 6, 1);
            murid.GetOutput();

            Console.ReadKey();
        }
    }
}
