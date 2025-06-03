using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace networkDeviceApp.Klasy
{
    public class SaveDevice_helper
    {
        public static void helper(List<Device> devices, ListView listViewDevice, ComboBox cmbType, TextBox txtName, TextBox txtIP, TextBox txtLocation )
        {                                       
            if (listViewDevice.SelectedItems.Count > 0)
            {
                var selectedItem = listViewDevice.SelectedItems[0];
                var selectedDevice = (Device)selectedItem.Tag;

                selectedDevice.Type = cmbType.Text;
                selectedDevice.Name = txtName.Text;
                selectedDevice.IP = txtIP.Text;
                selectedDevice.Location = txtLocation.Text;
                

                selectedItem.SubItems[0].Text = selectedDevice.Type;
                selectedItem.SubItems[1].Text = selectedDevice.Name;
                selectedItem.SubItems[2].Text = selectedDevice.IP;
                selectedItem.SubItems[3].Text = selectedDevice.Location;

                JsonManager.SaveToJson(devices);
                MessageBox.Show("Zmieniono parametry wybranego urządzenia", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                JsonManager.LoadFromJson();
            }
            else
            {
                MessageBox.Show("Nie zostało wybrane żadne urządzenie do edytowania", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
