using Microsoft.Win32;
using Stopwatch.Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using System.Windows.Threading;

namespace Stopwatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private ObservableStopwatch stopwatch = new ObservableStopwatch();

        public ObservableStopwatch Stopwatch
        {
            get { return stopwatch; }
        }

        private ObservableCollection<TimeSpan> splitTimes = new ObservableCollection<TimeSpan>();

        public ObservableCollection<TimeSpan> SplitTimes
        {
            get { return splitTimes; }
        }
        

        private bool startStopInSplitTimes;


        public RelayCommand Start { get; private set; }
        public RelayCommand Stop { get; private set; }
        public RelayCommand Reset { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            this.startStopInSplitTimes = Settings.Default.StartStopInSplitTimes;
            this.DataContext = this;

            this.Start = new RelayCommand
            (
                delegate (object o)
                {
                    stopwatch.Start(); 
                    if (this.startStopInSplitTimes)
                        this.splitTimes.Add(stopwatch.Elapsed);
                },
                o => !this.stopwatch.IsRunning
            );

            this.Stop = new RelayCommand
            (
                delegate(object o)
                {
                    stopwatch.Stop();
                    if (this.startStopInSplitTimes)
                        this.splitTimes.Add(stopwatch.Elapsed);
                },
                o => this.stopwatch.IsRunning
            );

            this.Reset = new RelayCommand
            (
                delegate(object o)
                {
                    stopwatch.Reset();
                    this.splitTimes.Clear();
                    if (this.startStopInSplitTimes)
                        this.splitTimes.Add(stopwatch.Elapsed);
                },
                o => stopwatch.Elapsed != TimeSpan.Zero
            );


        }

   

        private void mFileExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); 
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            this.splitTimes.Add(stopwatch.Elapsed); 
        }

        

       

        private void mHelpAbout_Click(object sender, RoutedEventArgs e)
        {
            AboutDialog aboutDialog = new AboutDialog();
            aboutDialog.Owner = this;
            aboutDialog.ShowDialog();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            SolidColorBrush colorBrush = (SolidColorBrush)txtDisplay.Foreground;
            colorBrush = (SolidColorBrush)grdDisplay.Background;
            Settings.Default.StartStopInSplitTimes = this.startStopInSplitTimes;
            Settings.Default.Save();
            base.OnClosing(e);
        }

        private void mToolsOptions_Click(object sender, RoutedEventArgs e)
        {
            OptionsDialog optionsDialog = new OptionsDialog();
            SolidColorBrush colorBrush = (SolidColorBrush)txtDisplay.Foreground;
            optionsDialog.DisplayForegroundColor = colorBrush.Color;
            colorBrush = (SolidColorBrush)grdDisplay.Background;
            optionsDialog.DisplayBackgroundColor = colorBrush.Color;
            optionsDialog.StartStopInSplitTimes = this.startStopInSplitTimes;
            bool? dialogResult = optionsDialog.ShowDialog();
            if (dialogResult ?? false)
            {
                this.startStopInSplitTimes = optionsDialog.StartStopInSplitTimes;
                txtDisplay.Foreground = new SolidColorBrush(optionsDialog.DisplayForegroundColor ?? Colors.Black);
                grdDisplay.Background = new SolidColorBrush(optionsDialog.DisplayBackgroundColor ?? Colors.White);
            }
        }

        private void mFileSaveAs_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            bool? dialogResult = sfd.ShowDialog();
            if (dialogResult ?? false)
            {
                StringBuilder sb = new StringBuilder();
                foreach (TimeSpan splitTime in this.splitTimes)
                {
                    sb.AppendLine(splitTime.ToString("hh\\:mm\\:ss\\.ff"));
                }
                File.WriteAllText(sfd.FileName, sb.ToString());
            }
        }
    }
}
