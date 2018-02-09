using System;
using System.IO;
using System.Windows.Input;

using Xamarin.Forms;

namespace ImageHandler
{
    public class AboutViewModel : BaseViewModel
    {
        public ICommand OpenWebCommand { get; }

        public ICommand RenderCommand { get; }

        public static IPictureLibraryService PictureLibraryService { get; set; }

        private ImageSource _renderOutput;
        public ImageSource RenderOutput
        {
            get { return _renderOutput; }
            set { SetProperty(ref _renderOutput, value); }
        }

        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));

            RenderCommand = new Command(async () =>
            {
                // get an image
                var stream = await PictureLibraryService.GetImageStreamAsync();

                // get bytes
                stream.Position = 0;
                var memoryStream = new MemoryStream();
                stream.CopyTo(memoryStream);
                memoryStream.Position = 0; // just to be sure
                var bytes = memoryStream.ToArray();

                // doesn't work
                //RenderOutput = new ByteArrayImageSource { Bytes = bytes };

                // does work
                stream.Position = 0;
                RenderOutput = ImageSource.FromStream(() => stream);
            });
        }
    }
}
