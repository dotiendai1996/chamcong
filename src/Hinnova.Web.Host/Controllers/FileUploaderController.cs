﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Hinnova.Web.Controllers
{
    public class FileUploaderController : Controller
    {
        private IWebHostEnvironment _env;
        public FileUploaderController(IWebHostEnvironment hostingEnvironment)
        {
            _env = hostingEnvironment;
        }
        [HttpPost, DisableRequestSizeLimit]
        public ActionResult Upload()
        {
           
            try
            {
                var myFile = Request.Form.Files["myFile"];
                var path = Path.Combine(_env.WebRootPath, "uploads");

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                using (var fileStream = System.IO.File.Create(Path.Combine(path, myFile.FileName)))
                {
                    myFile.CopyTo(fileStream);
                }
            }
            catch
            {
                Response.StatusCode = 400;
            }

            return new EmptyResult();
        }
    }

}