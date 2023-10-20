using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Effects;

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
            overallVolumeTextBlock.Text += "\n" + overallVolume.ToString() + "ml";
            overallSpiritTextBlock.Text += "\n" + overallSpirit.ToString() + "ml";
            ApplyBlurEffect();
            this.ShowDialog();


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
