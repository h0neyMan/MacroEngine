﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FileParsing
{
    [DataContract]
    class PagesInfo
    {
        [DataMember(Name = "configFile")]
        public string ConfigFile { get; set; }
        [DataMember(Name =  "pages")]
        public List<Page> Pages { get; set; }
    }
}