using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Chassis.UI.ViewModels
{
    public class SteeringViewModel : ViewModelBase
    {
        public RelayCommand WishBonesCommand { get; }
        public RelayCommand LinkStabalizersCommand { get; }
        public RelayCommand FullPortfolioCommand { get; }

        public SteeringViewModel()
        {
            WishBonesCommand = new RelayCommand(() =>
            {

            });
            LinkStabalizersCommand = new RelayCommand(() =>
            {

            });
            FullPortfolioCommand = new RelayCommand(() =>
            {

            });
        }
    }
}
