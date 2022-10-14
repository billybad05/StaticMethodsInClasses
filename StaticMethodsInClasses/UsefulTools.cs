using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethodsInClasses
{
    static class UsefulTools
    {
        public static void SayHi(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        
    }
}
