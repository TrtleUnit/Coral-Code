namespace MauiApp_CoralCode;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private async void OnProfileClicked(object sender, EventArgs e)
    {
        var profilePage = new ProfilePage();
        await Navigation.PushAsync(profilePage);
    }

    private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
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

