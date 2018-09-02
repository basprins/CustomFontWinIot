using System;
using System.Collections.Generic;
using System.IO;
using Windows.Media.Core;
using Windows.Media.Playback;
using Chassis.UI.ViewModels.Braking;

namespace Chassis.UI.Views.Braking
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FullPortfolioPage
    {
        public BrakingFullPortfolioViewModel ViewModel { get; }

        public FullPortfolioPage()
        {
            InitializeComponent();

            ViewModel = new BrakingFullPortfolioViewModel();
            DataContext = ViewModel;
        }
    }
}
