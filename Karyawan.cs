using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2654
{
    class Karyawan
    {
        public int Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        public Karyawan(int nik, string nama, int gaji)
        {
            Nik = nik;
            Nama = nama;

            if (gaji < 0)
            {
                GajiBulanan = 0;
            }
            else
            {
                GajiBulanan = gaji;
            }
        }

        public void DataKaryawan()
        {
            Console.WriteLine("{0} \t {1} \t {2}", Nik, Nama, GajiBulanan);
        }

        public void UpGaji()
        {
            double tmp = 0;
            tmp = 0.1 * GajiBulanan;
            GajiBulanan += Convert.ToInt32(tmp);
            Console.WriteLine("{0} \t {1} \t {2}", Nik, Nama, GajiBulanan);
        }
    }
}