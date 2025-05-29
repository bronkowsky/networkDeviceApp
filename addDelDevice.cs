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
        public addDelDevice()
        {
            InitializeComponent();
            txtSearch.TextChanged += txtSearch_TextChanged;
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.ToLower();
            listViewDevice.Items.Clear();

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
                    listViewDevice.Items.Add(item);
                }
            }
        }


        //  //////////////////////////////////////////
        private void listViewDevice_Load()
        {
            listViewDevice.View = View.Details;
            listViewDevice.FullRowSelect = true;
            listViewDevice.GridLines = true;
            listViewDevice.HideSelection = false;
            listViewDevice.Columns.Clear();
            listViewDevice.Columns.Add("Typ", 100);
            listViewDevice.Columns.Add("Nazwa", 150);
            listViewDevice.Columns.Add("IP", 120);
            listViewDevice.Columns.Add("Lokalizacja", 150);
        }
        private void Device_Load(object sender, EventArgs e)
        {
            modelDevices_Load();
            devices = JsonManager.LoadFromJson();
            listViewDevice_Load();
            txtName.MaxLength = 15;
            foreach (var device in devices)
            {
                var item = new ListViewItem(device.Type); 
                item.SubItems.Add(device.Name);           
                item.SubItems.Add(device.IP);             
                item.SubItems.Add(device.Location);       
                item.Tag = device; 
                listViewDevice.Items.Add(item); 
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidTo.IsValidIP(txtIP.Text))
            {
                MessageBox.Show("Niepoprawny adres IP!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(IsDuplicateIP(txtIP.Text))
            {
                MessageBox.Show("Urzadzenie z tym adresem już istnieje", "Duplikacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Device newDevice = new Device()
            {
                Type = cmbType.Text,
                Name = txtName.Text,
                IP = txtIP.Text,
                Location = txtLocation.Text
            };
            devices.Add(newDevice);
            
            ListViewItem items = new ListViewItem(newDevice.Type);
            items.SubItems.Add(newDevice.Name);
            items.SubItems.Add(newDevice.IP);
            items.SubItems.Add(newDevice.Location);
            items.Tag = newDevice;
            listViewDevice.Items.Add(items);
            JsonManager.SaveToJson(devices);
            RefreshDeviceList();

            cmbType.SelectedIndex = 0;
            txtName.Clear();
            txtIP.Clear();
            txtLocation.Clear();
        }

        private bool IsDuplicateIP(string ip)
        {
            foreach (ListViewItem item in listViewDevice.Items)
            {
                if (item.Tag is Device dev && dev.IP == ip)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            if (listViewDevice.SelectedItems.Count > 0)
            {
                Device selectedDevice = (Device)listViewDevice.SelectedItems[0].Tag;
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
                    RefreshDeviceList();
            
                }
            }
            else
            {
                MessageBox.Show("Wybierz element do usunięcia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (listViewDevice.SelectedItems.Count > 0)
            {
             var selectedItem = listViewDevice.SelectedItems[0];
             var  selectedDevice = (Device)selectedItem.Tag;

                selectedDevice.Name = txtName.Text;
                selectedDevice.IP = txtIP.Text;
                selectedDevice.Location = txtLocation.Text;
                selectedDevice.Type = cmbType.Text;
                

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
        private void RefreshDeviceList()
        {
            listViewDevice.Items.Clear();
            foreach (var device in devices)
            {
                var item = new ListViewItem(device.Type);
                item.SubItems.Add(device.Name);
                item.SubItems.Add(device.IP);
                item.SubItems.Add(device.Location);
                item.Tag = device;
                listViewDevice.Items.Add(item);
            }
        }
    }
}



