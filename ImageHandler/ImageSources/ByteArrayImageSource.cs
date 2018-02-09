using System;
using Xamarin.Forms;

namespace ImageHandler
{
    // Adapted from https://github.com/xamarin/Xamarin.Forms/blob/master/Xamarin.Forms.Core/StreamImageSource.cs
    public class ByteArrayImageSource : ImageSource
    {
        public static readonly BindableProperty BytesProperty = BindableProperty.Create("Bytes", typeof(byte[]), typeof(ByteArrayImageSource),
            default(byte[]));

        public virtual byte[] Bytes
        {
            get { return (byte[])GetValue(BytesProperty); }
            set { SetValue(BytesProperty, value); }
        }

        protected override void OnPropertyChanged(string propertyName)
        {
            if (propertyName == BytesProperty.PropertyName)
                OnSourceChanged();
            base.OnPropertyChanged(propertyName);
        }
    }
}
