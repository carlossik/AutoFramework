using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestEase;
using System.Net.Http;
using AutoFramework;
using static AutoFramework.Actions;

namespace SFB_Test_Automation.AutoFramework
{
    
    public class ApiTests {

        [Test]
        [Category("QuickTests")]
        public void VerifyEndPointst()
        {
            string[] envs = { Config.devapi, Config.stagingapi, Config.preprodapi };
            foreach (string env in envs)
            {
                HttpClient myclient = new HttpClient();
                var response = myclient.GetAsync(env + "125271");
                var Status = (int)response.Result.StatusCode;
                Console.WriteLine("This is the response for " + env +"  "+ Status);
                Assert.AreEqual(200, Status);

            }
           
            
        }
      
    }





} 
      
