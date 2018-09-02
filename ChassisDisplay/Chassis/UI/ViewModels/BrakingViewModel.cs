using Chassis.UI.Views;
using Chassis.UI.Views.Braking;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Chassis.UI.ViewModels
{
    public class BrakingViewModel : ViewModelBase
    {
        public RelayCommand PadsCommand { get; }
        public RelayCommand DiscsCommand { get; }
        public RelayCommand CylinderCommand { get; }
        public RelayCommand ShoesCommand { get; }
        public RelayCommand FullPortfolioCommand { get; }

        public BrakingViewModel()
        {
            PadsCommand = new RelayCommand(() =>
            {
                this.NavigateTo(typeof(PadsPage));
            });
            DiscsCommand = new RelayCommand(() =>
            {
                this.NavigateTo(typeof(DiscsPage));
            });
            CylinderCommand = new RelayCommand(() =>
            {
                this.NavigateTo(typeof(CylinderPage));
            });
            ShoesCommand = new RelayCommand(() =>
            {
                this.NavigateTo(typeof(ShoesPage));
            });
            FullPortfolioCommand = new RelayCommand(() =>
            {
                this.NavigateTo(typeof(FullPortfolioPage));
            });
        }
    }
}
