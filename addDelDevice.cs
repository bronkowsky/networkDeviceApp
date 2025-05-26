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
            if(!ValidTo.IsValidIP(txtIP.Text))
                {
                MessageBox.Show("Niepoprawny adres IP!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                }
                Device newDevice = new Device()
            {
                Type = cmbType.Text,
                Name = txtName.Text,
                IP = txtIP.Text,
                Location = txtLocation.Text
            };
            listDevice.Items.Add(newDevice);
        }
        
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (listDevice.SelectedItem != null)
            {
                string selectedDevice = listDevice.SelectedItem.ToString();

                DialogResult result = MessageBox.Show
                    (
                    $"Jesteś pewien, że chcesz usunąć:\n{selectedDevice}?",
                    "Potwierdzenie usunięcia",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning
                    );

                if (result == DialogResult.Yes)
                {
                    listDevice.Items.Remove(listDevice.SelectedItem);
                } 
            }
            else
            {
                MessageBox.Show("Wybierz element do usunięcia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
