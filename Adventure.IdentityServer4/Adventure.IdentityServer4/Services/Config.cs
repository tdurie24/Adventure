using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adventure.IdentityServer4.Services
{
    public class Config
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };
        }

        public static List<TestUser> GetTestUsers()
        {
            return new List<TestUser>()
            {
                new TestUser
                {
                    SubjectId = "1",
                    Username ="tduri",
                    Password = "password"

                },
                new TestUser
                {
                    SubjectId = "2",
                    Username = "mahlu",
                  Password = "password"
                }
            };
        }
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("AdventureAPI", "Adventure API")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client()
                {
                  ClientId = "client",
                  ClientName  ="AdventureAPI",
                  AllowedGrantTypes = GrantTypes.ClientCredentials,
                  ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                  AllowedScopes  = { "AdventureAPI" }

                },

                ///resource owner 
                new Client()
                {
                    ClientId = "co.client",
                    ClientName = "AdventureAPI",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = {"AdventureAPI"}
                }
            };
        }
    }
}

