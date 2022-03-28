using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurvendiskussion
{
    class lineareFunktion
    {
        //Eigenschaften (Properties)
        public double Anstieg { get; private set; }
        public double YAchsenAbschnitt { get; private set; }

        //Methoden

        //Konstruktor
        public lineareFunktion(double Anstieg, double YAchsenAbschnitt)
        {
            this.Anstieg = Anstieg;
            this.YAchsenAbschnitt = YAchsenAbschnitt;
        }

        //weiter Methoden
        public double berechneNullstelle()
        {
            double nullstelle;
            nullstelle = -YAchsenAbschnitt / Anstieg;
            return nullstelle;
        }

        public double berechneFunktionswert(double XWert)
        {
            double Funktionswert;
            Funktionswert=XWert*Anstieg+YAchsenAbschnitt;
            return Funktionswert;
        }
    }
}
