using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Chassis.UI.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Chassis.UI.ViewModels
{
    public enum LanguageId
    {
        English,
        German,
    }

    public enum NavigationId
    {
        Home,
        Back
    }

    public class NavigationViewModel : ViewModelBase
    {
        public RelayCommand<LanguageId> ChangeLanguageCommand { get; }
        public RelayCommand<NavigationId> NavigationCommand { get; }

        public NavigationViewModel()
        {
            ChangeLanguageCommand = new RelayCommand<LanguageId>(ChangeLanguage);
            NavigationCommand = new RelayCommand<NavigationId>(Navigate);
        }

        private void ChangeLanguage(LanguageId languageId)
        {
            switch (languageId)
            {
                case LanguageId.English:
                    Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = "en-US";
                    break;
                case LanguageId.German:
                    Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = "de-DE";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(languageId), languageId, null);
            }

            if (Window.Current.Content is Frame frame)
            {
                Windows.ApplicationModel.Resources.Core.ResourceContext.GetForViewIndependentUse().Reset();
                Windows.ApplicationModel.Resources.Core.ResourceContext.GetForCurrentView().Reset();
                
                this.NavigateTo(frame.CurrentSourcePageType);
            }
        }

        private void Navigate(NavigationId navigationId)
        {
            switch (navigationId)
            {
                case NavigationId.Home:
                    {
                        this.NavigateTo(typeof(MainPage));
                        break;
                    }
                case NavigationId.Back:
                    {
                        this.NavigateBack();
                        break;
                    }
                default:
                    throw new ArgumentOutOfRangeException(nameof(navigationId), navigationId, null);
            }
        }
    }
}
