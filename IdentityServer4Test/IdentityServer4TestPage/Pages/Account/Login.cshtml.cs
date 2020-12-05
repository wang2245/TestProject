using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Services;
using IdentityServer4.Stores;
using IdentityServer4TestPage.Areas.Identity.Data;
using IdentityServer4TestPage.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IdentityServer4TestPage.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly UserManager<IdentityServer4TestPageUser> UserManager;
        private readonly SignInManager<IdentityServer4TestPageUser> SignInManager;

        /// <summary>
        /// Provide services be used by the user interface to communicate with IdentityServer.
        /// </summary>
        private readonly IIdentityServerInteractionService _interaction;

        private readonly IClientStore _clientStore;
        private readonly IAuthenticationSchemeProvider _schemeProvider;
        private readonly IEventService _events;

        public LoginInputModel LoginInputModel { get; set; }
        public LoginViewModel LoginViewModel { get; set; }

        public LoginModel(UserManager<IdentityServer4TestPageUser> userManager,
            SignInManager<IdentityServer4TestPageUser> signInManager,
            IIdentityServerInteractionService interaction,
            IClientStore clientStore,
            IAuthenticationSchemeProvider schemeProvider,
            IEventService events)
        {
            this.UserManager = userManager;
            this.SignInManager = signInManager;
            _interaction = interaction;
            _clientStore = clientStore;
            _schemeProvider = schemeProvider;
            _events = events;
        }

        public void OnGet(string returnUrl)
        {

        }

        public async Task<IActionResult> OnPostAsync(LoginInputModel model, string button)
        {
            //var context = await _interaction.GetAuthorizationContextAsync(model.ReturnUrl);
            if (ModelState.IsValid)
            {
                if (button == "login")
                {
                    var result = await this.SignInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberLogin, lockoutOnFailure: false);
                    if (result.Succeeded)
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    if (result.IsLockedOut)
                    {
                        return Content("Lockout");
                    }

                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    ViewData["LoginError"] = "InvalidLogin";
                    return Page();
                }
                else
                {

                    return Redirect("~/");
                }
            }
            else
            {
                return Content("");
            }
        }
    }
}
