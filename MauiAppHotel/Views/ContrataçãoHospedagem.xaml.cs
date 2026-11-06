using System.Linq.Expressions;

namespace MauiAppHotel.Views;

public partial class ContrataçãoHospedagem : ContentPage
{
	public ContrataçãoHospedagem()
	{
		InitializeComponent();
	}
    private async void OnSobreClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.Sobre());
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemContratada());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}
