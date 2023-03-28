using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace B.E.E._calculator
{
    public class Material
    {
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Material() { }

        private string naziv_materiala;
        private float gostota;
        private float cp;
        private float toplotna_prevodnost;
        private float difuzijska_upornost;
        private float dr;
        private bool kapilarni_srk;
        private string je_les;


        public string Naziv_materiala
        {
            get
            {
                return naziv_materiala;
            }
            set
            {
                naziv_materiala = value;
                OnPropertyChanged("Naziv_materiala");
            }
        }

        public float Gostota
        {
            get
            {
                return gostota;
            }
            set
            {
                gostota = value;
                OnPropertyChanged("Gostota");
            }
        }

        public float Cp
        {
            get
            {
                return cp;
            }
            set
            {
                cp = value;
                OnPropertyChanged("Cp");
            }
        }

        public float Toplotna_prevodnost
        {
            get
            {
                return toplotna_prevodnost;
            }
            set
            {
                toplotna_prevodnost = value;
                OnPropertyChanged("Toplotna_prevodnost");
            }
        }

        public float Difuzijska_upornost
        {
            get
            {
                return difuzijska_upornost;
            }
            set
            {
                difuzijska_upornost = value;
                OnPropertyChanged("Difuzijska_upornost");
            }
        }

        public float Dr
        {
            get
            {
                return dr;
            }
            set
            {
                dr = value;
                OnPropertyChanged("Dr");
            }
        }
        public bool Kapilarni_srk
        {
            get
            {
                return kapilarni_srk;
            }
            set
            {
                kapilarni_srk = value;
                OnPropertyChanged("Kapilarni_srk");
            }
        }

        public string Je_les
        {
            get
            {
                return je_les;
            }
            set
            {
                je_les = value;
                OnPropertyChanged("Je_les");
            }
        }


        public Material(string naziv_materiala, float gostota, float cp, float toplotna_prevodnost, float difuzijska_upornost, float dr, bool kapilarni_srk, string je_les)
        {
            Naziv_materiala = naziv_materiala;
            Gostota = gostota;
            Cp = cp;
            Toplotna_prevodnost = toplotna_prevodnost;
            Difuzijska_upornost = difuzijska_upornost;
            Dr = dr;
            Kapilarni_srk = kapilarni_srk;
            Je_les = je_les;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}