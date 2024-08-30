namespace MauiApp1.Pages.ContentPageDemo;

public partial class ContentPage1 : ContentPage
{
    public ContentPage1()
    {
        InitializeComponent();
    }

    private async void contentPage2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new ContentPage2());
    }
}