using System;
using System.IO;
using System.Threading.Tasks;

namespace ImageHandler
{
    public interface IPictureLibraryService
    {
        Task<Stream> GetImageStreamAsync();
    }
}
