using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackTlawtehApi.Models;
using HackTlawtehApi.ViewModels;

namespace HackTlawtehApi.ViewModel
{
    public class HomeUserResponse
    {   
        public UserDetailResponse? UserDetail { get; set; }
        public List<Teacher>? Teachers { get; set; }

 public List<Add>? Adds { get; set; }
        public List<Category>? Categories { get; set; }
    }
}