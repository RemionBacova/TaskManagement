using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Blazored.SessionStorage;

namespace TaskManagementInterface.Data
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {

        private ISessionStorageService _sessionStorageService;
        public CustomAuthenticationStateProvider(ISessionStorageService sessionStorageService)
        {
            _sessionStorageService = sessionStorageService;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {

            var description = await _sessionStorageService.GetItemAsync<string>("description");
            ClaimsIdentity identity;

            if (description != null)
            {
                 identity = new ClaimsIdentity(new[]
                {

                    new Claim(ClaimTypes.Name,description),
                }, "apiauth_type");

            }
            else
            {
                identity = new ClaimsIdentity();
            }


           

            var user = new ClaimsPrincipal(identity);

            return await Task.FromResult(new AuthenticationState(user));
        }

        public void MarkUserAsAuthenticated(string description)
        {


            var identity = new ClaimsIdentity(new[]
            {

                new Claim(ClaimTypes.Name,description), },
                "apiauth_type");

            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        public void MarkUserAsLoggedOut()
        {
            _sessionStorageService.RemoveItemAsync("description");


            var identity = new ClaimsIdentity();
            var user = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));

        }



    }
}