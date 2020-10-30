using IMDBConsumer.Utilities.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core;
using Windows.UI.ViewManagement;

namespace IMDBConsumer.Win10.Configuration
{
    public class WindowConfiguration
    {
        public static void ConfigureApplicationShell()
        {
            ApplicationView.GetForCurrentView().Title = AppInformation.AppName;
        }
    }
}
