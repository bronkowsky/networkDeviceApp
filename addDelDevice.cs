using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace networkDeviceApp
{
    public partial class addDelDevice : Form
    {
        public addDelDevice()
        {
            InitializeComponent();
        }

        private void modelDevices_Load(object sender, EventArgs e)
        {
            cmbType.Items.Add("");
            cmbType.Items.Add("Switch L2");
            cmbType.Items.Add("Switch L3");
            cmbType.Items.Add("Router");
            cmbType.Items.Add("Firewall");
            cmbType.Items.Add("Telefon IP");
            cmbType.Items.Add("Drukarka");
            cmbType.Items.Add("Fax");
            cmbType.Items.Add("Kamera IP");

            cmbType.SelectedIndex = 0;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Device newDevice = new Device()
            {
                Type = cmbType.Text,
                Name = txtName.Text,
                IP = txtIP.Text,
                Location = txtLocation.Text
            };
            listDevice.Items.Add(newDevice);
        }
    }
}
