using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Travel_Manager.Models;

namespace Travel_Manager.Pages
{
    [Authorize]
    public class UserModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
//this is supposed to be a public variable
         public  ApplicationUser? appUser;

        public UserModel(UserManager<ApplicationUser> userManager)
        {
            this._userManager = userManager;
        }
        public void OnGet()
        {
          var task = _userManager.GetUserAsync(User);
          task.Wait();
          appUser = task.Result;
        }
    }
}
