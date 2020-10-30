using Caliburn.Micro;
using IMDBConsumer.Uwp.PlatformServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBConsumer.Win10.ViewModels
{
    public class BaseViewModel : Screen
    {  //Services & Initialization
        private void InitializeBaseViewModel()
        {
            _aggregator.Subscribe(this); //Subscribe to any Event Aggregator messages -- This will act as the message broker
        }

        private string _Title;
        public string Title
        {
            get { return _Title; }
            set { this.Set(ref _Title, value); }
        }

        protected INavigationServiceExtensions _navigation => IoC.Get<INavigationServiceExtensions>();
        protected IEventAggregator _aggregator => IoC.Get<IEventAggregator>();
        public BaseViewModel() { InitializeBaseViewModel(); }
    }
}
