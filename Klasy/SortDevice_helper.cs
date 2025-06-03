using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace networkDeviceApp.Klasy
{
    public class SortDevice_helper 
    {
        public static void helper(ref List<Device> devices, int clickedColumn, ref int sortColumnIndex,ref bool sortAscending)
        {
            if(clickedColumn == sortColumnIndex)
            {
                sortAscending = !sortAscending; // zmienia kierunek sortowania
            }
            else
            {
                sortColumnIndex = clickedColumn;
                sortAscending = true;
            }
            switch (sortColumnIndex)
            {
                case 0:
                    devices = sortAscending
                        ? devices.OrderBy(d => d.Type).ToList()
                        : devices.OrderByDescending(d => d.Type).ToList();
                    break;
                case 1:
                    devices = sortAscending
                        ? devices.OrderBy(d => d.Name).ToList()
                        : devices.OrderByDescending(d => d.Name).ToList();
                    break;
                case 2:
                    devices = sortAscending
                        ? devices.OrderBy(d => d.IP).ToList()
                        : devices.OrderByDescending(d => d.IP).ToList();
                    break;
                case 3:
                    devices = sortAscending
                        ? devices.OrderBy(d => d.Location).ToList()
                        : devices.OrderByDescending(d => d.Location).ToList();
                    break;
            }
        }
    }
}
