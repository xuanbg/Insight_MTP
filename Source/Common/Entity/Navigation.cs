using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insight.MTP.Client.Common.Entity
{
    public class Navigation
    {
        public string id { get; set; }
        public string parentId { get; set; }

        public int index { get; set; }
        public string name { get; set; }
        public List<Function> functions { get; set; }
    }
}
