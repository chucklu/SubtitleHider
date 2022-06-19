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
            hider.WindowStyle = WindowStyle.ToolWindow;
            hider.Height = 75;
            hider.Width = 1125;
            //hider.size
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            hider.Show();
        }
    }
}
