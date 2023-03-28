using System;
using System.Collections.Generic;
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
    /// Interaction logic for ZunanjeKonstrukcijePogled.xaml
    /// </summary>
    public partial class ZunanjeKonstrukcijePogled : UserControl
    {
        public ZunanjeKonstrukcijePogled()
        {
            InitializeComponent();
            zunanja_stena_tip_konstrukcije.Content = "Zunanje stene A<10%";
        }

        private void showConstructionOptions(object sender, RoutedEventArgs e)
        {
            hideConstructionOptions();
            if (Konstrukcije.SelectedItem == zunanja_tip_konstrukcije || Konstrukcije.SelectedItem == zunanja_stena_tip_konstrukcije ||
                Konstrukcije.SelectedItem == stene_proti_stopniscem_in_hodnikom_tip_konstrukcije)
            {
                prezracevanje_label.Visibility = Visibility.Visible;
                prezracevanje_radiobtnDA.Visibility = Visibility.Visible;
                prezracevanje_radiobtnNE.Visibility = Visibility.Visible;
                smer_label.Visibility = Visibility.Visible;
                smer_combobox.Visibility = Visibility.Visible;
            }
            else if (Konstrukcije.SelectedItem == stena_med_stanovanji_tip_konstrukcije)
            {
                meji_na_cono_label.Visibility = Visibility.Visible;
                meji_na_cono_combobox.Visibility = Visibility.Visible;
            }
        }

        public void hideConstructionOptions()
        {
            meji_na_cono_label.Visibility = Visibility.Hidden;
            meji_na_cono_combobox.Visibility = Visibility.Hidden;

            prezracevanje_label.Visibility = Visibility.Hidden;
            prezracevanje_radiobtnDA.Visibility = Visibility.Hidden;
            prezracevanje_radiobtnNE.Visibility = Visibility.Hidden;
            smer_label.Visibility = Visibility.Hidden;
            smer_combobox.Visibility = Visibility.Hidden;
        }

        private void RadioButton_prezracevanje(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.IsChecked == true)
            {
                switch (radioButton.Content.ToString())
                {
                    case "Da":
                        // Do something for red
                        break;
                    case "Ne":
                        // Do something for green
                        break;
                }
            }
        }
    }
}
