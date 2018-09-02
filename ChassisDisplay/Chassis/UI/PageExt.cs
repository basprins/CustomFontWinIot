using Windows.ApplicationModel.Resources;
using Windows.UI.Xaml.Controls;

namespace Chassis.UI
{
    public static class PageExt
    {
        public static string GetString(this Page page, string key)
        {
            var resourceLoader = ResourceLoader.GetForViewIndependentUse("Resources");
            return resourceLoader.GetString(key);
        }
    }
}
