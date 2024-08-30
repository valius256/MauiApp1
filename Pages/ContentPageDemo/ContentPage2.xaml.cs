namespace MauiApp1.Pages.ContentPageDemo;

public partial class ContentPage2 : ContentPage
{
    public ContentPage2()
    {
        InitializeComponent();
    }

    private async void closedPage2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private async void ContentPage3_OnClicked(object? sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new ContentPage3());
    }
}