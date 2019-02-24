using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labor
{
    public class FileUploadViewModel
    {
        public IFormFile FileToUpload { get; set; }
    }
}
