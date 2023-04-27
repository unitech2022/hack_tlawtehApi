using System.Text.Json;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using HackTlawtehApi.Data;
using HackTlawtehApi.Models;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using X.PagedList;

namespace HackTlawtehApi.Serveries.SubCategoriesServices
{
    public class SubCategoriesService : ISubCategoriesService

    {


        private readonly IMapper _mapper;

        private readonly IConfiguration _config;
        private readonly AppDBcontext _context;

        public SubCategoriesService(IMapper mapper, IConfiguration config, AppDBcontext context)
        {
            _mapper = mapper;
            _config = config;
            _context = context;
        }

        public async Task<SubCategory> AddSubCategory(SubCategory SubCategory)
        {

            await _context.SubCategories!.AddAsync(SubCategory);

            await _context.SaveChangesAsync();

            return SubCategory;

        }


        public async Task<object> GetSubCategories()
        {
            List<SubCategory> SubCategories = await _context.SubCategories!.ToListAsync();




            return SubCategories;

        }

        public async Task<SubCategory> GitSubCategoryById(int SubCategoryId)
        {

            SubCategory? SubCategory = await _context.SubCategories!.FirstOrDefaultAsync(x => x.Id == SubCategoryId);
            return SubCategory!;
        }

        public void UpdateSubCategory(SubCategory SubCategory)
        {


            // nothing

        }

        public async Task<SubCategory> DeleteSubCategory(int SubCategoryId)
        {
            SubCategory? SubCategory = await _context.SubCategories!.FirstOrDefaultAsync(x => x.Id == SubCategoryId);

            if (SubCategory != null)
            {
                _context.SubCategories!.Remove(SubCategory);

                await _context.SaveChangesAsync();
            }

            return SubCategory!;
        }


        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public async Task<object> GitSubCategoriesByCategoryId(int categoryId)
        {
            List<SubCategory> subCategories = await _context.SubCategories!.Where(t => t.CategoryId == categoryId).ToListAsync();

            return subCategories;
        }
    }
}