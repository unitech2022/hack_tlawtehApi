using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackTlawtehApi.ViewModel;

namespace HackTlawtehApi.Services.HomeSevice
{
    public interface IHomeService
    {

 Task<HomeUserResponse> GetHomeUser(string country,string UserId);

 

        
    }
}