using Chassis.UI.ViewModels;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Chassis.UI.Views.Airco
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AircoPage
    {
        public AirConditioningViewModel ViewModel { get; }

        public AircoPage()
        {
            InitializeComponent();

            ViewModel = new AirConditioningViewModel();
            DataContext = ViewModel;
        }
    }
}
