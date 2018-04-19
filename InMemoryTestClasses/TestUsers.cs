using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Test;

namespace IdentityServer.InMemoryTestClasses
{
    public static class TestUsers
    {
        public static IEnumerable<TestUser> Get()
        {
            return new TestUser[]
            {
                new TestUser()
                {
                    SubjectId = "1",
                    Username = "a@b.c",
                    Password = "password"
                }
            };
        }
    }
}
