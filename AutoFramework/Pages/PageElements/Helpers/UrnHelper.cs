using AutoFramework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFB_Test_Automation.AutoFramework.vs.AutoFramework.Helpers
{
    public class URNHelper
    {
        private static IList urns = new List<string> { "130342",
    "132245",
    "100029",
    "100030",
    "100031",
    "100032",
    "100033",
    "100028",

        "100034",
        "100035",
        "100036",
        "100037",
       "100039",
        "131246",
        "131841",
        "143599",
        "132800",
        "132827",
        "100165",
        "100140",
        "100167",
        "100168",
        "100169",
        "100170",
        "100171",
        "144091",
        "100173",
        "100174",
        "100175",
        "100176",
        "100177",
        "100178",
        "100179" };


        public IList Urns
        {
            get { return urns; }
        }

        private static IList Trusts = new List<string>
        {"Kaleidoscope Learning Trust",
"Carmel Education Trust",
"Harris Federation",
"Harvey Academy",
"Wardle Academy",
"Portswood Primary Academy Trust",
"Arthur Terry Learning Partnership",
"Lordswood Academies Trust",
"Yorkshire And The Humber Co-Operative Learning Trust",
"Laurus Trust",
"Langtree School Academy Trust Company",
"Landau Forte Charitable Trust",
"Polymat",
"Platanos Trust",
"Plantsbrook Learning Trust",
"Bellevue Place Education Trust",
"Salisbury Plain Academies",
"Transform Trust",
"Academy Transformation Trust",
"Merican Trust"

        };
        public IList trusts
        {
            get { return trusts; }
        }
        private static IList schools = new List<string>
        {"140449",
"141352",
"143774",
"139984",
"137645",
"143082",
"144784",
"135507",
"141047",
"142295",
"136932",
"140710",
"140443",
"142229",
"146378",
"144889",
"140082",
"140082" };

        public IList Schools
        {
            get { return Schools; }

        }

        private static IList TrustLinks = new List<string>
{
  Config.currentTestEnv+"trust/index?companyNo=6625091",
Config.currentTestEnv+"trust/index?companyNo=6625091",
Config.currentTestEnv+"trust/index?companyNo=9662313",
Config.currentTestEnv+"trust/index?companyNo=7379768",
Config.currentTestEnv+"trust/index?companyNo=7455732"};
            
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=7974098",
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=8603037",
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=7654130",
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=8916979",
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=2535091",
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=6228587",
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=8657975",
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=7654127",
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=10512450",
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=2336587",
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=9028122",
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=7963778",
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=7844587",
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=8439184",
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=8452281",
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=10385920",
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=8792911",
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=7694573",
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=8088957",
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=7348231",
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=7691324",
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=8738750",
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=7694050",
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=7554121",
//"https://as-t1dv-sfb.azurewebsites.net/trust/index?companyNo=10363519" };

        public IList trustlinks
        {
            get { return TrustLinks ; }

        }
    }
}

    

