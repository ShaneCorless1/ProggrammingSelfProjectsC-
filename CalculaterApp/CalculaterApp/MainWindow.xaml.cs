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
        SelectedOperater SelectedOperater;

        public MainWindow()
        {
            InitializeComponent();
        



          

        }

        // Methods to code the buttons


        private void Operation_Button(object sender, RoutedEventArgs e)
        {
        
                if (double.TryParse(resultlabel.Content.ToString(), out lastnumber))
                {
                  
                    resultlabel.Content ="0";
                }

                if (sender == Multiplicationbutton)
                {
                    SelectedOperater = SelectedOperater.Multiplication;
                }
                else if (sender == DivisionButton)
                {
                SelectedOperater = SelectedOperater.Division;
                }
                else if (sender == Addbutton )
                {
                SelectedOperater = SelectedOperater.Addition;
                }
                else if (sender == Subtractbutton)
                {
                SelectedOperater = SelectedOperater.Subtraction;

                }

            
            

            
        }
        private void Numberbutton_Click(object sender, RoutedEventArgs e)
        {
            int selectedValue = 0;

            if (sender ==Zerobutton)
            selectedValue = 0;
            else if (sender == Onebutton)
            selectedValue = 1;
            else if (sender == Twobutton)
            selectedValue = 2;
            else if (sender == Threebutton)
            selectedValue = 3;
            else if (sender == Fourbutton)
            selectedValue = 4;
            else if (sender == Fivebutton)
            selectedValue = 5;
            else if (sender == Sixbutton)
            selectedValue = 6;
            else if (sender == sevenbutton)
            selectedValue = 7;
            else if (sender == Eightbutton)
            selectedValue = 8;
            else if (sender == Ninebutton)
            selectedValue = 9;
            



            if (resultlabel.Content.ToString() =="0" )
            {
                resultlabel.Content = $"{selectedValue}";
            }
            else
            {
                resultlabel.Content = $"{resultlabel.Content}7";
            }


        }

     

        private void Equalsbutton_Click(object sender, RoutedEventArgs e)
        {
            double temporaryNumber = 0;

            if (double.TryParse(resultlabel.Content.ToString(), out lastnumber))
            {
                switch (SelectedOperater)
                {
                    case SelectedOperater.Addition:
                        result = SimpleMath.Add(lastnumber, temporaryNumber);
                        break;
                    case SelectedOperater.Subtraction:
                        result = SimpleMath.Subtraction(lastnumber, temporaryNumber);
                        break;
                    case SelectedOperater.Multiplication:
                        result = SimpleMath.Multiply(lastnumber, temporaryNumber);
                        break;
                    case SelectedOperater.Division:
                        result = SimpleMath.Division(lastnumber, temporaryNumber);
                        break;
                                    }
            }
            resultlabel.Content = temporaryNumber.ToString();
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

        private void Decimalbutton_Click(object sender, RoutedEventArgs e)
        {
            if (resultlabel.Content.ToString().Contains("."))
            {
                resultlabel.Content = $"{resultlabel.Content}";
            }
            else
            {
                resultlabel.Content = $"{resultlabel.Content}.";
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

    public enum SelectedOperater
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }

    public class SimpleMath
    {
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }
        public static double Subtraction(double n1, double n2)
        {
            return n1 - n2;
        }
        public static double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }

        public static double Division(double n1, double n2)
        {
            return n1 / n2;
        }

    }
}
