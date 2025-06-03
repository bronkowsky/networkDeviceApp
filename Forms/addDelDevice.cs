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
using networkDeviceApp.Klasy;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace networkDeviceApp
{
    public partial class addDelDevice : Form
    {
        private int sortColumnIndex = -1;
        private bool sortAscending = true;
        private List<Device> devices = new List<Device>();
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
                   "Firewall","Telefon IP","Drukarka","Kamera IP"
            });
            cmbType.SelectedIndex = 0;
        }
        private void Device_Load(object sender, EventArgs e)
        {
            modelDevices_Load();
            devices = JsonManager.LoadFromJson();

            ListView_helper.helper(listViewDevice);
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
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            txtSearch_helper.helper(devices, listViewDevice, txtSearch.Text);
        } 
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddDevice.AddDevices_helper(devices, cmbType, txtName, txtIP, txtLocation, listViewDevice);
            RefreshDeviceList();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            DelDevice_helper.helper(devices, listViewDevice);
            RefreshDeviceList();

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditDevice_helper.helper(listViewDevice, cmbType, txtName, txtIP, txtLocation);
            RefreshDeviceList();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveDevice_helper.helper(devices, listViewDevice, cmbType, txtName, txtIP, txtLocation);
            RefreshDeviceList();
        }
        private void listViewDevice_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // użycie referencji ze względu na potrzebę wpływu na zmianę
            SortDevice_helper.helper(ref devices, e.Column, ref  sortColumnIndex, ref sortAscending);
            RefreshDeviceList();
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



