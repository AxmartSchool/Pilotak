using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versenyzok
{
    public class Pilota
    {
        public string Nev { get; set; }
        public DateTime SzuletesiDatum { get; set; }
        public string Nemzetiseg { get; set; }
        public int Rajtszam { get; set; }




        public static List<Pilota> Beolvasas()
        {
            var output = new List<Pilota>();

            var sr = new StreamReader("../../pilotak.csv",Encoding.UTF8);
            sr.ReadLine();
            List<string> tempTomb;
            while (!sr.EndOfStream)
            {
                tempTomb = sr.ReadLine().Split(';').ToList();
                var pilota = new Pilota { Nev = tempTomb[0], SzuletesiDatum = DateTime.Parse(tempTomb[1]), Nemzetiseg = tempTomb[2] };
                int rajtszam;
                int.TryParse(tempTomb[3], out rajtszam);
                pilota.Rajtszam = rajtszam;




                output.Add(pilota);

            }

            sr.Close();

            return output;

        }

    }
}
