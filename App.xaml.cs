using CommonServiceLocator;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using Unity;
using Unity.Lifetime;
using Unity.ServiceLocation;

namespace LocalizationPoC
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        UnityContainer _container = new UnityContainer();
        protected override void OnStartup(StartupEventArgs e)
        {
            //if (Debugger.IsAttached)
            //    CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            var language = e.Args[0] ?? ConfigurationSettings.AppSettings["language"];
            //var vCulture = new System.Globalization.CultureInfo(Thread.CurrentThread.CurrentUICulture.Name);
            var vCulture = new CultureInfo(language);
            Thread.CurrentThread.CurrentCulture = vCulture;
            Thread.CurrentThread.CurrentUICulture = vCulture;
            CultureInfo.DefaultThreadCurrentCulture = vCulture;
            CultureInfo.DefaultThreadCurrentUICulture = vCulture;

            //   FrameworkElement.LanguageProperty.OverrideMetadata(
            //   typeof(FrameworkElement),
            //   new FrameworkPropertyMetadata(
            //XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));

            Initialize(vCulture);

            base.OnStartup(e);

        }

        private void Initialize(CultureInfo cultureInfo)
        {
            var resourceManager = new ResourceManager(cultureInfo);
            _container.RegisterInstance<ResourceManager>(resourceManager, new ContainerControlledLifetimeManager());
            UnityServiceLocator locator = new UnityServiceLocator(_container);
            ServiceLocator.SetLocatorProvider(() => locator);
        }
    }
}