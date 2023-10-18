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

namespace AlcoholCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // get volume: 500 ml / littleCup(50ml) / middleCup(100ml) / bigCup(150ml) / wineCup(200ml) / beerCup(500ml)
            // get spiritPercentage: 20% / 
            // get glassesAmount: 2

            // show overallVolume: volume * glassesAmount
            // show how much spirit is: overallVolume * spiritPercentage / 100%
        }

    }
}
