using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.EntityLayer.EntityClasses;
using AdventureWorks.ViewModelLayer.ViewModelClasses;

namespace Ex1.Views;

public partial class UserDetailView : ContentPage
{
    private readonly UserViewModel _viewModel;

    public UserDetailView(UserViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
    }
    
    async protected override void OnAppearing()
    {
        base.OnAppearing();
        
        // Set the Page BindingContext
        BindingContext = _viewModel;
    
        // Get the Phone Types
        await _viewModel.GetPhoneTypes();
    
        // Retrieve a User
        await _viewModel.GetAsync(1);
    }
    private void OnPickerSelectionChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        // Calculate the new width based on the selected item's text length
        // Update the Picker's WidthRequest property
        picker.WidthRequest = CalculateNewWidth(picker?.SelectedItem?.ToString()?? "");
    }

    private static double CalculateNewWidth(string text)
    {
        // Implement your logic to calculate the width based on the text length
        // You might need to consider font size, padding, etc.
        return text.Length * 10 + 0; // Example calculation
    }

    private void SaveButton_OnClicked(object? sender, EventArgs e)
    {
        System.Diagnostics.Debugger.Break();

    }
}