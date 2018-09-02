using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Chassis.UI.Views.Braking.FullPortfolio
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AbsSensorsPage : Page
    {
        public string Title => this.GetString("shoesTitle");
        public string Description => this.GetString("shoesText");

        public AbsSensorsPage()
        {
            this.InitializeComponent();
        }
    }
}
