using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoyoteFrontend
{
    public static class FakeLocalStorage
    {
        // temporary work around to hold JWT somewhere

        public static string Username { get; set; }

        public static string Token { get; set; }

        public static DateTime ExpiresAt { get; set; }
    }
}
