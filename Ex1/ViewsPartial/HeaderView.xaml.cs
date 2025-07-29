using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.ViewsPartial;

public partial class HeaderView : ContentView
{
    public HeaderView()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty ViewTitleProperty =
        BindableProperty.Create(nameof(ViewTitle), typeof(string), typeof(HeaderView), "default ViewTitle");

    public string ViewTitle
    {
        get { return (string)GetValue(ViewTitleProperty); }
        set { SetValue(ViewTitleProperty, value); }
    }

    public static readonly BindableProperty ViewDescriptionProperty = BindableProperty.Create(
        "ViewDescription", typeof(string), typeof(HeaderView), string.Empty);

    public string ViewDescription
    {
        get { return (string)GetValue(ViewDescriptionProperty); }
        set { SetValue(ViewDescriptionProperty, value); }
    }
}