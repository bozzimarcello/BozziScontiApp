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

namespace BozziScontiApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCalcola_Click(object sender, RoutedEventArgs e)
        {
            decimal x = decimal.Parse(TxtImporto.Text);
            decimal s = 0;
            if (x>50)
            {
                if (x>100)
                {
                    s = x * 30 / 100;
                }
                else
                {
                    s = x * 20 / 100;
                }
            }
            else
            {
                s = x * 10 / 100;
            }
            decimal i = x - s;
            LblRisultato.Content = i;
        }
    }
}
