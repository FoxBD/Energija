using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace B.E.E._calculator
{
    public class Seznam_projektov
    {
        public string Naziv_projekta { get; set; }

        public ObservableCollection<Projekt> seznam_projektov { get; set; } = new ObservableCollection<Projekt>();
    }
}
