using Stopwatch.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Stopwatch
{
    public class SettingsBinding : Binding
    {
        public SettingsBinding()
        {
            Init();
        }

        private void Init()
        {
            this.Source = Settings.Default;
            this.Mode = BindingMode.TwoWay;
        }

        public SettingsBinding(string path)
            : base(path)
        {
            Init();
        }
    }
}
