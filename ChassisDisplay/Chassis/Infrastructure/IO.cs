﻿using System;
using System.Collections.Generic;
using Windows.Devices.Gpio;

namespace Chassis.Infrastructure
{
    public class IO
    {
        private readonly GpioController _gpioController;
        private readonly Dictionary<int, GpioPin> _pins;
        public IO(GpioController gpioController)
        {
            _gpioController = gpioController;
            _pins = new Dictionary<int, GpioPin>();
        }

        public GpioPin OpenPin(int pin, GpioSharingMode mode)
        {
            if (_pins.ContainsKey(pin))
            {
                var gpioPin = _pins[pin];
                if (gpioPin.SharingMode == mode)
                {
                    return gpioPin;
                }
                throw new ArgumentException($"Pin '{pin}' is already configured in mode '{gpioPin.SharingMode}'");
            }
            else
            {
                var gpioPin = _gpioController?.OpenPin(pin, mode);
                if (gpioPin != null)
                {
                    _pins[pin] = gpioPin;
                }

                return gpioPin;
            }
        }

        public void SetDriveMode(GpioPin pin, GpioPinDriveMode mode)
        {
            if (_gpioController != null)
            {
                pin?.SetDriveMode(mode);
            }
        }

        public void Write(GpioPin pin, GpioPinValue state)
        {
            if (_gpioController != null)
            {
                pin?.Write(state);
            }
        }
    }
}
