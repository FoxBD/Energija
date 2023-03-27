using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace B.E.E._calculator
{
    public class Seznam_materialov
    {
        public string Naziv_materiala { get; set; }

        public ObservableCollection<Material> seznam_materialov { get; set; } = new ObservableCollection<Material>();
    }
}
