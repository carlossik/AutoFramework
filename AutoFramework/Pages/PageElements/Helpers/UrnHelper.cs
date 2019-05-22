﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SFB_Test_Automation.AutoFramework.vs.AutoFramework.Helpers
{
    public class URNHelper
    {
        private static IList urns = new List<string>{"130342",
    "132245",
    "100028",
    "100029",
    "100030",
    "100031",
    "100032",
    "100033",
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
    "100178"};


        public  IList Urns
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
            get { return urns; }
        }
    }
    
}
