using AutoFramework;
using OpenQA.Selenium;
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
            get { return Trusts; }
        }


        private static IList FederationsWithoutFinance = new List<string>
        {"100242",
"131141",
"130303",
"100261",
"100241",
"100248",
"100224",
"100225",
"100232",
"132137",
"100266",
"100267",
"121792",
"102004",
"102309",
"102322",
"102574",
"104092",
"133409",
"108961",
"117756",
"117736",
"117752",
"118020",
"118018",
"118037",
"121542",
"121475",
"121523",
"121592",
"121477",
"121482",
"109413",
"109613",
"109435",
"114289",
"113983",
"114391",
"124240",
"124242",
"109825",
"109845",
"109875",
"109931",
"109957",
"113124",
"113148",
"113449",
"113086",
"113064",
"113067",
"113100",
"113109",
"113164",
"113133",
"113382",
"113371",
"113205",
"113207",
"113335",
"113399",
"113331",
"113411",
"113495",
"113349",
"113432",
"113071",
"113361",
"113441",
"113204",
"113203",
"113463",
"113465",
"113478",
"113254",
"113262",
"113435",
"113438",
"113050",
"113082",
"113456",
"118477",
"118472",
"115741",
"117422",
"138797",
"121086",
"121108",
"120822",
"121041",
"121082",
"120850",
"120781",
"120883",
"120887",
"120890",
"120836",
"120914",
"121043",
"121058",
"121040",
"121149",
"140033",
"120988",
"121192",
"121131",
"125068",
"125096",
"104092",
"120911",
"125468"

        };
        public IList fedswithoutfinance
        {
            get { return FederationsWithoutFinance; }
        }

        private static IList FederationsWithFinance = new List<string>
        {
            "113429",
"113433",
"134171",
"113453",
"118442",
"118471",
"118509",
"115733",
"117386",
"138796",
"120797",
"120809",
"120815",
"120835",
"120884",
"121036",
"121050",
"121103",
"121128",
"121146",
"121164",
"121203",
"121207",
"124987",
"125000",
"125094",
"125473"

        };
        public IList fedswithFinance
        {
            get { return FederationsWithFinance; }
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
            


        public IList trustlinks
        {
            get { return TrustLinks ; }

        }
    }

   
}

    

