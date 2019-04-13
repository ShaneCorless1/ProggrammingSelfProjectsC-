using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculaterApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Variables to store the last number and the result
        double lastnumber, result;
        public MainWindow()
        {
            InitializeComponent();
        



          

        }


        private void Sevenbutton_Click(object sender, RoutedEventArgs e)
        {
            if (resultlabel.Content.ToString() =="0" )
            {
                resultlabel.Content = "7";
            }
            else
            {
                resultlabel.Content = $"{resultlabel.Content}7";
            }


        }

        private void Twobutton_Click(object sender, RoutedEventArgs e)
        {
            if (resultlabel.Content.ToString() =="0")
            {
                resultlabel.Content = "2";
            }
            else
            {
                resultlabel.Content = $"{resultlabel.Content}2";
            }
        }

        private void Equalsbutton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Addbutton_Click(object sender, RoutedEventArgs e)
        {
            resultlabel.Content = $"{resultlabel.Content}+";
        }

        private void ACbutton_Click(object sender, RoutedEventArgs e)
        {
            resultlabel.Content = 0;
        }

        private void Percentagebutton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultlabel.Content.ToString(), out lastnumber))
            {
                lastnumber = lastnumber / 100;
                resultlabel.Content = lastnumber.ToString();
            }
        }

        private void Negativebutton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultlabel.Content.ToString(), out lastnumber))
            {
                lastnumber = lastnumber * -1;
                resultlabel.Content = lastnumber.ToString();
            }
        }
    }
}
