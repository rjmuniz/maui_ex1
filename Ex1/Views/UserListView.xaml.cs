using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Views;

public partial class UserListView : ContentPage
{
    public UserListView()
    {
        InitializeComponent();
    }

    private async void NavigateToDetail_Clicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Views.UserDetailView));
    }
}