using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using ImageHandler;
using ImageHandler.iOS;
using UIKit;
using Xamarin.Forms;

[assembly: ExportImageSourceHandler(typeof(ByteArrayImageSource), typeof(ByteArrayImageSourceHandler))]
namespace ImageHandler.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}
