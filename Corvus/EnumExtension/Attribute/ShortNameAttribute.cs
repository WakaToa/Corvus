using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corvus.EnumExtension.Attribute
{
    public class ShortNameAttribute : System.Attribute
    {
        public string ShortName { get; set; }

        public ShortNameAttribute(string shortName)
        {
            ShortName = shortName;
        }

    }
}
