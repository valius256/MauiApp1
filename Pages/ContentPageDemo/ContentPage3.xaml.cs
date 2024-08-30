namespace MauiApp1.Pages.ContentPageDemo;

public partial class ContentPage3 : ContentPage
{
    public ContentPage3()
    {
        InitializeComponent();
    }

    private async void ClosedPage3_OnClicked(object? sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}