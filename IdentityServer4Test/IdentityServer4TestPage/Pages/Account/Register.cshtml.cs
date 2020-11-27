using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4TestPage.Areas.Identity.Data;
using IdentityServer4TestPage.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IdentityServer4TestPage.Pages.Account
{
    public class RegisterModel : PageModel
    {
        UserManager<IdentityServer4TestPageUser> UserManager { get; }
        SignInManager<IdentityServer4TestPageUser> SignInManager { get; }

        public RegisterViewModel RegisterViewModel { get; set; }

        public RegisterModel(UserManager<IdentityServer4TestPageUser> userManager,
            SignInManager<IdentityServer4TestPageUser> signInManager)
        {
            this.UserManager = userManager;
            this.SignInManager = signInManager;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(RegisterViewModel registerViewModel, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityServer4TestPageUser { UserName = registerViewModel.Email, Email = registerViewModel.Email };

                
                var result = await this.UserManager.CreateAsync(user, registerViewModel.Password);

                if (result.Succeeded)
                {
                    await this.SignInManager.SignInAsync(user, false);
                    return Redirect(returnUrl);
                }
            }

            return Page();
        }
    }
}
