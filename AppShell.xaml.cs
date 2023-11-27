namespace LazyViewBlankPageIssue
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            
            Routing.RegisterRoute($"home/{nameof(MainPage)}",typeof(MainPage));
        }
    }
}
