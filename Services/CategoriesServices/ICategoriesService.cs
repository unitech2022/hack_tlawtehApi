using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HackTlawtehApi.Models;
using HackTlawtehApi.Models.BaseEntity;

namespace HackTlawtehApi.Serveries.CategoriesServices
{
    public interface ICategoriesService
    {
        Task<object> GetCategories();




        Task<Category> AddCategory(Category category);

         Task<Category> GitCategoryById(int CategoryId);


        Task<Category> DeleteCategory(int CategoryId);

        void UpdateCategory(Category category);


         bool SaveChanges();
    }
}