namespace MauiApp_CoralCode;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
	}
    private async void OnMainClicked(object sender, EventArgs e)
    {
        var profilePage = new MainPage();
        await Navigation.PushAsync(profilePage);
    }
}