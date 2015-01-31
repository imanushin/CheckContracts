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
        public static void SomeMethod(string str)
        {
            Validate.ArgumentStringIsMeanful(str, "str");
        }
    }
}
