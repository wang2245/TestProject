using System;
using System.Collections.Generic;
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
        private readonly UserManager<IdentityServer4TestPageUser> _userManager;
        private readonly SignInManager<IdentityServer4TestPageUser> _signInManager;

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
            _userManager = userManager;
            _signInManager = signInManager;
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
            if (button != "login")
            {
                return Redirect(model.ReturnUrl);
            }
            else
            {
                return Redirect("~/");
            }
        }
    }
}
