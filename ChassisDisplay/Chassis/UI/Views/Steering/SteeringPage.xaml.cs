using Chassis.UI.ViewModels;

namespace Chassis.UI.Views.Steering
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SteeringPage
    {
        public SteeringViewModel ViewModel { get; }

        public SteeringPage()
        {
            InitializeComponent();

            ViewModel = new SteeringViewModel();
            DataContext = ViewModel;
        }
    }
}
