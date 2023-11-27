using CommunityToolkit.Maui.Markup;
using CommunityToolkit.Maui.Views;

namespace LazyViewBlankPageIssue;

public class CustomLazyView<TView> : LazyView where TView : View, new()
{
 
    public override async ValueTask LoadViewAsync(CancellationToken token = new CancellationToken())
    {

        Content = new ActivityIndicator(){ IsRunning = true }.Center();

        // await Task.Delay(500, token);

        Content = new TView() { BindingContext = BindingContext };

        SetHasLazyViewLoaded(true);
    }
}