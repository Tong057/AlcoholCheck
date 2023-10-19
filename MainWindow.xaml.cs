using MaterialDesignThemes.Wpf;
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

        private void ChangeTheme_Click(object sender, RoutedEventArgs e)
        {
            string header = (string)((MenuItem)e.OriginalSource).Header;
            SetTheme(header);
        }

        private void SetTheme(string naming)
        {
            PaletteHelper palette = new PaletteHelper();

            ITheme theme = palette.GetTheme();
            if(naming == "Light Theme")
            {
                theme.SetBaseTheme(Theme.Light);
                theme.SetPrimaryColor(Color.FromArgb(0xFF, 0x1A, 0x1A, 0x1A));
                baseWindow.Background = Brushes.White;
            }
            else
            {
                theme.SetBaseTheme(Theme.Dark);
                theme.SetPrimaryColor((Color)ColorConverter.ConvertFromString("#ffc107")); //ffc107
                baseWindow.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF1A1A1A"));
            }
            
            palette.SetTheme(theme);
            
        }

        private void ExitButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void TurnButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BasePanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
    }
}
