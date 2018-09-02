using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Chassis.UI.ViewModels
{
    public class IgnitionViewModel : ViewModelBase
    {
        public RelayCommand IgnitionCoilsCommand { get; }
        public RelayCommand FuelPumpCommand { get; }
        public RelayCommand InjectorsCommand { get; }

        public IgnitionViewModel()
        {
            IgnitionCoilsCommand = new RelayCommand(() =>
            {

            });

            FuelPumpCommand = new RelayCommand(() =>
            {

            });

            InjectorsCommand = new RelayCommand(() =>
            {

            });
        }
    }
}
