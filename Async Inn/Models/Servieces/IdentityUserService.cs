using Async_Inn.Models.Api;
using Async_Inn.Models.Interfaces;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Servieces
{
    public class IdentityUserService : IUsers
    {
        // Connect to Identity’s “User Manager” to do the database work
        private UserManager<ApplicationUser> _userManager;
        // ApplicationUser we want to manage it
        public IdentityUserService(UserManager<ApplicationUser> manager)
        {
            _userManager = manager;
        }
        public async Task<UserDto> Authenticate(string username, string password)
        {
            // FindByNameAsync Finds and returns a user, if any, who has the specified user name.
            // resource: https://stackoverflow.com/questions/55149535/usermanager-checkpasswordasync-always-returns-failure
            var user = await _userManager.FindByNameAsync(username);
            if (user != null)
            {
                //check if password is correct
                //PasswordVerificationResult result = _userManager.PasswordHasher.VerifyHashedPassword(user.PasswordHash, password);
                if (await _userManager.CheckPasswordAsync(user, password))
                {
                    UserDto userDto = new UserDto
                    {
                        Id = user.Id,
                        Username = user.UserName,
                    };
                    return userDto;
                }
                //var user = UserManager.FindByNameAsync(username);
                //return SignInManager.UserManager.CheckPassword(user, Password);
            }
            return null;
        }
        // RegisterUserDto data means take data from body, will take all fields
        public async Task<UserDto> Register(RegisterUserDto data, ModelStateDictionary modelState)
        {
            var user = new ApplicationUser
            {
                UserName = data.Username,
                Email = data.Email,
                PhoneNumber = data.PhoneNumber
            };

            var result = await _userManager.CreateAsync(user, data.Password);
            // CreateAsync : create user, and password hash password and save it in database
            if (result.Succeeded)
            {
                UserDto userDto = new UserDto
                {
                    Id = user.Id,
                    Username = user.UserName,
                };
                return userDto;
            }
            foreach (var error in result.Errors)
            {
                var errorKey =
                    // nameof will go to the RegisterUser class and take property name 
                    error.Code.Contains("Password") ? /* key name will be -> */nameof(data.Password) :
                    error.Code.Contains("Email") ? /* key name will be -> */nameof(data.Email) :
                    error.Code.Contains("UserName") ? /* key name will be -> */nameof(data.Username) :
                    "";
                modelState.AddModelError(errorKey, error.Description);
            }
            return null;
        }
    }
}