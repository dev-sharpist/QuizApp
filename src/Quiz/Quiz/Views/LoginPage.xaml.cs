namespace Quiz.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(DashboardPage));
    }
}