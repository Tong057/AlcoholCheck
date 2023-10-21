using MaterialDesignThemes.Wpf;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;

namespace AlcoholCalculator
{
    /// <summary>
    /// Логика взаимодействия для MessageBoxCustom.xaml
    /// </summary>
    public partial class ResultMessageBox : Window
    {
        private Window _window;
        public ResultMessageBox(double overallVolume, double overallSpirit, Window window)
        {
            InitializeComponent();
            _window = window;
            btnOk.Visibility = Visibility.Visible;
            overallVolumeTextBlock.Text = overallVolume.ToString() + "ml";
            overallSpiritTextBlock.Text = overallSpirit.ToString() + "ml";
            ApplyBlurEffect();
            SetTheme();    
            this.ShowDialog();

        }

        private void SetTheme()
        {
            PaletteHelper palette = new PaletteHelper();
            ITheme theme = palette.GetTheme();

            if (theme.GetBaseTheme().Equals(BaseTheme.Light))
            {
                baseResultWindow.Background = Brushes.White;
            }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
            ClearBlurEffect();
        }

        private void Grid_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void ApplyBlurEffect()
        {
            BlurEffect objBlur = new BlurEffect();
            objBlur.Radius = 5;
            _window.Effect = objBlur;
        }

        private void ClearBlurEffect()
        {
            _window.Effect = null;
        }
    }


}
