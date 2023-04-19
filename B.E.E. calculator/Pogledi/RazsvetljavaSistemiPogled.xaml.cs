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
    /// Interaction logic for RazsvetljavaSistemiPogled.xaml
    /// </summary>
    public partial class RazsvetljavaSistemiPogled : UserControl
    {
        public RazsvetljavaSistemiPogled()
        {
            InitializeComponent();
        }

        private void faktorUprabeStavbe(object sender, SelectionChangedEventArgs e)
        {
            if (načinVklopaIzklopaSvetilk.SelectedItem == ročni_način_vklopa_izklopa_svetilk)
            {
                faktorUporabeStabe.Text = "0.7 || 0.9 || 1.0";
            }
            else if (načinVklopaIzklopaSvetilk.SelectedItem == avtomatski_način_vklopa_izklopa_svetilk)
            {
                faktorUporabeStabe.Text = "0.55 || 0.85 || 1.0";
            }
            else if (načinVklopaIzklopaSvetilk.SelectedItem == ročno_avtomatski_način_vklopa_izklopa_svetilk)
            {
                faktorUporabeStabe.Text = "0.5 || 0.7 || 1.0";
            }
        }

        private void faktorNaravneOsvetlitve(object sender, SelectionChangedEventArgs e)
        {
            if (VnosFaktorDnevneSvetlobe.Text != null && VnosFaktorDnevneSvetlobe.Text != "")
            {
                double[,] arr = null;
                bool array_choosen = false;
                if (položajTransparentnihGradnikov.SelectedItem == fasade_brez_senčil_položaj_transparentnih_gradnikov)
                {
                    array_choosen = true;
                    arr = new double[11, 2]
                    {
                    { 0.0,1.0 }, {0.13, 0.92 }, { 0.5,0.84 },
                    { 1, 0.79 }, {1.5, 0.75}, {2,0.74 }, {3,0.71 },
                    {5, 0.69}, {8,0.67 }, {12,0.66  }, {18,0.66 }
                    };
                    

                }
                else if (položajTransparentnihGradnikov.SelectedItem == fasade_s_senčili_položaj_transparentnih_gradnikov)
                {
                    array_choosen = true;
                    arr = new double[11, 2]
                    {
                    { 0.0,1.0 }, {0.13, 0.83 }, { 0.5,0.75 },
                    { 1, 0.7 }, {1.5, 0.65}, {2,0.65 }, {3,0.62 },
                    {5, 0.6}, {8,0.57 }, {12,0.56  }, {18,0.56 }
                    };

                }
                else if (položajTransparentnihGradnikov.SelectedItem == stropni_svetlobniki_položaj_transparentnih_gradnikov)
                {
                    array_choosen = true;
                    arr = new double[11, 2]
                    {
                    { 0.0,1.0 }, {0.13, 1.0 }, { 0.5,1.0 },
                    { 1, 1.0 }, {1.5, 1.0}, {2,0.65 }, {3,0.65 },
                    {5, 0.56}, {8,0.51 }, {12,0.51  }, {18,0.51 }
                    };

                }

                if (array_choosen)
                    faktor.Text = faktorNaravneOsvetlitve(Double.Parse(VnosFaktorDnevneSvetlobe.Text), arr).ToString();
            }
        }
        private double faktorNaravneOsvetlitve(double x, double[,] arr)
        {
            bool not_matched = false;
            double stara = x;
            double result = 0;

            int i = 0;
            while (i <= 10 && !not_matched)
            {
                if (x == arr[i, 0])
                {
                    not_matched = true;
                    //Console.WriteLine("Got result:" + arr[i, 1]);
                    return arr[i, 1];
                }
                double razlika = x - arr[i, 0];
                if (razlika < stara && razlika > 0)
                {
                    stara = razlika;
                    result = arr[i, 1];
                }


                i++;
            }
            if (!not_matched)
            {
                //Console.WriteLine("Got result (not matched):" + result);
                return result;
            }
            return -255.0;
        }

        
    }
}
