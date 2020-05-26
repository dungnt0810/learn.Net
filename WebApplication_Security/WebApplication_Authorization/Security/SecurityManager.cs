using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using WebApplication_Authorization.Models;

namespace WebApplication_Authorization.Security
{
    public class SecurityManager
    {
        private IEnumerable<Claim> GetClaimOfAccount(Account account)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, account.Username));
            foreach(var roleAccount in account.RoleAccount)
            {
                claims.Add(new Claim(ClaimTypes.Role, roleAccount.Role.Name));
            }

            return claims;
        }

        public async void SignIn(HttpContext httpContext, Account account)
        {
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(GetClaimOfAccount(account), CookieAuthenticationDefaults.AuthenticationScheme);
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            await httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);
        }

        public async void SignOut(HttpContext httpContext) => await httpContext.SignOutAsync();


    }
}
