using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HackTlawtehApi.Models;
using HackTlawtehApi.Models.BaseEntity;

namespace HackTlawtehApi.Serveries.SubCategoriesServices
{
    public interface ISubCategoriesService
    {
        Task<object> GetSubCategories();




        Task<SubCategory> AddSubCategory(SubCategory SubCategory);

         Task<SubCategory> GitSubCategoryById(int SubCategoryId);


          Task<object> GitSubCategoriesByCategoryId(int categoryId);


        Task<SubCategory> DeleteSubCategory(int SubCategoryId);

        void UpdateSubCategory(SubCategory SubCategory);


         bool SaveChanges();
    }
}