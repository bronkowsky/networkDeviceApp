using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace networkDeviceApp.Klasy
{
    public class EditDevice_helper
    {
        public static void helper(ListView listViewDevice, ComboBox cmbType, TextBox txtName, TextBox txtIP, TextBox txtLocation)
        {
            if (listViewDevice.SelectedItems.Count > 0)
            {
                Device selectedDevice = (Device)listViewDevice.SelectedItems[0].Tag;

                txtName.Text = selectedDevice.Name;
                txtIP.Text = selectedDevice.IP;
                txtLocation.Text = selectedDevice.Location;
                cmbType.Text = selectedDevice.Type;
            }
            else
            {
                MessageBox.Show("Nie zostało wybrane żadne urządzenie do edytowania", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
