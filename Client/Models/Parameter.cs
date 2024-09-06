using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class Parameter
    {
        public Dictionary<string, object> Parameters { get; set; }

        public Parameter()
        {
            Parameters = new Dictionary<string, object>();
        }

        public void Add(string key, object value)
        {
            Parameters[key] = value;
        }
    }
}
