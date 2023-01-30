using IsmaelOrdonez_EvluacionP3.Models;
using IsmaelOrdonez_EvluacionP3.Services;

namespace IsmaelOrdonez_EvluacionP3.Views;

/*https://docs.nekos.best/api/endpoints.html
https://waifu.pics/docs */
public partial class SearchItemPage : ContentPage
{
    ApiService services = new ApiService();
    int count = 0;
	public SearchItemPage()
	{
		InitializeComponent();
	}

    private async void mostrarIm(object sender, EventArgs e)
    {
        string _rek = searchName.Text;
        string _q = quant.Text;
        var dto = await services.GetImage(_rek, int.Parse(_q));
        image.Source = dto.results[0].url;
    }

    private async void _siguiente(object sender, EventArgs e)
    {
        string _rek = searchName.Text;
        string _q = quant.Text;
        var dto = await services.GetImage(_rek, int.Parse(_q));
        if (int.Parse(_q) != 1 && (count + 1 < int.Parse(_q)))
        {
            count++;
            image.Source = dto.results[count].url;
        }
        else
        {
            count = 0;
        }
    }
}
