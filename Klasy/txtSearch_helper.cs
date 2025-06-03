using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace networkDeviceApp.Klasy
{
    public class txtSearch_helper
    {
        public static void helper(List<Device> devices, ListView listView, string txtSearch)
        {
            string search = txtSearch.ToLower();
            listView.Items.Clear();

            foreach (var device in devices)
            {
                if (device.Type.ToLower().Contains(search) ||
                    device.Name.ToLower().Contains(search) ||
                    device.IP.ToLower().Contains(search) ||
                    device.Location.ToLower().Contains(search))
                {
                    var item = new ListViewItem(device.Type);
                    item.SubItems.Add(device.Name);
                    item.SubItems.Add(device.IP);
                    item.SubItems.Add(device.Location);
                    item.Tag = device;
                    listView.Items.Add(item);
                }
            }
        }
    }
}
