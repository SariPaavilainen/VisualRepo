using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asiakasrekisteri_pe_ilta
{
        class Asiakas
        {
            public static int SeuraavaVapaaNumero = 1000;
            public int Asiakasnumero { get; set; }

            public string AsiakkaanNimi { get; set; }

            public decimal TilaustenArvo { get; set; }



            public Asiakas(string nimi, decimal tilaukset)
            {
                Asiakasnumero += SeuraavaVapaaNumero;
                AsiakkaanNimi = nimi;
                TilaustenArvo = tilaukset;
            SeuraavaVapaaNumero++;

            }
        public static decimal TilaustenYhteissumma(List<Asiakas> asiakaslista)
        {
            decimal summalaskuri = 0m;
            foreach (Asiakas dummy in asiakaslista)
            {
                summalaskuri += dummy.TilaustenArvo;
            }

            return summalaskuri;

        }
        public override string ToString()
        {
            return $"{Asiakasnumero}: {AsiakkaanNimi}, tilausten arvo {TilaustenArvo} e.";
        }


    }
    
}
