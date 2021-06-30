using System.IO;
using SQLite;
using SQLitePCL;
using Xamarin.Forms;

namespace Demos.Model
{
    public class Programma
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Percorso { get; set; }
        public bool Android { get; set; }
        public bool IOS { get; set; }
        public bool UWP { get; set; }
        public string Descrizione { get; set; }
        public string Link { get; set; }
        public bool Preferiti { get; set; }
        public Programma(string percorso, bool android, bool ios, bool uwp, string descrizione, string link, bool preferiti)
        {
            Percorso = percorso;
            Android = android;
            IOS = ios;
            UWP = uwp;
            Descrizione = descrizione;
            Link = link;
            Preferiti = preferiti;
        }

        public Programma() { }
    }
}
