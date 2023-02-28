namespace NiceBikeG5;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private async void OnRcBtnClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RCSellers()); // Go to 'RCSellers' view
    }
}

