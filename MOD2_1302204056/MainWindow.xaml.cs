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

namespace MOD2_1302204056
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        decimal bilangan1;
        decimal bilangan2;
        int penjumlahan;
        Boolean penjumlahanakhir = false;
        public MainWindow()
        {
            InitializeComponent();

           
        }
        private void satu_Click(object sender, RoutedEventArgs e)
        {
            if (layer.Text == "")
            {
                layer.Text = "1";
            }
            else
            {
                layer.Text += "1";
            }
        }

        private void dua_Click(object sender, RoutedEventArgs e)
        {
            if (layer.Text == "")
            {
                layer.Text = "2";
            }
            else
            {
                layer.Text += "2";
            }

        }

        private void tiga_Click(object sender, RoutedEventArgs e)
        {
            if (layer.Text == "")
            {
                layer.Text = "3";
            }
            else
            {
                layer.Text += "3";
            }
        }

        private void empat_Click(object sender, RoutedEventArgs e)
        {
            if (layer.Text == "")
            {
                layer.Text = "4";
            }
            else
            {
                layer.Text += "4";
            }
        }

        private void lima_Click(object sender, RoutedEventArgs e)
        {
            if (layer.Text == "")
            {
                layer.Text = "5";
            }
            else
            {
                layer.Text += "5";
            }
        }

        private void enam_Click(object sender, RoutedEventArgs e)
        {
            if (layer.Text == "")
            {
                layer.Text = "6";
            }
            else
            {
                layer.Text += "6";
            }
        }

        private void tujuh_Click(object sender, RoutedEventArgs e)
        {
            if (layer.Text == "")
            {
                layer.Text = "7";
            }
            else
            {
                layer.Text += "7";
            }
        }

        private void delapan_Click(object sender, RoutedEventArgs e)
        {
            if (layer.Text == "")
            {
                layer.Text = "8";
            }
            else
            {
                layer.Text += "8";
            }
        }

        private void sembilan_Click(object sender, RoutedEventArgs e)
        {
            if (layer.Text == "")
            {
                layer.Text = "9";
            }
            else
            {
                layer.Text += "9";
            }
        }

        private void NOL_Click(object sender, RoutedEventArgs e)
        {
            if (layer.Text == "")
            {
                layer.Text = "0";
            }
            else
            {
                layer.Text += "0";
            }
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            bilangan1 = Convert.ToDecimal(layer.Text);
            layer.Text = " ";
            penjumlahan = 1;
            penjumlahanakhir = true;
        }

        private void sama_Click(object sender, RoutedEventArgs e)
        {
            if (penjumlahanakhir == true)
                bilangan2 = Convert.ToDecimal(layer.Text);
            {
                layer.Text = Convert.ToString(bilangan1 + bilangan2);
            }
        }

    }
}