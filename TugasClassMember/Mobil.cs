using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasClassMember
{
    internal class Mobil
    {
        private string warna;
        private string merek;
        private string model;
        private int jumlah_pintu;
        private int tahun_keluaran;
        private int kecepatan;
        private string suara;

        //property
        public string Warna
        {
            get
            {
                return warna;
            }
            set
            {
                warna = value;
            }
        }

        public string Merek
        {
            get
            {
                return merek;
            }
            set
            {
                merek = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public int JumlahPintu
        {
            get
            {
                return jumlah_pintu;
            }
            set
            {
                jumlah_pintu = value;
            }
        }
        public int TahunKeluaran
        {
            get
            {
                return tahun_keluaran;
            }
            set
            {
                tahun_keluaran = value;
            }
        }
        public int Kecepatan
        {
            get
            {
                return kecepatan;
            }
            set
            {
                kecepatan = value;
            }
        }
        public string Suara
        {
            get
            {
                return suara;
            }
            set
            {
                suara = value;
            }
        }

        // methode
        public void Gas()
        {
            Console.WriteLine("Muhammad Farhan Anggara");
            Console.WriteLine("19.11.2842");
            Console.WriteLine("");
            Console.Write("Mobil {0}", Model);
            Console.Write(" Berjalan dengan kecepatan {0}", Kecepatan);
            Console.WriteLine("\n");
            
        }

        public void Klakson()
        {
            Console.Write("Suara Klakson {0}", Suara);
            Console.WriteLine("\n");
           
        }

        public void TampilkanInfo()
        {
            Console.Write("Mobil saya berwarna {0}", Warna);
            Console.Write(" merek {0}", Merek);
            Console.Write(" model {0}", Model);
            Console.Write(" Keluaran tahun {0}", TahunKeluaran);
            Console.Write(" dengan jumlah pintu sebanyak {0}", JumlahPintu);
            Console.Write("\n");
            
        }
    }
}
