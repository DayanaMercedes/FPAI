namespace FPAI;

public partial class NewPage1 : FlyoutPage
{
	public NewPage1()
	{
		InitializeComponent();

		Flyout = new NewPage2();
		Detail = new NavigationPage (new NewPage3());

		App.FlyoutPage = this;
	}
} 