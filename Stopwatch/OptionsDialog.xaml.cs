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

namespace Stopwatch
{
    /// <summary>
    /// Interaction logic for OptionsDialog.xaml
    /// </summary>
    public partial class OptionsDialog : Window
    {
        public OptionsDialog()
        {
            InitializeComponent();
        }

        public bool StartStopInSplitTimes
        {
            get { return chbStartStopInSplitTimes.IsChecked ?? false; }
            set { chbStartStopInSplitTimes.IsChecked = value; }
        }

        public Color? DisplayForegroundColor
        {
            get { return clpDisplayForegroundColor.SelectedColor; }
            set { clpDisplayForegroundColor.SelectedColor = value; }
        }

        public Color? DisplayBackgroundColor
        {
            get { return clpDisplayBackgroundColor.SelectedColor; }
            set { clpDisplayBackgroundColor.SelectedColor = value; }
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
