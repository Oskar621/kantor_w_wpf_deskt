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

namespace kantor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            wypelnij_waluty(); 
        }
        private void wypelnij_waluty()
        {
            waluta1.Items.Add("Euro");
            waluta1.Items.Add("USD");
            waluta1.Items.Add("Yen");
            waluta1.Items.Add("PLN");
            waluta1.Items.Add("Won");

            waluta2.Items.Add("Euro");
            waluta2.Items.Add("USD");
            waluta2.Items.Add("Yen");
            waluta2.Items.Add("PLN");
            waluta2.Items.Add("Won");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtPLN.Text == "" || waluta1.Text == "" || waluta2.Text == "")
            {
                MessageBox.Show("Pola nie moga byc puste");
                return;
            }

            string Waluta1 = waluta1.Text;
            string Waluta2 = waluta2.Text;

            double ilosc = Convert.ToDouble(txtPLN.Text);
            double przelicznik = 1;

            if(Waluta1 == "PLN")
            {
                switch (Waluta2)
                {
                    case "Euro":
                        przelicznik = 0.21;
                        break;
                    case "Yen":
                        przelicznik = 30.10;
                        break;
                    case "Won":
                        przelicznik = 290.72;
                        break;
                    case "USD":
                        przelicznik = 0.22;
                        break;
                }
            }
            else if (Waluta1 == "Euro")
            {
                switch (Waluta2)
                {
                    case "PLN":
                        przelicznik = 4.76;
                        break;
                    case "Yen":
                        przelicznik = 143.31;
                        break;
                    case "Won":
                        przelicznik = 1383.53;
                        break;
                    case "USD":
                        przelicznik = 1.07;
                        break;
                }
            }
            else if (Waluta1 == "Won")
            {
                switch (Waluta2)
                {
                    case "PLN":
                        przelicznik = 0.0034;
                        break;
                    case "Yen":
                        przelicznik = 0.10;
                        break;
                    case "Euro":
                        przelicznik = 0.00072;
                        break;
                    case "USD":
                        przelicznik = 0.00077;
                        break;
                }
            }
            else if (Waluta1 == "USD")
            {
                switch (Waluta2)
                {
                    case "PLN":
                        przelicznik = 4.45;
                        break;
                    case "Yen":
                        przelicznik = 134.07;
                        break;
                    case "Euro":
                        przelicznik = 0.94;
                        break;
                    case "Won":
                        przelicznik = 129.23;
                        break;
                }
            }
            else
            {
                switch (Waluta2)
                {
                    case "PLN":
                        przelicznik = 0.033;
                        break;
                    case "USD":
                        przelicznik = 0.0075;
                        break;
                    case "Euro":
                        przelicznik = 0.0070;
                        break;
                    case "Won":
                        przelicznik = 9.65;
                        break;
                }
            }


            double wynik = (double)ilosc * przelicznik;

            string odpowiedz  = "Po przeliczeniu wynik to: " + Environment.NewLine + wynik + " " + Waluta2;

            doprzelicz.Text = odpowiedz;
        }
    }
}

