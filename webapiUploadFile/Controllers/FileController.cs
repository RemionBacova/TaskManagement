using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using webapiUploadFile.Services;

namespace webapiUploadFile.Controllers
{

        [Route("api/[controller]")]
        public class FileController : ControllerBase
        {
            private readonly FileService _fileService;

            public FileController(FileService fileService)
            {
                _fileService = fileService;
            }

            // download file(s) to client according path: rootDirectory/subDirectory with single zip file
            [HttpGet("Download/{subDirectory}")]
            public IActionResult DownloadFiles(string entity, string elementID, string typeinfoID)
            {
                try
                {
                    var (fileType, archiveData, archiveName) = _fileService.FetechFiles(entity,elementID,typeinfoID);

                    return File(archiveData, fileType, archiveName);
                }
                catch (Exception exception)
                {
                    return BadRequest($"Error: {exception.Message}");
                }
            }

            // upload file(s) to server that palce under path: rootDirectory/subDirectory
            [HttpPost("upload")]
            public IActionResult UploadFile([FromForm(Name = "files")] List<IFormFile> files, string entity, string elementID, string typeinfoID)
            {
                try
                {
                    _fileService.SaveFile(files, entity,elementID,typeinfoID);

                    return Ok(new { files.Count, Size = FileService.SizeConverter(files.Sum(f => f.Length)) });
                }
                catch (Exception exception)
                {
                    return BadRequest($"Error: {exception.Message}");
                }
            }
        }
    }

