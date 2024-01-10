namespace MauiApp_CoralCode;

public partial class FeedPage : ContentPage
{
	public FeedPage()
	{
		InitializeComponent();
	}
    private async void OnMainClicked(object sender, EventArgs e)
    {
        var profilePage = new MainPage();
        await Navigation.PushAsync(profilePage);
    }
    private async void OnFollowingClicked(object sender, EventArgs e)
    {
        var followingPage = new FollowingPage();
        await Navigation.PushAsync(followingPage);
    }
    private async void OnFeedClicked(object sender, EventArgs e)
    {
        var feedPage = new FeedPage();
        await Navigation.PushAsync(feedPage);
    }
    private async void OnForYouClicked(object sender, EventArgs e)
    {
        var foryouPage = new ForYouPage();
        await Navigation.PushAsync(foryouPage);
    }
}