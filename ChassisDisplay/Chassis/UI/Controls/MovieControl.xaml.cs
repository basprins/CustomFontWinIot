using Windows.Media.Playback;
using Windows.UI.Xaml;

namespace Chassis.UI.Controls
{
    public sealed partial class MovieControl
    {
        public static readonly DependencyProperty TitleTextProperty = DependencyProperty.Register(
            "TitleText",
            typeof(string),
            typeof(MovieControl),
            null);

        public string TitleText
        {
            get => (string)GetValue(TitleTextProperty);
            set => SetValue(TitleTextProperty, value);
        }

        public static readonly DependencyProperty DesciptionTextProperty = DependencyProperty.Register(
            "DesciptionText",
            typeof(string),
            typeof(MovieControl),
            null);

        public string DesciptionText
        {
            get => (string)GetValue(DesciptionTextProperty);
            set => SetValue(DesciptionTextProperty, value);
        }

        public static readonly DependencyProperty MovieSourceProperty = DependencyProperty.Register(
            "MovieSource",
            typeof(IMediaPlaybackSource),
            typeof(MovieControl),
            null);

        public IMediaPlaybackSource MovieSource
        {
            get => (IMediaPlaybackSource)GetValue(MovieSourceProperty);
            set => SetValue(MovieSourceProperty, value);
        }

        public MovieControl()
        {
            InitializeComponent();
            MediaPlayerElement.MediaPlayer.IsLoopingEnabled = true;
        }
    }
}
