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
    /// Interaction logic for StrehaKonstrukcijePogled.xaml
    /// </summary>
    public partial class StrehaKonstrukcijePogled : UserControl
    {
        public StrehaKonstrukcijePogled()
        {
            InitializeComponent();
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
