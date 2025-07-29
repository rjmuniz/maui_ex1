using Ex1.Views;

namespace Ex1;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        // Register routes
      Routing.RegisterRoute(
          nameof(UserDetailView),
          typeof(UserDetailView));
    }
}