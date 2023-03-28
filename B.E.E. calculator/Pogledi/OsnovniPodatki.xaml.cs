using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace B.E.E._calculator.Pogledi
{
    /// <summary>
    /// Interaction logic for OsnovniPodatki.xaml
    /// </summary>
    public partial class OsnovniPodatki : UserControl
    {
        List<Obcina> obcine_list = new List<Obcina>();
        Seznam_obcin seznam_obcin = new Seznam_obcin();
        public OsnovniPodatki()
        {
            InitializeComponent();
            seznam_obcin.load_katastrska_obcina_combobox(obcine_list);
            katastrska_obcina_combobox.ItemsSource = obcine_list;
        }

        private void AtlasURL_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "http://gis.arso.gov.si/atlasokolja/profile.aspx?id=Atlas_Okolja_AXL@Arso",
                UseShellExecute = true
            });
        }
    }
}
