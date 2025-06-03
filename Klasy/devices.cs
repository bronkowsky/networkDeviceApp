using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace networkDeviceApp
{

    public abstract class NetworkDevice : INetworkDevice
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string IP { get; set; }
        public string Location { get; set; }

        public virtual string GetInfo()
        {
            return $"{Type}  |  {Name}  |  {IP}  |  {Location}";
        }
        public override string ToString()
        {
            return GetInfo();
        }
    }
        public class Device : NetworkDevice
        {
            public override string GetInfo()
            {
            return $"[DEVICE] {base.GetInfo()}";
            }
        }
    }



