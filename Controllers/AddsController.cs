using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HackTlawtehApi.Models;
using HackTlawtehApi.Serveries.CategoriesServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HackTlawtehApi.Controllers
{
    [Route("add")]
    public class AddsController : Controller
    {
        private readonly IAddsService _repository;
        private IMapper _mapper;
        public AddsController(IAddsService repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }



        [HttpPost]
        [Route("add-add")]
        public async Task<ActionResult> AddAdd([FromForm] Add add)
        {
            if (add == null)
            {
                return NotFound();
            }

            await _repository.AddADD(add);

            return Ok(add);
        }


        [HttpGet]
        [Route("get-adds")]
        public async Task<ActionResult> GetAdds()
        {

            return Ok(await _repository.GetAdds());
        }




        //  [HttpPut]
        // [Route("update-category")]
        // public async Task<ActionResult> UpdateCategory([FromForm] UpdateCategoryDto UpdateCategory, [FromForm] int id)

        // {
        //     Category category = await _repository.GitCategoryById(id);
        //     if (category == null)
        //     {
        //         return NotFound();
        //     }
        //     _mapper.Map(UpdateCategory, category);

        //     _repository.UpdateCategory(category);
        //     _repository.SaveChanges();

        //     return Ok(category);
        // }

        [HttpPost]
        [Route("delete-add")]
        public async Task<ActionResult> DeleteAdd([FromForm] int addId)
        {
            Add add = await _repository.DeleteAdd(addId);

            if (add == null)
            {

                return NotFound();
            }



            return Ok(add);
        }
    }
}