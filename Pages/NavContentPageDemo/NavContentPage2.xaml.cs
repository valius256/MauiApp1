namespace MauiApp1.Pages.NavContentPage;

public partial class NavContentPage2 : ContentPage
{
    public NavContentPage2()
    {
        InitializeComponent();
    }


    private async void NavContentPage3_OnClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavContentPage3());
    }

    private async void NavClosedPage2_OnClicked(object? sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}