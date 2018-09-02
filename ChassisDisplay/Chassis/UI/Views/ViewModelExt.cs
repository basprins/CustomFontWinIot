using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using GalaSoft.MvvmLight;

namespace Chassis.UI.Views
{
    public static class ViewModelExt
    {
        public static void NavigateTo(this ViewModelBase vmb, Type type)
        {
            if (Window.Current.Content is Frame frame)
            {
                frame.Navigate(type, null, new SuppressNavigationTransitionInfo());
            }
        }

        public static void NavigateBack(this ViewModelBase vmb)
        {
            if (Window.Current.Content is Frame frame)
            {
                frame.GoBack(new SuppressNavigationTransitionInfo());
            }
        }
    }
}
