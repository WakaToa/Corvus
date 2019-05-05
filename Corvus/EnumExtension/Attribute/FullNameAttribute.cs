using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corvus.EnumExtension.Attribute
{
    public class FullNameAttribute : System.Attribute
    {
        public string FullName { get; set; }

        public FullNameAttribute(string fullName)
        {
            FullName = fullName;
        }

    }
}
