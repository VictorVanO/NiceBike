namespace NiceBikeG5;

public partial class RCNewClient : ContentPage
{
	public RCNewClient()
	{
		InitializeComponent();
	}
    void OnNameTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldName = e.OldTextValue;
        string newName = e.NewTextValue;
        string myName = Name.Text;
    }
    void OnNameCompleted(object sender, EventArgs e)
    {
        string name = Name.Text;
    }
    void OnAdressTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldName = e.OldTextValue;
        string newName = e.NewTextValue;
        string myName = Name.Text;
    }
    void OnAdressCompleted(object sender, EventArgs e)
    {
        string name = Name.Text;
    }
    void OnPhoneTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldName = e.OldTextValue;
        string newName = e.NewTextValue;
        string myName = Name.Text;
    }
    void OnPhoneCompleted(object sender, EventArgs e)
    {
        string name = Name.Text;
    }
    void OnEmailTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldName = e.OldTextValue;
        string newName = e.NewTextValue;
        string myName = Name.Text;
    }
    void OnEmailCompleted(object sender, EventArgs e)
    {
        string name = Name.Text;
    }
    void OnTVATextChanged(object sender, TextChangedEventArgs e)
    {
        string oldName = e.OldTextValue;
        string newName = e.NewTextValue;
        string myName = Name.Text;
    }
    void OnTVACompleted(object sender, EventArgs e)
    {
        string name = Name.Text;
    }
    private async void AddClientClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RCListOfClients());
    }

}