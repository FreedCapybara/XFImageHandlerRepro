using System;
using System.Threading;
using System.Threading.Tasks;
using Foundation;
using ImageHandler;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace ImageHandler.iOS
{
    // Adapted from https://github.com/xamarin/Xamarin.Forms/blob/e8660383b03b4010724b36c6eef471a2e74e7c98/Xamarin.Forms.Platform.iOS/Renderers/ImageRenderer.cs#L204
    public class ByteArrayImageSourceHandler : IImageSourceHandler
    {
        public async Task<UIImage> LoadImageAsync(ImageSource imageSource, CancellationToken cancelationToken = default(CancellationToken), float scale = 1f)
        {
            var source = imageSource as ByteArrayImageSource;
            UIImage image = null;

            if (source?.Bytes != null)
            {
                image = await new Task<UIImage>(() => UIImage.LoadFromData(NSData.FromArray(source.Bytes), scale));
            }

            return image;
        }
    }
}
