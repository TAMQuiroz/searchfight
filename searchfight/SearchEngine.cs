﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searchfight
{
    interface SearchEngine
    {
        string GetName();
        long GetTotalResults();
        string GetSearchEngineUrl();
        void GenerateRequest(string searchArgument);
        
    }
}
