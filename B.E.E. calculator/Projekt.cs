using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace B.E.E._calculator
{
    public class Projekt
    {
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Projekt() { }

        private string naziv_projekta;
        private string ulica_kraj;
        private string katastrska_obcina;
        private int GKX;
        private int GKY;
        private string opredelitev_stavbe;
        private string vrsta_gradnje;
        private string javna_stavba;


        public string Naziv_projekta
        {
            get
            {
                return naziv_projekta;
            }
            set
            {
                naziv_projekta = value;
                OnPropertyChanged("Naziv_projekta");
            }
        }

        public string Ulica_kraj
        {
            get
            {
                return ulica_kraj;
            }
            set
            {
                ulica_kraj = value;
                OnPropertyChanged("Ulica_kraj");
            }
        }

        public string Katastrska_obcina
        {
            get
            {
                return katastrska_obcina;
            }
            set
            {
                katastrska_obcina = value;
                OnPropertyChanged("Katastrska_obcina");
            }
        }

        public int GK_koordinate_kraja_GKX
        {
            get
            {
                return GKX;
            }
            set
            {
                GKX = value;
                OnPropertyChanged("GK_koordinate_kraja_GKX");
            }
        }

        public int GK_koordinate_kraja_GKY
        {
            get
            {
                return GKY;
            }
            set
            {
                GKY = value;
                OnPropertyChanged("GK_koordinate_kraja_GKY");
            }
        }

        public string Opredelitev_stavbe
        {
            get
            {
                return opredelitev_stavbe;
            }
            set
            {
                opredelitev_stavbe = value;
                OnPropertyChanged("Opredelitev_stavbe");
            }
        }

        public string Vrsta_gradnje
        {
            get
            {
                return vrsta_gradnje;
            }
            set
            {
                vrsta_gradnje = value;
                OnPropertyChanged("Vrsta_gradnje");
            }
        }

        public string Javna_stavba
        {
            get
            {
                return javna_stavba;
            }
            set
            {
                javna_stavba = value;
                OnPropertyChanged("Javna_stavba");
            }
        }

        public Projekt(string naziv_projekta, string ulica_kraj, string katastrska_obcina, int GKX, int GKY, string opredelitev_stavbe, string vrsta_gradnje, string javna_stavba)
        {
            Naziv_projekta = naziv_projekta;
            Ulica_kraj = ulica_kraj;
            Katastrska_obcina = katastrska_obcina;
            GK_koordinate_kraja_GKX = GKX;
            GK_koordinate_kraja_GKY = GKY;
            Opredelitev_stavbe = opredelitev_stavbe;
            Vrsta_gradnje = vrsta_gradnje;
            Javna_stavba = javna_stavba;
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
