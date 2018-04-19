using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;

namespace IdentityServer.InMemoryTestClasses
{
    public static class ApiRecourses
    {
        public static IEnumerable<ApiResource> Get()
        {
            return new ApiResource[]
            {
                new ApiResource("testresource", "testresourcedisplayname")
            };
        }
    }
}
