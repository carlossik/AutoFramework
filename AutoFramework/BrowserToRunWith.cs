using System;
using System.Collections.Generic;

namespace AutoFramework
{
    public class BrowserToRunWith
    {

        public static IEnumerable<String> BrowserTorunWith()
        {
            String[] browsers = { "chrome", "firefox","IE" };
            foreach (string b in browsers)
            {
                yield return b;

            }
        }
    }
    
}