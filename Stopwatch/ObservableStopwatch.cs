using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stopwatch
{
    public class ObservableStopwatch : INotifyPropertyChanged
    {
        private System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

        public ObservableStopwatch()
        {
            Thread thread = new Thread(delegate()
                {
                    while (true)
                    {
                        Thread.Sleep(40);
                        NotifyPropertyChanged("Elapsed");
                    }
                });
            thread.IsBackground = true;
            thread.Start();
        }
        
        public TimeSpan Elapsed 
        { 
            get { return this.stopwatch.Elapsed; }
        }

        public bool IsRunning
        {
            get { return this.stopwatch.IsRunning; }
        }

        public void Start()
        {
            this.stopwatch.Start();
            NotifyPropertyChanged("IsRunning");
        }

        public void Stop()
        {
            this.stopwatch.Stop();
            NotifyPropertyChanged("Elapsed");
            NotifyPropertyChanged("IsRunning");
        }

        public void Reset()
        {
            this.stopwatch.Reset();
            NotifyPropertyChanged("Elapsed");
            NotifyPropertyChanged("IsRunning");
        }

        public void Restart()
        {
            this.stopwatch.Restart();
            NotifyPropertyChanged("Elapsed");
        }
        
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName=null)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
