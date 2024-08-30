using MauiApp1.Pages.FlyoutPageDemo;

namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            //MainPage = new ContentPage1();

            //var navigationPage = new NavigationPage();
            //navigationPage.BarBackgroundColor = Colors.Firebrick;
            //navigationPage.BarTextColor = Colors.Black;
            //MainPage = new NavigationPage(new NavContentPage1());

            MainPage = new DemoFlyoutPage();
        }
    }
}
