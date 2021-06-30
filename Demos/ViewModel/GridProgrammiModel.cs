using Demos.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Net;
using Xamarin.Forms;

namespace Demos.ViewModel
{
    public class GridProgrammiModel : INotifyPropertyChanged
    {
        public ObservableCollection<Programma> programma { get; set; }

        public ObservableCollection<Programma> Programma
        {
            get { return programma; }
            set
            {
                if (programma != value)
                    programma = value;
                OnPropertyChanged("Programma");
            }
        }

        public bool isBusy { get; set; }

        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                if (isBusy != value)
                    isBusy = value;
                OnPropertyChanged("IsBusy");
            }
        }

        public string cerca { get; set; }

        public string Cerca
        {
            get { return cerca; }
            set
            {
                if (cerca != value)
                    cerca = value;
                SelectProgramma();
                OnPropertyChanged("Cerca");
            }
        }

        List<Programma> lspro = new List<Programma>();
        DBData db = new DBData();
        bool TableExist = false;

        public GridProgrammiModel()
        {
            IsBusy = true;
            db.DropTable();
            CheckCreateTable();

            if (!TableExist)
            {
                popolaDB();
                SelectProgramma();
            }
            else
            {
                SelectProgramma();

            }

            IsBusy = false;
        }
        void CheckCreateTable()
        {
            if (db.TableExist("Programma") == false)
            {
                db.CreateTableProgramma();
                TableExist = false;
            }
            else
            {
                TableExist = true;
            }
        }

        bool SelectProgramma()
        {
            Programma = new ObservableCollection<Programma>();
            try
            {
                if (Cerca != "" & Cerca != null)
                {
                    lspro = db.ExctractProgrammaWithSearch(Cerca);
                }
                else
                {
                    lspro = db.ExctractProgrammaWithOrder("Percorso");
                }
                foreach (Programma ls in lspro)
                {
                    Programma.Add(ls);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        bool popolaDB()
        {
            bool atlastonce = false;
            Programma pro = new Programma();
            string[] riga = new string[7];


            try
            {
                WebRequest req = WebRequest.Create("http://pinexp.altervista.org/Demos/programmi.txt");
                WebResponse rsp = (HttpWebResponse)req.GetResponse();
                StreamReader sr = new StreamReader(rsp.GetResponseStream());
                {

                    do
                    {
                        riga = sr.ReadLine().Split('|');
                        if (riga[0] != null & riga[0] != "")
                        {
                            pro.Percorso = riga[0];
                        }
                        if (riga[1] != null)
                        {
                            if (riga[1] == "1" | riga[1] == "true")
                                pro.Android = true;
                            if (riga[1] == "0" | riga[1] == "false")
                                pro.Android = false;
                        }
                        if (riga[2] != null)
                        {
                            if (riga[2] == "1" | riga[2] == "true")
                                pro.IOS = true;
                            if (riga[2] == "0" | riga[2] == "false")
                                pro.IOS = false;
                        }
                        if (riga[3] != null)
                        {
                            if (riga[3] == "1" | riga[3] == "true")
                                pro.UWP = true;
                            if (riga[3] == "0" | riga[3] == "false")
                                pro.UWP = false;
                        }
                        pro.Descrizione = riga[4];
                        pro.Link = riga[5];

                        bool flag = db.InsProgramma(pro);
                        if (flag)
                        {
                            atlastonce = true;
                        }
                    } while (!sr.EndOfStream);
                }
            }

            catch (Exception ex)
            {
                return false;
            }
            return false;

        }



        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
