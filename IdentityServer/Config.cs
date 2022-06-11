using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer
{
    public class Config
    {
        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientId = "movieClient",
                    AllowedGrantTypes = {GrantType.ClientCredentials },
                    ClientSecrets =
                    {
                        new Secret("secret2".Sha256())
                    },
                    AllowedScopes = {"movieAPI"}
                },
                new Client
                {
                    ClientId="movies_mvc_client",
                    ClientName = "movies mvc web app",
                    AllowedGrantTypes = GrantTypes.Code,
                    AllowRememberConsent = false,
                    RedirectUris = new List<string>(){
                        "https://localhost:5002/signin-oidc"
                    },
                    PostLogoutRedirectUris = {
                        "https://localhost:5002/signout-callback-oidc"
                    },
                    ClientSecrets = new List<Secret>
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes=new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                    }
                }
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("movieAPI","Movie API")
            };

        public static IEnumerable<ApiResource> ApiResources =>
            new ApiResource[] { };

        public static IEnumerable<IdentityResource> IdentityResources =
            new IdentityResource[] { 
                //new IdentityResource.OpenId(),
            };

        internal static List<TestUser> TestUser()
        {
            return new List<TestUser>() {
                new TestUser{
                    SubjectId ="subject-subject-subject-subject-subject",
                    Username ="attia",
                    Password ="attia",
                    Claims = new List<Claim>
                    {
                        new Claim(JwtClaimTypes.GivenName,"mohamed"),
                        new Claim(JwtClaimTypes.GivenName,"attia")
                    }
                }
            };
        }
    }
}
