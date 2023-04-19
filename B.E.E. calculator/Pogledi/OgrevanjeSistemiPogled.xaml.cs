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
    /// Interaction logic for OgrevanjeSistemiPogled.xaml
    /// </summary>
    public partial class OgrevanjeSistemiPogled : UserControl
    {
        public OgrevanjeSistemiPogled()
        {
            InitializeComponent();
        }

        private void CheckboxKotel1(object sender, RoutedEventArgs e)
        {
            if ((bool)((CheckBox)sender).IsChecked) // Active
            {
                label_kotel1.IsEnabled = true;
                label_kotel1.Opacity = 1;

                ime_kotel1.IsEnabled = true;
                ime_kotel1.Opacity = 1;

                namembnost_kotel1.IsEnabled = true;
                namembnost_kotel1.Opacity = 1;

                moc_kotel1.IsEnabled = true;
                moc_kotel1.Opacity = 1;

                ogrevanje_kotel1.IsEnabled = true;
                ogrevanje_kotel1.Opacity = 1;

                drsnik_kotel1.IsEnabled = true;
                drsnik_kotel1.Opacity = 1;

                voda_kotel1.IsEnabled = true;
                voda_kotel1.Opacity = 1;
            }
            else // Unactive
            {
                label_kotel1.IsEnabled = false;
                label_kotel1.Opacity = 0.5;

                ime_kotel1.IsEnabled = false;
                ime_kotel1.Opacity = 0.5;
                ime_kotel1.Text = "";

                namembnost_kotel1.IsEnabled = false;
                namembnost_kotel1.Opacity = 0.5;
                namembnost_kotel1.Text = "";

                moc_kotel1.IsEnabled = false;
                moc_kotel1.Opacity = 0.5;
                moc_kotel1.Text = "";

                ogrevanje_kotel1.IsEnabled = false;
                ogrevanje_kotel1.Opacity = 0.5;
                ogrevanje_kotel1.Text = "50%";


                drsnik_kotel1.IsEnabled = false;
                drsnik_kotel1.Opacity = 0.5;
                drsnik_kotel1.Value = 50;

                voda_kotel1.IsEnabled = false;
                voda_kotel1.Opacity = 0.5;
                voda_kotel1.Text = "50%";

            }
        }

        private void CheckboxKotel2(object sender, RoutedEventArgs e)
        {
            if ((bool)((CheckBox)sender).IsChecked) // Active
            {
                label_kotel2.IsEnabled = true;
                label_kotel2.Opacity = 1;

                ime_kotel2.IsEnabled = true;
                ime_kotel2.Opacity = 1;

                namembnost_kotel2.IsEnabled = true;
                namembnost_kotel2.Opacity = 1;

                moc_kotel2.IsEnabled = true;
                moc_kotel2.Opacity = 1;

                ogrevanje_kotel2.IsEnabled = true;
                ogrevanje_kotel2.Opacity = 1;

                drsnik_kotel2.IsEnabled = true;
                drsnik_kotel2.Opacity = 1;

                voda_kotel2.IsEnabled = true;
                voda_kotel2.Opacity = 1;
            }
            else // Unactive
            {
                label_kotel2.IsEnabled = false;
                label_kotel2.Opacity = 0.5;

                ime_kotel2.IsEnabled = false;
                ime_kotel2.Opacity = 0.5;
                ime_kotel2.Text = "";

                namembnost_kotel2.IsEnabled = false;
                namembnost_kotel2.Opacity = 0.5;
                namembnost_kotel2.Text = "";

                moc_kotel2.IsEnabled = false;
                moc_kotel2.Opacity = 0.5;
                moc_kotel2.Text = "";

                ogrevanje_kotel2.IsEnabled = false;
                ogrevanje_kotel2.Opacity = 0.5;
                ogrevanje_kotel2.Text = "";


                drsnik_kotel2.IsEnabled = false;
                drsnik_kotel2.Opacity = 0.5;
                drsnik_kotel2.Value = 50;

                voda_kotel2.IsEnabled = false;
                voda_kotel2.Opacity = 0.5;
                voda_kotel2.Text = "";

            }
        }

        private void CheckboxKotel3(object sender, RoutedEventArgs e)
        {
            if ((bool)((CheckBox)sender).IsChecked) // Active
            {
                label_kotel3.IsEnabled = true;
                label_kotel3.Opacity = 1;

                ime_kotel3.IsEnabled = true;
                ime_kotel3.Opacity = 1;

                namembnost_kotel3.IsEnabled = true;
                namembnost_kotel3.Opacity = 1;

                moc_kotel3.IsEnabled = true;
                moc_kotel3.Opacity = 1;

                ogrevanje_kotel3.IsEnabled = true;
                ogrevanje_kotel3.Opacity = 1;

                drsnik_kotel3.IsEnabled = true;
                drsnik_kotel3.Opacity = 1;

                voda_kotel3.IsEnabled = true;
                voda_kotel3.Opacity = 1;
            }
            else // Unactive
            {
                label_kotel3.IsEnabled = false;
                label_kotel3.Opacity = 0.5;

                ime_kotel3.IsEnabled = false;
                ime_kotel3.Opacity = 0.5;
                ime_kotel3.Text = "";

                namembnost_kotel3.IsEnabled = false;
                namembnost_kotel3.Opacity = 0.5;
                namembnost_kotel3.Text = "";

                moc_kotel3.IsEnabled = false;
                moc_kotel3.Opacity = 0.5;
                moc_kotel3.Text = "";

                ogrevanje_kotel3.IsEnabled = false;
                ogrevanje_kotel3.Opacity = 0.5;
                ogrevanje_kotel3.Text = "";


                drsnik_kotel3.IsEnabled = false;
                drsnik_kotel3.Opacity = 0.5;
                drsnik_kotel3.Value = 50;

                voda_kotel3.IsEnabled = false;
                voda_kotel3.Opacity = 0.5;
                voda_kotel3.Text = "";

            }
        }

        private void CheckboxKotel4(object sender, RoutedEventArgs e)
        {
            if ((bool)((CheckBox)sender).IsChecked) // Active
            {
                label_kotel4.IsEnabled = true;
                label_kotel4.Opacity = 1;

                ime_kotel4.IsEnabled = true;
                ime_kotel4.Opacity = 1;

                namembnost_kotel4.IsEnabled = true;
                namembnost_kotel4.Opacity = 1;

                moc_kotel4.IsEnabled = true;
                moc_kotel4.Opacity = 1;

                ogrevanje_kotel4.IsEnabled = true;
                ogrevanje_kotel4.Opacity = 1;

                drsnik_kotel4.IsEnabled = true;
                drsnik_kotel4.Opacity = 1;

                voda_kotel4.IsEnabled = true;
                voda_kotel4.Opacity = 1;
            }
            else // Unactive
            {
                label_kotel4.IsEnabled = false;
                label_kotel4.Opacity = 0.5;

                ime_kotel4.IsEnabled = false;
                ime_kotel4.Opacity = 0.5;
                ime_kotel4.Text = "";

                namembnost_kotel4.IsEnabled = false;
                namembnost_kotel4.Opacity = 0.5;
                namembnost_kotel4.Text = "";

                moc_kotel4.IsEnabled = false;
                moc_kotel4.Opacity = 0.5;
                moc_kotel4.Text = "";

                ogrevanje_kotel4.IsEnabled = false;
                ogrevanje_kotel4.Opacity = 0.5;
                ogrevanje_kotel4.Text = "";


                drsnik_kotel4.IsEnabled = false;
                drsnik_kotel4.Opacity = 0.5;
                drsnik_kotel4.Value = 50;

                voda_kotel4.IsEnabled = false;
                voda_kotel4.Opacity = 0.5;
                voda_kotel4.Text = "";

            }
        }

        private void CheckboxKotel5(object sender, RoutedEventArgs e)
        {
            if ((bool)((CheckBox)sender).IsChecked) // Active
            {
                label_kotel5.IsEnabled = true;
                label_kotel5.Opacity = 1;

                ime_kotel5.IsEnabled = true;
                ime_kotel5.Opacity = 1;

                namembnost_kotel5.IsEnabled = true;
                namembnost_kotel5.Opacity = 1;

                moc_kotel5.IsEnabled = true;
                moc_kotel5.Opacity = 1;

                ogrevanje_kotel5.IsEnabled = true;
                ogrevanje_kotel5.Opacity = 1;

                drsnik_kotel5.IsEnabled = true;
                drsnik_kotel5.Opacity = 1;

                voda_kotel5.IsEnabled = true;
                voda_kotel5.Opacity = 1;
            }
            else // Unactive
            {
                label_kotel5.IsEnabled = false;
                label_kotel5.Opacity = 0.5;

                ime_kotel5.IsEnabled = false;
                ime_kotel5.Opacity = 0.5;
                ime_kotel5.Text = "";

                namembnost_kotel5.IsEnabled = false;
                namembnost_kotel5.Opacity = 0.5;
                namembnost_kotel5.Text = "";

                moc_kotel5.IsEnabled = false;
                moc_kotel5.Opacity = 0.5;
                moc_kotel5.Text = "";

                ogrevanje_kotel5.IsEnabled = false;
                ogrevanje_kotel5.Opacity = 0.5;
                ogrevanje_kotel5.Text = "";


                drsnik_kotel5.IsEnabled = false;
                drsnik_kotel5.Opacity = 0.5;
                drsnik_kotel5.Value = 50;

                voda_kotel5.IsEnabled = false;
                voda_kotel5.Opacity = 0.5;
                voda_kotel5.Text = "";

            }
        }

        private void drsnik_value_kotel1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int value = (int)e.NewValue;
            ogrevanje_kotel1.Text = value.ToString() + "%";
            value = 100 - value;
            voda_kotel1.Text = value.ToString() + "%";
        }
        private void drsnik_value_kotel2(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int value = (int)e.NewValue;
            ogrevanje_kotel2.Text = value.ToString() + "%";
            value = 100 - value;
            voda_kotel2.Text = value.ToString() + "%";
        }
        private void drsnik_value_kotel3(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int value = (int)e.NewValue;
            ogrevanje_kotel3.Text = value.ToString() + "%";
            value = 100 - value;
            voda_kotel3.Text = value.ToString() + "%";
        }
        private void drsnik_value_kotel4(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int value = (int)e.NewValue;
            ogrevanje_kotel4.Text = value.ToString() + "%";
            value = 100 - value;
            voda_kotel4.Text = value.ToString() + "%";
        }
        private void drsnik_value_kotel5(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int value = (int)e.NewValue;
            ogrevanje_kotel5.Text = value.ToString() + "%";
            value = 100 - value;
            voda_kotel5.Text = value.ToString() + "%";
        }

        private void namembnost_drsnik_prikazi_kotel1(object sender, SelectionChangedEventArgs e)
        {
            if (namembnost_kotel1.SelectedItem == ogrevanje_in_topla_voda_kot1)
            {
                drsnik_kotel1.IsEnabled = true;
                drsnik_kotel1.Opacity = 1;
                drsnik_kotel1.Value = 50;

                voda_kotel1.IsEnabled = true;
                voda_kotel1.Opacity = 1;
                voda_kotel1.Text = "50%";

                ogrevanje_kotel1.IsEnabled = true;
                ogrevanje_kotel1.Opacity = 1;
                ogrevanje_kotel1.Text = "50%";
            } else if (namembnost_kotel1.SelectedItem == samo_ogrevanje_kot1)
            {
                drsnik_kotel1.IsEnabled = false;
                drsnik_kotel1.Opacity = 0.5;
                drsnik_kotel1.Value = 0;

                voda_kotel1.IsEnabled = false;
                voda_kotel1.Opacity = 0.5;
                voda_kotel1.Text = "0%";

                ogrevanje_kotel1.IsEnabled = false;
                ogrevanje_kotel1.Opacity = 0.5;
                ogrevanje_kotel1.Text = "100%";
            } else if (namembnost_kotel1.SelectedItem == samo_topla_voda_kot1)
            {
                drsnik_kotel1.IsEnabled = false;
                drsnik_kotel1.Opacity = 0.5;
                drsnik_kotel1.Value = 100;

                voda_kotel1.IsEnabled = false;
                voda_kotel1.Opacity = 0.5;
                voda_kotel1.Text = "100%";

                ogrevanje_kotel1.IsEnabled = false;
                ogrevanje_kotel1.Opacity = 0.5;
                ogrevanje_kotel1.Text = "0%";
            }
        }

        private void namembnost_drsnik_prikazi_kotel2(object sender, SelectionChangedEventArgs e)
        {
            if (namembnost_kotel2.SelectedItem == ogrevanje_in_topla_voda_kot2)
            {
                drsnik_kotel2.IsEnabled = true;
                drsnik_kotel2.Opacity = 1;
                drsnik_kotel2.Value = 50;

                voda_kotel2.IsEnabled = true;
                voda_kotel2.Opacity = 1;
                voda_kotel2.Text = "50%";

                ogrevanje_kotel2.IsEnabled = true;
                ogrevanje_kotel2.Opacity = 1;
                ogrevanje_kotel2.Text = "50%";
            }
            else if (namembnost_kotel2.SelectedItem == samo_ogrevanje_kot2)
            {
                drsnik_kotel2.IsEnabled = false;
                drsnik_kotel2.Opacity = 0.5;
                drsnik_kotel2.Value = 0;

                voda_kotel2.IsEnabled = false;
                voda_kotel2.Opacity = 0.5;
                voda_kotel2.Text = "0%";

                ogrevanje_kotel2.IsEnabled = false;
                ogrevanje_kotel2.Opacity = 0.5;
                ogrevanje_kotel2.Text = "100%";
            }
            else if (namembnost_kotel2.SelectedItem == samo_topla_voda_kot2)
            {
                drsnik_kotel2.IsEnabled = false;
                drsnik_kotel2.Opacity = 0.5;
                drsnik_kotel2.Value = 100;

                voda_kotel2.IsEnabled = false;
                voda_kotel2.Opacity = 0.5;
                voda_kotel2.Text = "100%";

                ogrevanje_kotel2.IsEnabled = false;
                ogrevanje_kotel2.Opacity = 0.5;
                ogrevanje_kotel2.Text = "0%";
            }
        }

        private void namembnost_drsnik_prikazi_kotel3(object sender, SelectionChangedEventArgs e)
        {
            if (namembnost_kotel3.SelectedItem == ogrevanje_in_topla_voda_kot3)
            {
                drsnik_kotel3.IsEnabled = true;
                drsnik_kotel3.Opacity = 1;
                drsnik_kotel3.Value = 50;

                voda_kotel3.IsEnabled = true;
                voda_kotel3.Opacity = 1;
                voda_kotel3.Text = "50%";

                ogrevanje_kotel3.IsEnabled = true;
                ogrevanje_kotel3.Opacity = 1;
                ogrevanje_kotel3.Text = "50%";
            }
            else if (namembnost_kotel3.SelectedItem == samo_ogrevanje_kot3)
            {
                drsnik_kotel3.IsEnabled = false;
                drsnik_kotel3.Opacity = 0.5;
                drsnik_kotel3.Value = 0;

                voda_kotel3.IsEnabled = false;
                voda_kotel3.Opacity = 0.5;
                voda_kotel3.Text = "0%";

                ogrevanje_kotel3.IsEnabled = false;
                ogrevanje_kotel3.Opacity = 0.5;
                ogrevanje_kotel3.Text = "100%";
            }
            else if (namembnost_kotel3.SelectedItem == samo_topla_voda_kot3)
            {
                drsnik_kotel3.IsEnabled = false;
                drsnik_kotel3.Opacity = 0.5;
                drsnik_kotel3.Value = 100;

                voda_kotel3.IsEnabled = false;
                voda_kotel3.Opacity = 0.5;
                voda_kotel3.Text = "100%";

                ogrevanje_kotel3.IsEnabled = false;
                ogrevanje_kotel3.Opacity = 0.5;
                ogrevanje_kotel3.Text = "0%";
            }
        }

        private void namembnost_drsnik_prikazi_kotel4(object sender, SelectionChangedEventArgs e)
        {
            if (namembnost_kotel4.SelectedItem == ogrevanje_in_topla_voda_kot4)
            {
                drsnik_kotel4.IsEnabled = true;
                drsnik_kotel4.Opacity = 1;
                drsnik_kotel4.Value = 50;

                voda_kotel4.IsEnabled = true;
                voda_kotel4.Opacity = 1;
                voda_kotel4.Text = "50%";

                ogrevanje_kotel4.IsEnabled = true;
                ogrevanje_kotel4.Opacity = 1;
                ogrevanje_kotel4.Text = "50%";
            }
            else if (namembnost_kotel4.SelectedItem == samo_ogrevanje_kot4)
            {
                drsnik_kotel4.IsEnabled = false;
                drsnik_kotel4.Opacity = 0.5;
                drsnik_kotel4.Value = 0;

                voda_kotel4.IsEnabled = false;
                voda_kotel4.Opacity = 0.5;
                voda_kotel4.Text = "0%";

                ogrevanje_kotel4.IsEnabled = false;
                ogrevanje_kotel4.Opacity = 0.5;
                ogrevanje_kotel4.Text = "100%";
            }
            else if (namembnost_kotel4.SelectedItem == samo_topla_voda_kot4)
            {
                drsnik_kotel4.IsEnabled = false;
                drsnik_kotel4.Opacity = 0.5;
                drsnik_kotel4.Value = 100;

                voda_kotel4.IsEnabled = false;
                voda_kotel4.Opacity = 0.5;
                voda_kotel4.Text = "100%";

                ogrevanje_kotel4.IsEnabled = false;
                ogrevanje_kotel4.Opacity = 0.5;
                ogrevanje_kotel4.Text = "0%";
            }
        }

        private void namembnost_drsnik_prikazi_kotel5(object sender, SelectionChangedEventArgs e)
        {
            if (namembnost_kotel5.SelectedItem == ogrevanje_in_topla_voda_kot5)
            {
                drsnik_kotel5.IsEnabled = true;
                drsnik_kotel5.Opacity = 1;
                drsnik_kotel5.Value = 50;

                voda_kotel5.IsEnabled = true;
                voda_kotel5.Opacity = 1;
                voda_kotel5.Text = "50%";

                ogrevanje_kotel5.IsEnabled = true;
                ogrevanje_kotel5.Opacity = 1;
                ogrevanje_kotel5.Text = "50%";
            }
            else if (namembnost_kotel5.SelectedItem == samo_ogrevanje_kot5)
            {
                drsnik_kotel5.IsEnabled = false;
                drsnik_kotel5.Opacity = 0.5;
                drsnik_kotel5.Value = 0;

                voda_kotel5.IsEnabled = false;
                voda_kotel5.Opacity = 0.5;
                voda_kotel5.Text = "0%";

                ogrevanje_kotel5.IsEnabled = false;
                ogrevanje_kotel5.Opacity = 0.5;
                ogrevanje_kotel5.Text = "100%";
            }
            else if (namembnost_kotel5.SelectedItem == samo_topla_voda_kot5)
            {
                drsnik_kotel5.IsEnabled = false;
                drsnik_kotel5.Opacity = 0.5;
                drsnik_kotel5.Value = 100;

                voda_kotel5.IsEnabled = false;
                voda_kotel5.Opacity = 0.5;
                voda_kotel5.Text = "100%";

                ogrevanje_kotel5.IsEnabled = false;
                ogrevanje_kotel5.Opacity = 0.5;
                ogrevanje_kotel5.Text = "0%";
            }
        }
    }
}
