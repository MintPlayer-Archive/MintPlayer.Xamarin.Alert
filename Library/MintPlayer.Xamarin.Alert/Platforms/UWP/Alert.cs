using System;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace MultiTargetLibrary.Platforms.UWP
{
    public static class Alert
    {
        public static async Task Show(string text)
        {
            var dialog = new MessageDialog(text);
            await dialog.ShowAsync();
        }
    }
}
