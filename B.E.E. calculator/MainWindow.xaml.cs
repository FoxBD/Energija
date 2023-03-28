using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;


namespace B.E.E._calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Seznam_projektov Seznam = new Seznam_projektov();

        public MainWindow()
        {
            InitializeComponent();

            Projekt prevzeto = new Projekt("TESTNI PRIMER", "Trata 32, Škofja Loka", "Skofja Loka", 461550, 116360, "Energetsko manj zahtevna stavba", "Rekonstruirana", "DA");
            Seznam.seznam_projektov.Add(prevzeto);
            Pokazi_projekte.ItemsSource = Seznam.seznam_projektov;
        }

        private void add_new_project(object sender, RoutedEventArgs e)
        {
            /*
            string naziv_projekta;
            string ulica_kraj;
            string katastrska_obcina;
            string GKX;
            string GKY;
            string opredelitev_stavbe;
            string vrsta_gradnje;
            string javna_stavba;
            if (naziv_projekta_vnos.Text.Length != 0)
            {
                naziv_projekta = naziv_projekta_vnos.Text;
                ulica_kraj = ulica_kraj_vnos.Text;
                katastrska_obcina = katastrska_obcina_combobox.Text;
                GKX = GKX_vnos.Text;
                GKY = GKY_vnos.Text;
                opredelitev_stavbe = opredelitev_stavbe_combobox.Text;
                vrsta_gradnje = vrsta_gradnje_combobox.Text;
                javna_stavba = javna_stavba_combobox.Text;

                Projekt novProjekt = new Projekt(naziv_projekta, ulica_kraj, katastrska_obcina, int.Parse(GKX), int.Parse(GKY), opredelitev_stavbe, vrsta_gradnje, javna_stavba);
                Seznam.seznam_projektov.Add(novProjekt);
                naziv_projekta_vnos.Text = "";
                ulica_kraj_vnos.Text = "";
                katastrska_obcina_combobox.Text = "";
                GKX_vnos.Text = "";
                GKY_vnos.Text = "";
                opredelitev_stavbe_combobox.Text = "";
                vrsta_gradnje_combobox.Text = "";
                javna_stavba_combobox.Text = "";
            }
        */
        }


        private void delete_project(object sender, RoutedEventArgs e)
        {
            if (Pokazi_projekte.SelectedIndex > -1)
            {
                Seznam.seznam_projektov.RemoveAt(Pokazi_projekte.SelectedIndex);
            }
        }

        
        private void edit_project(object sender, RoutedEventArgs e)
        {
            
            if (Pokazi_projekte.SelectedIndex > -1)
            {
                /*
                naziv_projekta_vnos.Text = Seznam.seznam_projektov.ElementAt(Pokazi_projekte.SelectedIndex).Naziv_projekta;
                
                ulica_kraj_vnos.Text = Seznam.seznam_projektov.ElementAt(Pokazi_projekte.SelectedIndex).Ulica_kraj;
                katastrska_obcina_combobox.Text = Seznam.seznam_projektov.ElementAt(Pokazi_projekte.SelectedIndex).Katastrska_obcina;
                GKX_vnos.Text = Seznam.seznam_projektov.ElementAt(Pokazi_projekte.SelectedIndex).GK_koordinate_kraja_GKX.ToString();
                GKY_vnos.Text = Seznam.seznam_projektov.ElementAt(Pokazi_projekte.SelectedIndex).GK_koordinate_kraja_GKY.ToString();
                opredelitev_stavbe_combobox.Text = Seznam.seznam_projektov.ElementAt(Pokazi_projekte.SelectedIndex).Opredelitev_stavbe;
                vrsta_gradnje_combobox.Text = Seznam.seznam_projektov.ElementAt(Pokazi_projekte.SelectedIndex).Vrsta_gradnje;
                javna_stavba_combobox.Text = Seznam.seznam_projektov.ElementAt(Pokazi_projekte.SelectedIndex).Javna_stavba;
                */
            }
        }


        private void OpenFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML Files (*xml)|*xml | All files (*.*)|*.*";

            if (ofd.ShowDialog() == true)
            {
                if (File.Exists(ofd.FileName))
                {
                    using (TextReader tr = new StreamReader(ofd.FileName))
                    {
                        XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<Projekt>));
                        Seznam.seznam_projektov = (ObservableCollection<Projekt>)xs.Deserialize(tr);
                        Pokazi_projekte.ItemsSource = Seznam.seznam_projektov;
                    }
                }
            }
        }

        private void SaveFile(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML Files (*xml)|*xml";

            if (sfd.ShowDialog() == true)
            {
                using (TextWriter tw = new StreamWriter(sfd.FileName))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<Projekt>));
                    xs.Serialize(tw, Seznam.seznam_projektov);
                }
            }
        }
        
        // -----------------------------------------------------------------------------------------------------------------
    } 
}