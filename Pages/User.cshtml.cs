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

         private readonly  ApplicationUser? _appUser;

        public UserModel(UserManager<ApplicationUser> userManager)
        {
            this._userManager = userManager;
        }
        public void OnGet()
        {
          var task = _userManager.GetUserAsync(User);
          task.Wait();
          _appUser = task.Result;
        }
    }
}
