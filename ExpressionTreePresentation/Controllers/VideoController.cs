using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ExpressionTreePresentation.Business.Services;
using ExpressionTreePresentation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ExpressionTreePresentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VideoController : ControllerBase
    {
        public VideoController()
        {
        }

        [HttpGet]
        public async Task<IEnumerable<VideoDto>> Get()
        {
            var videoService = new VideoServices();
            var videos = await videoService.GetAll();

            var config = new MapperConfiguration(cfg => { cfg.AddProfile<ModelProfile>(); });
            var mapper = new Mapper(config);

            return mapper.Map<List<VideoDto>>(videos);
        }
    }
}
