using System;
using Demos.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Net;
using Xamarin.Essentials;

namespace Demos.ViewModel
{
    public class DettaglioModel : INotifyPropertyChanged
    {
        public Programma programma { get; set; }

        public Programma Programma
        {
            get { return programma; }
            set
            {
                if (programma != value)
                    programma = value;
                OnPropertyChanged("Programma");
            }
        }

        public string descrizione { get; set; }

        public string Descrizione
        {
            get { return descrizione; }
            set
            {
                if (descrizione != value)
                    descrizione = value;
                OnPropertyChanged("Descrizione");
            }
        }

        public string link { get; set; }

        public string Link
        {
            get { return link; }
            set
            {
                if (link != value)
                    link = value;
                OnPropertyChanged("Link");
            }
        }
        public bool launch { get; set; }
        public bool Launch
        {
            get { return launch; }
            set
            {
                if (launch != value)
                    launch = value;
                OnPropertyChanged("Launch");
            }
        }

        public bool notlaunch { get; set; }
        public bool Notlaunch
        {
            get { return notlaunch; }
            set
            {
                if (notlaunch != value)
                    notlaunch = value;
                OnPropertyChanged("Notlaunch");
            }
        }

        public bool linknonpresente { get; set; }
        public bool LinkNonPresente
        {
            get { return linknonpresente; }
            set
            {
                if (linknonpresente != value)
                    linknonpresente = value;
                OnPropertyChanged("LinkNonPresente");
            }
        }

        public bool linkpresente { get; set; }
        public bool LinkPresente
        {
            get { return linkpresente; }
            set
            {
                if (linkpresente != value)
                    linkpresente = value;
                OnPropertyChanged("LinkPresente");
            }
        }

        public string image1 { get; set; }

        public string Image1
        {
            get { return image1; }
            set
            {
                if (image1 != value)
                    image1 = value;
                OnPropertyChanged("Image1");
            }
        }

        public string image2 { get; set; }

        public string Image2
        {
            get { return image2; }
            set
            {
                if (image2 != value)
                    image2 = value;
                OnPropertyChanged("Image2");
            }
        }

        public string image3 { get; set; }

        public string Image3
        {
            get { return image3; }
            set
            {
                if (image3 != value)
                    image3 = value;
                OnPropertyChanged("Image3");
            }
        }

        public DettaglioModel()
        {
            DBData db = new DBData();
            Programma = new Programma();
            Programma = db.ExctractProgrammaWithName(Preferences.Get("percorso", ""));
            string Descrizione = Programma.Descrizione;
            string Link = Programma.Link;
            if (Link == "" || Link == null)
            {
                LinkPresente = false;
                LinkNonPresente = true;
            }
            else
            {
                LinkPresente = true;
                LinkNonPresente = false;
            }
            if (Programma.UWP)
            {
                Launch = true;
                Notlaunch = false;
            }
            else
            {
                Launch = false;
                Notlaunch = true;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



    }
}
