using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Drawing.Text;

namespace networkDeviceApp
{
    public partial class addDelDevice : Form
    {
        private List<Device> devices = new List<Device>();
        private bool isWayType = true;
        private bool isWayName = true;
        private bool isWayIP = true;
        private bool isWayLocation = true;
        public addDelDevice()
        {
            InitializeComponent();
        }

        private void modelDevices_Load()
        {
            cmbType.Items.Clear();
            cmbType.Items.AddRange(new string[]
            {
                   "", "Switch L2", "Switch L3", "Router",
                   "Firewall","Telefon IP","Drukarka","Fax","Kamera IP"
            });
            cmbType.SelectedIndex = 0;


        }

        private void Device_Load(object sender, EventArgs e)
        {
            modelDevices_Load();
            devices = JsonManager.LoadFromJson();
            listDevice.Items.Clear();
            foreach (var device in devices)
            {
                listDevice.Items.Add(device);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidTo.IsValidIP(txtIP.Text))
            {
                MessageBox.Show("Niepoprawny adres IP!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (Device device in listDevice.Items)
            {
                if (device.IP == txtIP.Text)
                {
                    MessageBox.Show("Urzadzenie z tym adresem już istnieje", "Duplikacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            Device newDevice = new Device()
            {
                Type = cmbType.Text,
                Name = txtName.Text,
                IP = txtIP.Text,
                Location = txtLocation.Text
            };
            devices.Add(newDevice);
            JsonManager.SaveToJson(devices);
            listDevice.Items.Add(newDevice);


        }

        private void SaveDevicesToFile()
        {
            string json = JsonSerializer.Serialize(devices);
            File.WriteAllText("devices.json", json);
        }


        private void btnDel_Click(object sender, EventArgs e)
        {

            if (listDevice.SelectedItem != null)
            {
                Device selectedDevice = (Device)listDevice.SelectedItem;
                //wcześniej było: string selectedDevice = listDevice.SelectedItem.ToString(); i nie działało, bo 
                //zwracało ciąg znaków a nie obiekt Device i selectedDevice.Name i IP probowały odwolywać się
                //do wlasciwosci ktora nie istniala
                DialogResult result = MessageBox.Show
                    (
                    $"Jesteś pewien, że chcesz usunąć:\n{selectedDevice}?",
                    "Potwierdzenie usunięcia",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning
                    );



                if (result == DialogResult.Yes)
                {
                    listDevice.Items.Remove(selectedDevice);

                    devices = JsonManager.LoadFromJson();
                    devices.RemoveAll(d => d.Name == selectedDevice.Name);
                    JsonManager.SaveToJson(devices);

                }
            }
            else
            {
                MessageBox.Show("Wybierz element do usunięcia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listDevice.SelectedItem != null)
            {
                Device selectedDevice = (Device)listDevice.SelectedItem;

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (listDevice.SelectedItem != null)
            {
                Device selectedDevice = (Device)listDevice.SelectedItem;
    
                selectedDevice.Name = txtName.Text;
                selectedDevice.IP = txtIP.Text;
                selectedDevice.Location = txtLocation.Text;
                selectedDevice.Type = cmbType.Text;
                //Zapisz zmiany w pliku
                JsonManager.SaveToJson(devices);

                //Odswiez liste
                listDevice.Items.Clear();
                foreach (Device device in devices)
                {
                    listDevice.Items.Add(device);
                }

                MessageBox.Show("Zmieniono parametry wybranego urządzenia", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nie zostało wybrane żadne urządzenie do edytowania", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

          

        private void RefreshDeviceList()
        {
            listDevice.Items.Clear();
            foreach (var device in devices)
            {
                listDevice.Items.Add(device);
            }
        }

        private void lblType_Click(object sender, EventArgs e)
        {   
            if(isWayType)
            devices = devices.OrderBy(d => d.Type).ToList();
            else
            devices = devices.OrderByDescending(d=>d.Type).ToList();

            isWayType = !isWayType;
            RefreshDeviceList();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            if(isWayName)
            devices = devices.OrderBy(d => d.Name).ToList();
            else
            devices = devices.OrderByDescending(d => d.Name).ToList();

            isWayName = !isWayName;
            RefreshDeviceList();
        }

        private void lblIP_Click(object sender, EventArgs e)
        {
            if(isWayIP)
            devices = devices.OrderBy(d => d.IP).ToList();
            else
            devices = devices.OrderByDescending(d => d.IP).ToList();

            isWayIP = !isWayIP;
            RefreshDeviceList();
        }

        private void lblLocation_Click(object sender, EventArgs e)
        {
            if(isWayLocation)
            devices = devices.OrderBy(d => d.Location).ToList();
            else
            devices = devices.OrderByDescending(d => d.Location).ToList();

            isWayLocation = !isWayLocation;
            RefreshDeviceList();
        }
    }
}



