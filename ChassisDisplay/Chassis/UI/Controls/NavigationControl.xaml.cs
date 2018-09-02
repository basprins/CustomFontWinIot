using Windows.UI.Xaml;
using Chassis.UI.ViewModels;

namespace Chassis.UI.Controls
{
    public sealed partial class NavigationControl
    {
        public static readonly DependencyProperty ShowNavigationProperty = DependencyProperty.Register(
            "ShowNavigation", 
            typeof(bool), 
            typeof(NavigationControl), 
            new PropertyMetadata(false));

        public bool ShowNavigation
        {
            get => (bool)GetValue(ShowNavigationProperty);
            set => SetValue(ShowNavigationProperty, value);
        }

        public NavigationViewModel ViewModel { get; }

        public NavigationControl()
        {
            InitializeComponent();

            ViewModel = new NavigationViewModel();
            DataContext = ViewModel;
        }
    }
}
