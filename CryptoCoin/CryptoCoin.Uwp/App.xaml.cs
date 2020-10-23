using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace CryptoCoin.Uwp
{
    sealed partial class App
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        private WinRTContainer _container;
        public App()
        {
            Initialize();
            this.InitializeComponent();
            this.Suspending += OnSuspending;
            this.RequestedTheme = ApplicationTheme.Dark;

            // setup root page as a navigation page
            PrepareViewFirst();
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }

        protected override void Configure()
        {
            if (_container == null) //iOC Registration
                _container = new WinRTContainer();
            _container.RegisterWinRTServices();

            //Register all internal services
            RegisterInternalServices.RegisterViewModels(ref _container);
            RegisterInternalServices.RegisterSqliteEncryption(ref _container); //Enable Encryption on the Sqlite Storage
            Subscriptions();
        }

        protected override void PrepareViewFirst(Frame rootFrame)
        {
            _container.Instance<INavigationServiceExtensions>(new DrawboardNavigationAdapter(rootFrame));
        }

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            if (args.PreviousExecutionState == ApplicationExecutionState.Running)
                return;
            else
                DisplayRootView<DrawboardProjectListItemsView>();
        }

        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }

        #region Application Wide Subscriptions
        private void Subscriptions()
        {
            //        SystemNavigationManagerPreview.GetForCurrentView().CloseRequested += App_CloseRequested;
        }

        private void App_CloseRequested(object sender, SystemNavigationCloseRequestedPreviewEventArgs e)
        {
            //If the user decides to close the core window, thus the app, make sure to prompt them with a dialogue to avoid them losing any information

        }

        #endregion
    }
}
