using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asiakasrekisteri_pe_ilta
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Asiakas> asiakkaat = new List<Asiakas>();
            Asiakas a1 = new Asiakas("Ville Virtanen", 3544.20m);
            Asiakas a2 = new Asiakas("Taimi Tuiskunen", 9554.74m);
            Asiakas a3 = new Asiakas("Leena Lundahl", 611.40m);
            Asiakas a4 = new Asiakas("Pyry Peltonen", 45978.12m);

            asiakkaat.Add(a1);
            asiakkaat.Add(a2);
            asiakkaat.Add(a3);
            asiakkaat.Add(a4);

            foreach (Asiakas dummy in asiakkaat)
            {
                Console.WriteLine(dummy.ToString());
            }
            Console.WriteLine("Tilausten yhteissumma on " + (Asiakas.TilaustenYhteissumma(asiakkaat)));


            StreamWriter kirjuri = new StreamWriter("c:\\users\\Sari\\source\\repos\\Academy\\Viikko 1\\asiakasrekisteri.xml");
            kirjuri.WriteLine("<<Asiakkaat>>");
            foreach (var item in asiakkaat)
            {
                kirjuri.WriteLine("\t<Asiakas>");
                kirjuri.WriteLine("\t\t<Asiakasnumero>" + item.Asiakasnumero + "<\\Asiakasnumero>");
                kirjuri.WriteLine("\t\t<AsiakkaanNimi>" + item.AsiakkaanNimi + "<\\AsiakkaanNimi>");
                kirjuri.WriteLine("\t\t<TilaustenArvo>" + item.TilaustenArvo + "<\\TilaustenArvo>");
                kirjuri.WriteLine("----");
            }

            kirjuri.Close();
            


        }
    }
}
