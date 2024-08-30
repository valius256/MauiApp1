namespace MauiApp1.Pages.NavContentPage;

public partial class NavContentPage3 : ContentPage
{
    public NavContentPage3()
    {
        InitializeComponent();
    }

    private async void NavClosedPage3_OnClicked(object? sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}