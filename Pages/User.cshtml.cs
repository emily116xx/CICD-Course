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
        //this is a private read only variable should follow a _
        private readonly UserManager<ApplicationUser> userManager;
        //this should be  a private read only variable and should follow a _
        public ApplicationUser? appUser;

        public UserModel(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }
        //this function should be async
        //this function is missing documentation for description of feature
        public void OnGet()
        {
            //here the "user" should be null validated
            var task = userManager.GetUserAsync(User);
            task.Wait();
            appUser = task.Result;

        }
    }
}
