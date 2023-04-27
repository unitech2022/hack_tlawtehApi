using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using HackTlawtehApi.Models;
using HackTlawtehApi.Serveries.SubCategoriesServices;
using HackTlawtehApi.Dtos;

namespace HackTlawtehApi.Controllers
{
    [Route("subCategory")]
    [ApiController]
    public class SubCategoriesController : Controller
    {

        private readonly ISubCategoriesService _repository;
        private IMapper _mapper;
        public SubCategoriesController(ISubCategoriesService repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }



        [HttpPost]
        [Route("add-subCategory")]
        public async Task<ActionResult> AddSubSubCategory([FromForm] SubCategory SubCategory)
        {
            if (SubCategory == null)
            {
                return NotFound();
            }

            await _repository.AddSubCategory(SubCategory);

            return Ok(SubCategory);
        }


        [HttpGet]
        [Route("get-subcategories")]
        public async Task<ActionResult> GetSubCategories()
        {

            return Ok(await _repository.GetSubCategories());
        }

        [HttpGet]
        [Route("get-subcategories-byCtId")]
        public async Task<ActionResult> GetSubCategoriesByCategoryId([FromQuery] int categoryId)
        {

            return Ok(await _repository.GitSubCategoriesByCategoryId(categoryId));
        }


        [HttpPut]
        [Route("update-subCategory")]
        public async Task<ActionResult> UpdateCategory([FromForm] UpdateSubCategoryDto UpdateSubCategory, [FromForm] int id)

        {
            SubCategory SubCategory = await _repository.GitSubCategoryById(id);
            if (SubCategory == null)
            {
                return NotFound();
            }
            _mapper.Map(UpdateSubCategory, SubCategory);

            _repository.UpdateSubCategory(SubCategory);
            _repository.SaveChanges();

            return Ok(SubCategory);
        }

        [HttpPost]
        [Route("delete-subCategory")]
        public async Task<ActionResult> DeleteSubCategory([FromForm] int SubCategoryId)
        {
            SubCategory SubCategory = await _repository.DeleteSubCategory(SubCategoryId);

            if (SubCategory == null)
            {

                return NotFound();
            }



            return Ok(SubCategory);
        }

    }
}