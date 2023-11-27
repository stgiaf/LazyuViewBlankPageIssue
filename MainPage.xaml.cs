namespace LazyViewBlankPageIssue
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void MainPage_OnAppearing(object? sender, EventArgs e)
        {
            await ExampleView.LoadViewAsync();
        }
    }

}
