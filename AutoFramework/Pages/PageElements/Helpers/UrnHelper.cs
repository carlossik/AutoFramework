﻿using AutoFramework;
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
        "100179" ,
        "144406",
        "100113",
        "143686"};


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


        private static IList TrustUrns = new List<string>
        {
 "8604799",
 "6228587",
 "8142275",
 "7730920",
 "7567230",
 "7907463",
 "7980335",
 "2387916",
 "9078530",
 "7492094",
 "7655702",
 "7956784",
 "10163646",
 "10269490",
 "8320065",
 "7846852"
        };
        public IList trustsUrns
        {
            get { return TrustUrns; }
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
           
"113433",
"134171",
"113453",
"118442",
"115733",
"117386",
"138796",
"120797",
"120809",
"120835",
"120884",
"121036",
"121050",
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
            get { return schools; }

        }
        private static IList Feds = new List<String>
        {
"100234",
"100242",
"131141",
"100250",
"130303",
"100261",
"100258",
"100241",
"100248",
"100263",
"100224",
"100225",
"100232",
"132137",
"100266",
"100267",
"121792",
"100391",
"100388",
"134274",
"100472",
"100475",
"101251",
"101252",
"101254",
"101997",
"101996",
"102003",
"102004",
"102313",
"102309",
"102317",
"102322",
"131426",
"102294",
"102575",
"102574",
"102887",
"102888",
"139121",
"139122",
"137677",
"135558",
"137328",
"104092",
"104090",
"108911",
"108910",
"108960",
"108961",
"131216",
"117756",
"117737",
"117736",
"118023",
"117753",
"117752",
"117787",
"118020",
"118011",
"118018",
"118037",
"121293",
"121510",
"121306",
"121313",
"121311",
"121542",
"121344",
"121343",
"121410",
"121401",
"121463",
"121464",
"121481",
"121483",
"121498",
"121528",
"121500",
"121475",
"121513",
"121523",
"121521",
"121323",
"121549",
"121561",
"121560",
"121592",
"121582",
"121598",
"121602",
"121477",
"121482",
"121614",
"121517",
"121616",
"121492",
"109417",
"109413",
"109443",
"109613",
"109661",
"109435",
"114311",
"114289",
"113982",
"113983",
"114501",
"114391",
"114553",
"124068",
"124240",
"124249",
"124242",
"109826",
"109825",
"109864",
"109845",
"109923",
"109875",
"109932",
"109931",
"109975",
"109957",
"109977",
"109978",
"110017",
"109984",
"113068",
"113124",
"113148",
"113449",
"113079",
"134641",
"113104",
"113064",
"113347",
"113365",
"113368",
"113141",
"113164",
"113146",
"113133",
"113151",
"113126",
"113157",
"113382",
"113451",
"113172",
"113371",
"113223",
"113205",
"113207",
"113335",
"113399",
"113250",
"113411",
"113255",
"113249",
"113331",
"113343",
"113495",
"113348",
"113349",
"113432",
"113357",
"113071",
"113361",
"113348",
"113349",
"113432",
"113370",
"113441",
"113407",
"113203",
"113222",
"113463",
"113465",
"113478",
"113409",
"113254",
"113262",
"113433",
"113438",
"113445",
"113440",
"134171",
"113050",
"113082",
"113453",
"113456",
"118318",
"118319",
"118442",
"118477",
"119505",
"119092",
"111003",
"110999",
"111085",
"111056",
"111246",
"111248",
"115502",
"115554",
"115697",
"115639",
"115733",
"115741",
"117386",
"117422",
"138796",
"138797",
"121086",
"121108",
"120797",
"120822",
"120809",
"121041",
"121082",
"120835",
"120781",
"121000",
"120884",
"120883",
"120887",
"120890",
"121036",
"120836",
"121050",
"120914",
"121061",
"121054",
"121128",
"121040",
"121149",
"121146",
"140033",
"121164",
"120911",
"120988",
"121203",
"121192",
"121207",
"121131",
"124531",
"124718",
"124538",
"124698",
"124764",
"124763",
"124987",
"125068",
"125094",
"125096",
"125142",
"125157",
"125473",
"125468"


        };
        public IList feds
        {
            get { return Feds; }

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

    

