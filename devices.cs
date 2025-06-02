using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace networkDeviceApp
{

    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string IP { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            return $"{Type}  |  {Name}  |  {IP}  |  {Location}";
        }
    }
}

