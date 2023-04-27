using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HackTlawtehApi.Models;
using HackTlawtehApi.Models.BaseEntity;

namespace HackTlawtehApi.Serveries.CategoriesServices
{
    public interface IAddsService
    {
        Task<object> GetAdds();




        Task<Add> AddADD(Add Add);

         Task<Add> GitAddById(int AddId);


        Task<Add> DeleteAdd(int AddId);

        void UpdateAdd(Add Add);


         bool SaveChanges();
    }
}