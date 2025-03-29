using CommunityToolkit.Maui.Views;

namespace MauiApp1;

public partial class Popup1 : Popup
{
	public Popup1()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		bool answer = await AppShell.Current.DisplayAlert("TEST", "TEST?", "Yes", "No");
		if (answer)
		{

		}
	}
}