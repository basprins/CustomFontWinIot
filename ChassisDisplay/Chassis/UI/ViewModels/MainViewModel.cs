using System;
using Windows.Devices.Gpio;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;
using Chassis.Infrastructure;
using Chassis.UI.Views;
using Chassis.UI.Views.Airco;
using Chassis.UI.Views.Braking;
using Chassis.UI.Views.Ignition;
using Chassis.UI.Views.Steering;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Chassis.UI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private IO _io;
        private GpioPin _brakingPin;
        public RelayCommand BrakingCommand { get; }
        public RelayCommand SteeringCommand { get; }
        public RelayCommand AirConditioningCommand { get; }
        public RelayCommand IgnitionCommand { get; }

        public MainViewModel()
        {
            _io = ServiceContainer.Instance.Get<IO>();

            _brakingPin = _io.OpenPin(4, GpioSharingMode.Exclusive);
            _io.SetDriveMode(_brakingPin, GpioPinDriveMode.Output);
            _io.Write(_brakingPin, GpioPinValue.Low);

            BrakingCommand = new RelayCommand(() =>
            {
                this.NavigateTo(typeof(BrakingPage));
                _io.Write(_brakingPin, GpioPinValue.High);
            });

            SteeringCommand = new RelayCommand(() => this.NavigateTo(typeof(SteeringPage)));
            AirConditioningCommand = new RelayCommand(() => this.NavigateTo(typeof(AircoPage)));
            IgnitionCommand = new RelayCommand(() => this.NavigateTo(typeof(IgnitionPage)));

        }
    }
}
