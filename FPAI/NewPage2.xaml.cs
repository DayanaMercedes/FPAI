namespace FPAI;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();

	}
    private async void GotoNewPage3(object sender, EventArgs e) {
        App.FlyoutPage.Detail.Navigation.PushAsync(new NewPage3());
        App.FlyoutPage.IsPresented = false;
    }
    private async void GotoNewPage4(object sender, EventArgs e) {
        App.FlyoutPage.Detail.Navigation.PushAsync(new NewPage4());
        App.FlyoutPage.IsPresented = false;
    }
    private async void GotoNewPage5(object sender, EventArgs e) {
        App.FlyoutPage.Detail.Navigation.PushAsync(new NewPage5());
        App.FlyoutPage.IsPresented = false;
    }
    private async void GotoNewPage6(object sender, EventArgs e) {
        App.FlyoutPage.Detail.Navigation.PushAsync(new NewPage6());
        App.FlyoutPage.IsPresented = false;
    }
    private async void GotoNewPage7(object sender, EventArgs e) {
        App.FlyoutPage.Detail.Navigation.PushAsync(new NewPage7());
        App.FlyoutPage.IsPresented = false;
    }
    private async void GotoNewPage8(object sender, EventArgs e) {
        App.FlyoutPage.Detail.Navigation.PushAsync(new NewPage8());
        App.FlyoutPage.IsPresented = false;
    }

}