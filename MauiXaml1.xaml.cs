using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyViewBlankPageIssue;

public partial class MauiXaml1 : ContentPage
{
    public MauiXaml1()
    {
        InitializeComponent();
    }

    private async void Button_OnClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"home/{nameof(MainPage)}");
    }
}