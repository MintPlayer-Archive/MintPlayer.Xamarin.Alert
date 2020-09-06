using Android.App;
using Android.Widget;
using System.Threading.Tasks;

namespace MultiTargetLibrary.Platforms.Android
{
    public static class Alert
    {
        public static Task Show(string text)
        {
            Toast.MakeText(Application.Context, text, ToastLength.Long).Show();
            return Task.CompletedTask;
        }
    }
}
