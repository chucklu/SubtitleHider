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

namespace SubtitleHider
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Hider hider;

        public MainWindow()
        {
            InitializeComponent();
            InitHider();
        }

        private void InitHider()
        {
            hider = new Hider();
            hider.Topmost = true;
            hider.Height = 75;
            hider.Width = 1125;
            hider.Background = Brushes.Black;
        }

        private void ButtonPopupHider_Click(object sender, RoutedEventArgs e)
        {
            hider.Show();
        }

        private void ButtonSetOpacity_Click(object sender, RoutedEventArgs e)
        {
            var numberString = TextBoxOpacityValue.Text;
            var opacity = Convert.ToDouble(numberString);
            hider.SetOpacity(opacity);
        }

        private void ButtonHideHider_Click(object sender, RoutedEventArgs e)
        {
            hider.SetOpacity(0);
        }

        private void ButtonShowHider_Click(object sender, RoutedEventArgs e)
        {
            hider.SetOpacity(1);
        }
    }
}
