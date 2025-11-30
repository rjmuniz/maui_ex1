using Microsoft.Maui.Handlers;
using Microsoft.Maui.LifecycleEvents;

namespace Ex1;

public class OsHelper
{

    #region SetWindowOptions Method
    public void SetWindowOptions(MauiAppBuilder builder)
    {
        return;
    }
    #endregion

    #region SetSwitchText Method
    public static void SetSwitchText(string onContent = "", 
        string offContent = "")
    {
        SwitchHandler.Mapper.AppendToMapping("SwitchText", (h, v) =>
        {
           // h.PlatformView.Title = h.PlatformView.On ? onContent : offContent;
        });
    }
    #endregion
}
