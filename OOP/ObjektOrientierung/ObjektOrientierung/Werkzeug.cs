using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektOrientierung
{
    public class Werkzeug
    {
        private bool bewertung;

        public bool Bewertung
        {
            get { return bewertung; }
            private set { bewertung = value; }
        }

        public string WerkzeugTyp { get;  set; }
        public int Anzahl { get; set; }

        public Werkzeug(string werkzeugtyp)
        {
            this.bewertung = true; // Logik einbauen um Daten aus Umgebungsvariablen zu erhalten
            this.WerkzeugTyp = werkzeugtyp;
        }

        public Werkzeug(string werkzeugtyp, int anzahl)
        {
            this.bewertung = true; // Logik einbauen um Daten aus Umgebungsvariablen zu erhalten
            this.WerkzeugTyp = werkzeugtyp;
        }

    }
}
