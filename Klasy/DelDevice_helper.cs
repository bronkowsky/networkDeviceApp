using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace networkDeviceApp.Klasy
{
    public static class DelDevice_helper
    {

        public static void helper(List<Device> devices, ListView listView)
        {
            if (listView.SelectedItems.Count > 0)
            {
                Device selectedDevice = (Device)listView.SelectedItems[0].Tag;
                DialogResult result = MessageBox.Show
                    (
                    $"Jesteś pewien, że chcesz usunąć:\n{selectedDevice}?",
                    "Potwierdzenie usunięcia",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning
                    );


                if (result == DialogResult.Yes)
                {
                    devices.Remove(selectedDevice);
                    JsonManager.SaveToJson(devices);
                    

                }
            }
            else
            {
                MessageBox.Show("Wybierz element do usunięcia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
