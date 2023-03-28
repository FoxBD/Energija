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
    /// Interaction logic for ConePogled.xaml
    /// </summary>
    public partial class ConePogled : UserControl
    {
        public ConePogled()
        {
            InitializeComponent();
        }

        private void showMechanicOptions(object sender, RoutedEventArgs e)
        {
            if (Prezracevanje.SelectedItem == naravno_prezracevanje)
            {
                regulacija_label.Visibility = Visibility.Hidden;
                regulacija_combobox.Visibility = Visibility.Hidden;
                regulacija_combobox.SelectedItem = prazno_regulacija;

                doveden_zrak_label.Visibility = Visibility.Hidden;
                doveden_zrak_mh_label.Visibility = Visibility.Hidden;
                doveden_zrak_V_label.Visibility = Visibility.Hidden;
                doveden_zrak_vnos.Visibility = Visibility.Hidden;
                doveden_zrak_vnos.Text = string.Empty;

                izmenjava_zraka_label.Content = "Št. izmenjav zraka";
                izmenjava_zraka_n_label.Content = "n";
                izmenjava_zraka_h1_label.Content = "h-1";

                lega_label.Visibility = Visibility.Hidden;
                lega_combobox.Visibility = Visibility.Hidden;

                zavetrovanost_label.Visibility = Visibility.Hidden;
                zavetrovanost_combobox.Visibility = Visibility.Hidden;

                vracanje_toplote_label.Visibility = Visibility.Hidden;
                vracanje_toplote_n_label.Visibility = Visibility.Hidden;
                vracanje_toplote_percent_label.Visibility = Visibility.Hidden;
                vracanje_toplote_vnos.Visibility = Visibility.Hidden;
                vracanje_toplote_vnos.Text = string.Empty;
            }
            else
            {
                regulacija_label.Visibility = Visibility.Visible;
                regulacija_combobox.Visibility = Visibility.Visible;

                doveden_zrak_label.Visibility = Visibility.Visible;
                doveden_zrak_mh_label.Visibility = Visibility.Visible;
                doveden_zrak_V_label.Visibility = Visibility.Visible;
                doveden_zrak_vnos.Visibility = Visibility.Visible;

                izmenjava_zraka_label.Content = "Povprečna količina dovedenega zraka";
                izmenjava_zraka_n_label.Content = "Vdov";
                izmenjava_zraka_h1_label.Content = "m³/h";

                lega_label.Visibility = Visibility.Visible;
                lega_combobox.Visibility = Visibility.Visible;

                zavetrovanost_label.Visibility = Visibility.Visible;
                zavetrovanost_combobox.Visibility = Visibility.Visible;

                vracanje_toplote_label.Visibility = Visibility.Visible;
                vracanje_toplote_n_label.Visibility = Visibility.Visible;
                vracanje_toplote_percent_label.Visibility = Visibility.Visible;
                vracanje_toplote_vnos.Visibility = Visibility.Visible;
            }
        }
    }
}
