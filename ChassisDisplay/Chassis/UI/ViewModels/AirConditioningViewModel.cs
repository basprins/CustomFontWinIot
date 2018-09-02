using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Chassis.UI.ViewModels
{
    public class AirConditioningViewModel : ViewModelBase
    {
        public RelayCommand CompressorCommand { get; }
        public RelayCommand CondensorCommand { get; }
        public RelayCommand FullPortfolioCommand { get; }

        public AirConditioningViewModel()
        {
            CompressorCommand = new RelayCommand(() =>
            {

            });
            CondensorCommand = new RelayCommand(() =>
            {

            });
            FullPortfolioCommand = new RelayCommand(() =>
            {

            });
        }
    }
}
