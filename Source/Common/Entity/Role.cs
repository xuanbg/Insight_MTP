using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insight.MTP.Client.Common.Entity
{
    public class Role
    {
        public string id { get; set; }
        public string name { get; set; }

        public List<User> users { get; set; }
    }
}
