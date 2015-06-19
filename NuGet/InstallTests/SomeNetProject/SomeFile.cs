using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckContracts;

namespace SomeNetProject
{
    internal static class SomeFile
    {
        public static int SomeMethod(string str)
        {
            Validate.ArgumentStringIsMeanful(null, "str");

            return 2;
        }
    }
}
