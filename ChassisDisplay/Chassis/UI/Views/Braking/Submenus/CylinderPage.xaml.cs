using System;
using Windows.Media.Core;
using Windows.Media.Playback;

namespace Chassis.UI.Views.Braking
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CylinderPage
    {
        public string Title => this.GetString("shoesTitle");
        public string Description => this.GetString("shoesText");
        public IMediaPlaybackSource Movie => MediaSource.CreateFromUri(new Uri("ms-appx:///Resources/3D/BrakeCylinder.mp4"));

        public CylinderPage()
        {
            InitializeComponent();
        }
    }
}
