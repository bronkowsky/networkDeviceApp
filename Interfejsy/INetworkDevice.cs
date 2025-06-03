using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace networkDeviceApp
{
public interface INetworkDevice
    {
        string Type { get; set; } 
        string Name { get; set; }
        string IP {  get; set; }
        string Location { get; set; }

        string GetInfo();
    }
}
