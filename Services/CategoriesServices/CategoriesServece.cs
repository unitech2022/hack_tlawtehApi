using System.Text.Json;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using HackTlawtehApi.Data;
using HackTlawtehApi.Models;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using X.PagedList;

namespace HackTlawtehApi.Serveries.CategoriesServices
{
    public class CategoriesService : ICategoriesService

    {


        private readonly IMapper _mapper;

        private readonly IConfiguration _config;
        private readonly AppDBcontext _context;

        public CategoriesService(IMapper mapper, IConfiguration config, AppDBcontext context)
        {
            _mapper = mapper;
            _config = config;
            _context = context;
        }

        public async Task<Category> AddCategory(Category category)
        {

            await _context.Categories!.AddAsync(category);

            await _context.SaveChangesAsync();

            return category;

        }

      
        public async Task<object> GetCategories()
        {
            List<Category> categories = await _context.Categories!.ToListAsync();
           



            return categories;

        }

        public async Task<Category> GitCategoryById(int CategoryId)
        {

            Category? category = await _context.Categories!.FirstOrDefaultAsync(x => x.Id == CategoryId);
            return category!;
        }

        public void UpdateCategory(Category category)
        {


            // nothing

        }

  public async Task<Category> DeleteCategory(int CategoryId)
        {
            Category? category = await _context.Categories!.FirstOrDefaultAsync(x => x.Id == CategoryId);

            if (category != null)
            {
                _context.Categories!.Remove(category);

                await _context.SaveChangesAsync();
            }

            return category!;
        }


        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

    }
}