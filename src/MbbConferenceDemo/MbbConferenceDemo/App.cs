using System;
using MbbConferenceDemo.Sessions;
using MbbConferenceDemo.Speakers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.MobileBlazorBindings;
using Microsoft.Extensions.Hosting;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MbbConferenceDemo
{
    public class App : Application
    {
        public App()
        {
            var host = MobileBlazorBindingsHost.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    // Register app-specific services
                    //services.AddSingleton<AppState>();
                    services.AddSingleton<ISpeakerService, DummySpeakerService>();
                    services.AddSingleton<ISessionService, DummySessionsService>();
                })
                .Build();

            //MainPage = new ContentPage();
            host.AddComponent<AppShell>(parent: this);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
