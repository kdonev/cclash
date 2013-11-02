﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CClash.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Environment.SetEnvironmentVariable("CCLASH_SERVER", "yes");
            var t = new CompilerCacheTest();
            t.Init();
            
            Environment.SetEnvironmentVariable("CCLASH_DEBUG", "test.log");
            t.RunEnabledDirect(100);
        }
    }
}
