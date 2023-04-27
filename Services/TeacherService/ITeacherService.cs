using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackTlawtehApi.Core;

namespace HackTlawtehApi.Services.TeacherService
{
    public interface ITeacherService : BaseInterface
    {
         Task<dynamic> GetTeachersByCountry(string country);
    }
}