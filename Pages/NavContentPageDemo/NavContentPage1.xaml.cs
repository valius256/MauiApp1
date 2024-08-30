namespace MauiApp1.Pages.NavContentPage;

public partial class NavContentPage1 : ContentPage
{
    public NavContentPage1()
    {
        InitializeComponent();
    }

    private void NavContentPage2_OnClicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new NavContentPage2());
    }
}