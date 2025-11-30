using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Views;

public partial class ProductDetailView : ContentPage
{
    public ProductDetailView()
    {
        InitializeComponent();
    }

    private void Weight_Changed(object? sender, ValueChangedEventArgs e)
    {
        this.weight.Value = Math.Round(e.NewValue, 0);
    }
}