using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDemo.Client.Services
{
    public class FileService : IFileService
    {
        private IJSRuntime _jsRuntime;

        public FileService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public Task SaveAsAsync(string filename, byte[] data)
        {
            return _jsRuntime.InvokeAsync<object>(
                "saveAsFile",
                filename,
                Convert.ToBase64String(data));
        }
    }

    public interface IFileService
    {
        Task SaveAsAsync(string filename, byte[] data);
    }
}
