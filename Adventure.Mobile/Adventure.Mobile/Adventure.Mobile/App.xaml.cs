using Prism;
using Prism.Ioc;
using Adventure.Mobile.ViewModels;
using Adventure.Mobile.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Adventure.Mobile.ViewModels.Home;
using Adventure.Mobile.Views.Home;
using System.Net.Http;
using System;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Adventure.Mobile.Models.Settings;
using Adventure.Mobile.Services.General;
using Prism.DryIoc;
using Newtonsoft.Json;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Adventure.Mobile
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("/NavigationPage/MainPage");
        }

        //
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

            //var mobileHttpClient = new HttpClient
            //{
            //    BaseAddress = new Uri(settings.ApiEndpoint)
            //};
            //containerRegistry.<IAppSettingService>();
            var mobileSettings = GetAppSettingsAsync(containerRegistry);
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<MenuPage, MenuPageViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<TestPage2, TestPage2ViewModel>();
            containerRegistry.RegisterForNavigation<TestPage3, TestPage3ViewModel>();
        }

        private  MobileSettings GetAppSettingsAsync(IContainerRegistry containerRegistry)
        {
            try
            {
              var container =  ((App)Xamarin.Forms.Application.Current).Container;
                var appSettingService = container.Resolve<IAppSettingService>();
                var settingsString =  appSettingService.ReadAsStringAsync("AppSettings.json").GetAwaiter().GetResult();
                var settings = JsonConvert.DeserializeObject<MobileSettings>(settingsString);
                return settings;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
