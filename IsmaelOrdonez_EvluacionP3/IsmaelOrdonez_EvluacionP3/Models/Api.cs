using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsmaelOrdonez_EvluacionP3.Models
{
    public class Api
    {
        public class Result
        {
            public string anime_name { get; set; }
            public string url { get; set; }
        }

        public class Root
        {
            public List<Result> results { get; set; }
        }
    }
}
