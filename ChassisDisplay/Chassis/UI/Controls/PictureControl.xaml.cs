using Windows.Media.Playback;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Chassis.UI.Controls
{
    public sealed partial class PictureControl
    {
        public static readonly DependencyProperty TitleTextProperty = DependencyProperty.Register(
            "TitleText",
            typeof(string),
            typeof(PictureControl),
            null);

        public string TitleText
        {
            get => (string)GetValue(TitleTextProperty);
            set => SetValue(TitleTextProperty, value);
        }

        public static readonly DependencyProperty DesciptionTextProperty = DependencyProperty.Register(
            "DesciptionText",
            typeof(string),
            typeof(PictureControl),
            null);

        public string DesciptionText
        {
            get => (string)GetValue(DesciptionTextProperty);
            set => SetValue(DesciptionTextProperty, value);
        }

        public static readonly DependencyProperty ImageSourceProperty = DependencyProperty.Register(
            "ImageSource",
            typeof(ImageSource),
            typeof(PictureControl),
            null);

        public ImageSource ImageSource
        {
            get => (ImageSource)GetValue(ImageSourceProperty);
            set => SetValue(ImageSourceProperty, value);
        }

        public PictureControl()
        {
            InitializeComponent();
        }
    }
}
