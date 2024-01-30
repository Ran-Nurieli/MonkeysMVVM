namespace MonkeysMVVM.Views;

public partial class MonkeyPage : ContentPage
{
	public MonkeyPage()
	{
		InitializeComponent();
		this.BindingContext = new MonkeyPage();
	}
}