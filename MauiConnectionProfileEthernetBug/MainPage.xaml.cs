namespace MauiConnectionProfileEthernetBug;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

        ConnectionLbl.Text = string.Join(", ", Connectivity.Current.ConnectionProfiles);
        Connectivity.Current.ConnectivityChanged += (_, _) =>
		{
			ConnectionLbl.Text = string.Join(", ", Connectivity.Current.ConnectionProfiles);
		};
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

