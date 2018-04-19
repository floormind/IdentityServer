using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;

namespace IdentityServer.InMemoryTestClasses
{
    public static class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new Client[]
            {
                new Client
                {
                    ClientId = "testclient",
                    ClientName = "testclientname",
                    ClientSecrets = new Secret[]
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = new List<string>() {"testresource"},
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials
                }
            };
        }
    }
}
