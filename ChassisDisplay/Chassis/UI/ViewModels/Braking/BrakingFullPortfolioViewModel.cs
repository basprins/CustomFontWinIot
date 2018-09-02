using Chassis.UI.Views;
using Chassis.UI.Views.Braking.FullPortfolio;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Chassis.UI.ViewModels.Braking
{
    public class BrakingFullPortfolioViewModel : ViewModelBase
    {
        public RelayCommand AbsSensorsCommand { get; }

        public BrakingFullPortfolioViewModel()
        {
            AbsSensorsCommand = new RelayCommand(() => { this.NavigateTo(typeof(AbsSensorsPage));});
        }
    }
}
