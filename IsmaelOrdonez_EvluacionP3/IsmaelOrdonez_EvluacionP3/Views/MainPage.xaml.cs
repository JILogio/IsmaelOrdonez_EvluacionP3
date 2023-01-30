namespace IsmaelOrdonez_EvluacionP3.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	public async void _buscar(object sender,EventArgs e)
    {
        await Shell.Current.GoToAsync("search");
    }

    public async void _index(object sender, EventArgs e)
    {

    }
}