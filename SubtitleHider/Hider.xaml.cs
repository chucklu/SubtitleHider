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
using System.Windows.Shapes;

namespace SubtitleHider
{
    /// <summary>
    /// Interaction logic for Hider.xaml
    /// </summary>
    public partial class Hider
    {
        public Hider()
        {
            InitializeComponent();
        }

        public void SetOpacity(int opacityValue)
        {
            this.Opacity = opacityValue;
            myGrid.Opacity = opacityValue;
        }
    }
}
