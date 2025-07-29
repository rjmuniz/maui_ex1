using Microsoft.Maui.LifecycleEvents;

namespace Ex1;
#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
#endif

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    
    public static void SetWindowOptions(MauiAppBuilder builder)
    {
        builder.ConfigureLifecycleEvents(events =>
            {
#if WINDOWS
    events.AddWindows(w =>
    {
        w.OnWindowCreated(window =>
        {
            window.ExtendsContentIntoTitleBar = true; //If you need to completely hide the minimized maximized close button, you need to set this value to false.
            IntPtr hWnd = WinRT.Interop.WindowNative.GetWindowHandle(window);
            WindowId myWndId = Win32Interop.GetWindowIdFromWindow(hWnd);
            var _appWindow = AppWindow.GetFromWindowId(myWndId);
            _appWindow.SetPresenter(AppWindowPresenterKind.FullScreen);
        });
    });
#endif
            });
      
    }
}