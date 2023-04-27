using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackTlawtehApi.Models;
using HackTlawtehApi.ViewModel;
using HackTlawtehApi.ViewModels;

namespace HackTlawtehApi.Services.UserService
{
    public interface IUserService
    {
        Task<object> Register(UserForRegister userForRegister);
		Task<object> IsUserRegistered(string UserName);
		// Task<object> LoginAdmin(AdminForLoginRequest adminForLogin);
		Task<object> LoginUser(UserForLogin userForLogin);
		Task<object> RegisterAdmin(UserForRegister adminForRegister);
		// Task<object> UpdateUser(UserForUpdate userForUpdate);

		Task<bool> UpdateDeviceToken(string Token,string UserId);
		Task<User> GetUser(string UserId);
    }
}