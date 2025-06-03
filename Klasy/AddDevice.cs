using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace networkDeviceApp.Klasy
{
    public static class AddDevice
    {
        public static void AddDevices_helper(
            List<Device> devices,
            ComboBox cmbType,
            TextBox txtName,
            TextBox txtIP,
            TextBox txtLocation,
            ListView listView)
        {
            string ip = txtIP.Text;
            string name = txtName.Text;
            string type = cmbType.Text;
            string location = txtLocation.Text;

            if (!ValidTo.IsValidIP(ip))
            {
                MessageBox.Show("Niepoprawny adres IP!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (devices.Any(d => d.IP == ip))
            {
                MessageBox.Show("Urzadzenie z tym adresem już istnieje", "Duplikacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newDevice = new Device
            {
                Type = type,
                Name = name,
                IP = ip,
                Location = location
            };

            devices.Add(newDevice);

            var item = new ListViewItem(newDevice.Type);
            item.SubItems.Add(newDevice.Name);
            item.SubItems.Add(newDevice.IP);
            item.SubItems.Add(newDevice.Location);
            item.Tag = newDevice;
            listView.Items.Add(item);

            JsonManager.SaveToJson(devices);

            // Reset formularza
            cmbType.SelectedIndex = 0;
            txtName.Clear();
            txtIP.Clear();
            txtLocation.Clear();

            MessageBox.Show("Dodano nowe urządzenie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
