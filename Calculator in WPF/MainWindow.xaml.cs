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


namespace Calculator_in_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string? clickedButtonContent;
        private double? num1 = null;
        private double? num2 = null;
        private bool divide = false;
        private bool subtrac = false;
        private bool multipy = false;
        private bool plus = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Num_Click(object sender, RoutedEventArgs e)
        {


            if (sender is Button button)
            {
                clickedButtonContent = button.Content.ToString();
            }
            console.Content += clickedButtonContent;



        }

        private void decimalOne_btn_Click(object sender, RoutedEventArgs e)
        {

            double result = 1 / double.Parse(console.Content.ToString());
            console.Content = result.ToString();

        }

        private void btn_minus_plus_Click(object sender, RoutedEventArgs e)
        {
            double result = double.Parse(console.Content.ToString());

            result *= -1;
            console.Content = result.ToString();

        }

        private void btn_xSquared_Click(object sender, RoutedEventArgs e)
        {
            double result = double.Parse(console.Content.ToString());
            result *= result;
            console.Content = result.ToString();
        }

        private void btn_C_Click(object sender, RoutedEventArgs e)
        {
            console.Content = "";
        }

        private void btn_root_Click(object sender, RoutedEventArgs e)
        {
            double result = double.Parse(console.Content.ToString());
            result = Math.Sqrt(result);
            console.Content = result.ToString();
        }

        private void btn_dote_Click(object sender, RoutedEventArgs e)
        {
            bool check = true;
            if (console.Content != "")
            {
                string str = console.Content.ToString();
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '.')
                    {
                        check = false;
                    }
                }
                if (check)
                {
                    console.Content += ".";
                }
            }

        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            string str = console.Content.ToString();
            if (console.Content != "")
            {
                console.Content = str.Remove(str.Length - 1);

            }

        }

        private void btn_divide_Click(object sender, RoutedEventArgs e)
        {
            divide = true;
            if (console.Content != "")
            {
                if (num1 == null)
                {
                    num1 = double.Parse(console.Content.ToString());
                    console.Content = "";
                }
                else
                {
                    num2 = double.Parse(console.Content.ToString());
                    console.Content = (num1 / num2).ToString();
                    num1 = null;
                    num2 = null;
                }

            }

        }

        private void btn_multipy_Click(object sender, RoutedEventArgs e)
        {
            multipy = true;
            if (console.Content != "")
            {
                if (num1 == null)
                {
                    num1 = double.Parse(console.Content.ToString());
                    console.Content = "";
                }
                else
                {
                    num2 = double.Parse(console.Content.ToString());
                    console.Content = (num1 * num2).ToString();
                    num1 = null;
                    num2 = null;
                }

            }
        }

        private void btn_subtrac_Click(object sender, RoutedEventArgs e)
        {
            subtrac = true;
            if (console.Content != "")
            {
                if (num1 == null)
                {
                    num1 = double.Parse(console.Content.ToString());
                    console.Content = "";
                }
                else
                {
                    num2 = double.Parse(console.Content.ToString());
                    console.Content = (num1 - num2).ToString();
                    num1 = null;
                    num2 = null;
                }

            }
        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            plus = true;
            if (console.Content != "")
            {
                if (num1 == null)
                {
                    num1 = double.Parse(console.Content.ToString());
                    console.Content = "";
                }
                else
                {
                    num2 = double.Parse(console.Content.ToString());
                    console.Content = (num1 + num2).ToString();
                    num1 = null;
                    num2 = null;
                }

            }
        }

        private void btn_equal_Click(object sender, RoutedEventArgs e)
        {
            num2 = double.Parse(console.Content.ToString());
            if (divide)
            {
                console.Content = (num1 / num2).ToString();
            }
            else if (multipy)
            {
                console.Content = (num1 * num2).ToString();
            }
            else if (subtrac)
            {
                console.Content = (num1 - num2).ToString();
            }
            else if (plus)
            {
                console.Content = (num1 + num2).ToString();
            }
        }
    }
}
