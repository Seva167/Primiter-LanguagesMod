using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Seva167.LanguagesMod
{
    class Localization
    {
        public string Name { get; set; }

        [JsonIgnore]
        public string Code { get; set; }

        public Dictionary<string, string> Dictionary { get; set; }
    }
}
