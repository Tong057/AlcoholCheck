using MaterialDesignThemes.Wpf;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;

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

            //alcoholComboBox.ItemsSource = myDrink.FormattedData;

            SetComboBoxes();


        }

        private void SetComboBoxes()
        {
            glassVolumeComboBox.ItemsSource = Glass.GlassDictionaryToString;
            alcoholPercentageComboBox.ItemsSource = Drink.DrinkDictionaryToString;

            for (int i = 1; i <= 10; i++)
            {
                glassNumberComboBox.Items.Add(i);
            }
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
            if (naming == "Light Theme")
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
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void ApplyBlurEffect(Window window)
        {
            BlurEffect objBlur = new BlurEffect();
            objBlur.Radius = 5;
            window.Effect = objBlur;
        }

        private void ClearBlurEffect(Window window)
        {
            window.Effect = null;
        }

        private void Count_Click(object sender, RoutedEventArgs e)
        {
            if (glassVolumeComboBox.Text == "" || alcoholPercentageComboBox.Text == "" || glassNumberComboBox.Text == "")
            {
                new MessageBoxCustom("Oops.. Some fields are empty.", MessageType.Error, MessageButtons.Ok, this);
            }
            else
            {
                Drink drink;
                Glass glass;

                DrinkType drinkType = GetDrinkTypeFromSelectedText();
                if (drinkType != DrinkType.CustomDrink)
                    drink = new Drink(drinkType);
                else if (int.TryParse(alcoholPercentageComboBox.Text, out int spiritPercentage))
                    drink = new Drink(spiritPercentage);
                else
                    return;

                GlassType glassType = GetGlassTypeFromSelectedText();
                if (glassType != GlassType.CustomGlass)
                    glass = new Glass(glassType);
                else if (int.TryParse(glassVolumeComboBox.Text, out int glassVolume))
                    glass = new Glass(glassVolume);
                else
                    return;

                int.TryParse(glassNumberComboBox.Text, out int glassNumber);

                AlcoholDrinkCalculator calculator = new AlcoholDrinkCalculator(drink, glass, glassNumber);

                new ResultMessageBox(calculator.OverallVolumeOfDrink(), calculator.OverallSpiritInDrink(), this);
            }

        }

        private DrinkType GetDrinkTypeFromSelectedText()
        {
            foreach (var kvp in Drink.DrinkDictionary)
            {
                if (alcoholPercentageComboBox.Text.Contains($"{kvp.Key} - {kvp.Value}%"))
                {
                    return kvp.Key;
                }
            }
            return DrinkType.CustomDrink;
        }

        private GlassType GetGlassTypeFromSelectedText()
        {
            foreach (var kvp in Glass.GlassDictionary)
            {
                if (glassVolumeComboBox.Text.Contains($"{kvp.Key} - {kvp.Value}ml"))
                {
                    return kvp.Key;
                }
            }
            return GlassType.CustomGlass;
        }





    }
}
