using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versenyzok
{
    class Program
    {
        public static List<Pilota> Pilotak;

        static void Main(string[] args)
        {
            Pilotak = Pilota.Beolvasas();
            HarmadikFeladat();
            NegyedikFeladat();
            OtodikFeladat();
            HatodikFeladat();
            HetedikFeladat();

            Console.ReadKey();
        }

        private static void HetedikFeladat()
        {

            List<int> rajtszamok = new List<int>();
            List<int> tobbszorHasznalt = new List<int>();
            foreach (var pilota in Pilotak)
            {
                if (pilota.Rajtszam > 0)
                {
                    if (rajtszamok.Contains(pilota.Rajtszam))
                    {
                        if (!tobbszorHasznalt.Contains(pilota.Rajtszam))
                        {
                            tobbszorHasznalt.Add(pilota.Rajtszam);
                        }

                    }
                    else
                    {
                        rajtszamok.Add(pilota.Rajtszam);
                    }
                }
            }

            Console.Write($"7. feladat : ");
            foreach (var rajtSzam in tobbszorHasznalt)
            {
                Console.Write($" {rajtSzam},");
            }


        }

        private static void HatodikFeladat()
        {

            List<Pilota> rajtszamosPilotak = new List<Pilota>();
            foreach (var pilota in Pilotak)
            {
                if (pilota.Rajtszam > 0)
                {
                    rajtszamosPilotak.Add(pilota);
                }
            }

            var legkissebbRajtszamuPilota = rajtszamosPilotak.OrderBy(x => x.Rajtszam).Take(1).First();

            Console.WriteLine($"6. feladat : {legkissebbRajtszamuPilota.Nemzetiseg}");
            

        }

        private static void OtodikFeladat()
        {
            Console.WriteLine("5. feladat: ");

            List<Pilota> regenSzuletettPilotak = new List<Pilota>();
            foreach (var pilota in Pilotak)
            {

                if (pilota.SzuletesiDatum < DateTime.Parse("1901.01.01"))
                {
                    regenSzuletettPilotak.Add(pilota);
                }

            }

            foreach (var regiPilota in regenSzuletettPilotak)
            {
                Console.WriteLine($"\t{regiPilota.Nev} ({regiPilota.SzuletesiDatum:d})");
            }


        }

        private static void NegyedikFeladat()
        {

            Console.WriteLine($"4. feladat: {Pilotak[Pilotak.Count()-1].Nev}");


        }

        private static void HarmadikFeladat()
        {
            Console.WriteLine($"3. feladat: {Pilotak.Count()}");


        }
    }
}
