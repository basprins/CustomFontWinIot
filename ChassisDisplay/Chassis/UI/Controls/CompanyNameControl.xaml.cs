using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Chassis.UI.Controls
{
    public sealed partial class CompanyNameControl
    {
        public static readonly DependencyProperty TextColorProperty = DependencyProperty.Register(
            "TextColor",
            typeof(Brush),
            typeof(NavigationControl),
            null);

        public Brush TextColor
        {
            get => (Brush)GetValue(TextColorProperty);
            set => SetValue(TextColorProperty, value);
        }

        public CompanyNameControl()
        {
            InitializeComponent();
        }
    }
}
