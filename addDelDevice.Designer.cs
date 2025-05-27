namespace networkDeviceApp
{
    partial class addDelDevice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.listDevice = new System.Windows.Forms.ListBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Location = new System.Drawing.Point(696, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(228, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(379, 42);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 22);
            this.txtIP.TabIndex = 2;
            // 
            // listDevice
            // 
            this.listDevice.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listDevice.FormattingEnabled = true;
            this.listDevice.ItemHeight = 16;
            this.listDevice.Location = new System.Drawing.Point(59, 99);
            this.listDevice.Name = "listDevice";
            this.listDevice.Size = new System.Drawing.Size(712, 244);
            this.listDevice.TabIndex = 3;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(59, 40);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 24);
            this.cmbType.TabIndex = 4;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(526, 42);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(137, 22);
            this.txtLocation.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rodzaj urządzenia";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(796, 320);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Usuń";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adres IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Lokalizacja (miasto)";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(796, 99);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(890, 98);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(77, 80);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(75, 16);
            this.lblType.TabIndex = 16;
            this.lblType.Text = "Urządzenie";
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(177, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 16);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Nazwa";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(283, 80);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(58, 16);
            this.lblIP.TabIndex = 18;
            this.lblIP.Text = "Adres IP";
            this.lblIP.Click += new System.EventHandler(this.lblIP_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.SystemColors.Control;
            this.lblLocation.Location = new System.Drawing.Point(383, 80);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(85, 16);
            this.lblLocation.TabIndex = 19;
            this.lblLocation.Text = "Miejscowość";
            this.lblLocation.Click += new System.EventHandler(this.lblLocation_Click);
            // 
            // addDelDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 450);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.listDevice);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAdd);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "addDelDevice";
            this.Text = "addDelDevice";
            this.Load += new System.EventHandler(this.Device_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.ListBox listDevice;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblLocation;
    }
}