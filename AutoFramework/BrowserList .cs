using MongoDB.Bson.IO;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SFB_Test_Automation.AutoFramework
{
    public class BrowserList : ValueSourceAttribute
    {
        private static IEnumerable Browsers;

        public BrowserList()
            : base(typeof(BrowserList), "Browsers")
        {
            Browsers = GetBrowserFromConfig();
        }

        private static IEnumerable GetBrowserFromConfig()
        {
            var settings = File.ReadAllText("testParameters.json");
            var config = (JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(settings);
            var seleniumSettings = config["Selenium"];
            var browsers = (JArray)seleniumSettings["BrowsersToTest"];

            return browsers;



        }
    }
}
