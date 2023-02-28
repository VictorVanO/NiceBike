namespace NiceBikeG5;

public partial class RCSellers : ContentPage
{
	public RCSellers()
	{
		InitializeComponent();
	}

    private async void NewClientClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RCNewClient());
    }

    private async void ListOfClientsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RCListOfClients());
    }
}