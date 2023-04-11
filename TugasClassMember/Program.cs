using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasClassMember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil1 = new Mobil();
            mobil1.Warna = "Hitam";
            mobil1.JumlahPintu = 4;
            mobil1.Merek = "Toyota";
            mobil1.Model = "Kijang Innova";
            mobil1.TahunKeluaran = 2018;
            mobil1.Kecepatan = 2000;
            mobil1.Suara = "Hahahaha";

            mobil1.Gas();
            mobil1.Klakson();
            mobil1.TampilkanInfo();

            Console.ReadKey();
        }
    }
}
