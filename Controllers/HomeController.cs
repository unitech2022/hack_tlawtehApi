using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

using HackTlawtehApi.Services.HomeSevice;

namespace HackTlawtehApi.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
         private readonly IHomeService _repository;
        private IMapper _mapper;

        public HomeController(IHomeService repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("get-home-user")]
        public async Task<ActionResult> GetFields([FromQuery] string UserId,[FromQuery]string  country)
        {

            return Ok(await _repository.GetHomeUser(country,UserId));
        }


       
    }
}