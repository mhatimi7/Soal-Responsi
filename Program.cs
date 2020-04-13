Skip to content
Search or jump to…

Pull requests
Issues
Marketplace
Explore

@mhatimi7
Learn Git and GitHub without any code!
Using the Hello World guide, you’ll start a branch, write comments, and open a pull request.


arifsadewo
/
ResponsiPemrograman2654
1
00
 Code Issues 0 Pull requests 0 Actions Projects 0 Wiki Security Insights
ResponsiPemrograman2654/Program.cs
@arifsadewo arifsadewo Responsi Pemrograman
cd67efa 21 minutes ago
32 lines(26 sloc)  859 Bytes
  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2654
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan(19112599, "Hatim", 2000000);
            Karyawan karyawan2 = new Karyawan(191125600, "Al Jaudi", 3000000);


            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.DataKaryawan();
            karyawan2.DataKaryawan();

            Console.WriteLine("\n\n Asikkk naik gaji!!!");

            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.UpGaji();
            karyawan2.UpGaji();

            Console.ReadKey();
        }
    }
}
© 2020 GitHub, Inc.
Terms
Privacy
Security
Status
Help
Contact GitHub
Pricing
API
Training
Blog
About
