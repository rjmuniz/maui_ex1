namespace Ex1;

public class OsHelper:IOsHelper
{

    #region SetWindowOptions Method
    public static void SetWindowOptions(MauiAppBuilder builder)
    {
        builder.ConfigureLifecycleEvents(events =>
        {
            events.AddWindows(wndBuilder =>
            {
                wndBuilder.OnWindowCreated(window =>
                {
                    IntPtr hndl = WindowNative.GetWindowHandle(window);
                    WindowId winId = Win32Interop.GetWindowIdFromWindow(hndl);
                    AppWindow appWnd = AppWindow.GetFromWindowId(winId);
                    if (appWnd.Presenter is OverlappedPresenter p)
                    {
                        p.Maximize();
                        //p.HasBorder = false;
                        //p.HasTitleBar = false;
                        //p.IsAlwaysOnTop = false;
                        //p.IsMaximizable = false;
                        //p.IsMinimizable = false;
                        //p.IsModal = false;
                        //p.IsResizable = false;
                    }
                });
            });
        });
    }
    #endregion

    #region SetSwitchText Method
    public static void SetSwitchText(string onContent = "", 
        string offContent = "")
    {
        SwitchHandler.Mapper.AppendToMapping("SwitchText", (h, v) =>
        {
            // Get rid of On/Off label beside switch
            h.PlatformView.OnContent = onContent;
            h.PlatformView.OffContent = offContent;
            h.PlatformView.MinWidth = 0;
        });
    }
    #endregion
}
