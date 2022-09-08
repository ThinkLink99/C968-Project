namespace C968_Software_Project.Forms
{
    partial class AddPart
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
            this.label1 = new System.Windows.Forms.Label();
            this.radInHouse = new System.Windows.Forms.RadioButton();
            this.radOutsourced = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMachineId = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtMachineId = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // radInHouse
            // 
            this.radInHouse.AutoSize = true;
            this.radInHouse.Location = new System.Drawing.Point(109, 7);
            this.radInHouse.Name = "radInHouse";
            this.radInHouse.Size = new System.Drawing.Size(74, 19);
            this.radInHouse.TabIndex = 1;
            this.radInHouse.TabStop = true;
            this.radInHouse.Text = "In-House";
            this.radInHouse.UseVisualStyleBackColor = true;
            this.radInHouse.CheckedChanged += new System.EventHandler(this.radInHouse_CheckedChanged);
            // 
            // radOutsourced
            // 
            this.radOutsourced.AutoSize = true;
            this.radOutsourced.Location = new System.Drawing.Point(189, 7);
            this.radOutsourced.Name = "radOutsourced";
            this.radOutsourced.Size = new System.Drawing.Size(87, 19);
            this.radOutsourced.TabIndex = 2;
            this.radOutsourced.TabStop = true;
            this.radOutsourced.Text = "Outsourced";
            this.radOutsourced.UseVisualStyleBackColor = true;
            this.radOutsourced.CheckedChanged += new System.EventHandler(this.radOutsourced_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Inventory:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price / Cost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Max:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Min:";
            // 
            // lblMachineId
            // 
            this.lblMachineId.AutoSize = true;
            this.lblMachineId.Location = new System.Drawing.Point(48, 276);
            this.lblMachineId.Name = "lblMachineId";
            this.lblMachineId.Size = new System.Drawing.Size(70, 15);
            this.lblMachineId.TabIndex = 9;
            this.lblMachineId.Text = "Machine ID:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(48, 276);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(97, 15);
            this.lblCompanyName.TabIndex = 10;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // txtMachineId
            // 
            this.txtMachineId.Location = new System.Drawing.Point(151, 273);
            this.txtMachineId.Name = "txtMachineId";
            this.txtMachineId.Size = new System.Drawing.Size(112, 23);
            this.txtMachineId.TabIndex = 11;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.Color.IndianRed;
            this.txtCompanyName.Location = new System.Drawing.Point(151, 273);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(112, 23);
            this.txtCompanyName.TabIndex = 12;
            // 
            // txtMin
            // 
            this.txtMin.BackColor = System.Drawing.Color.IndianRed;
            this.txtMin.Location = new System.Drawing.Point(226, 213);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(96, 23);
            this.txtMin.TabIndex = 13;
            // 
            // txtMax
            // 
            this.txtMax.BackColor = System.Drawing.Color.IndianRed;
            this.txtMax.Location = new System.Drawing.Point(87, 213);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(96, 23);
            this.txtMax.TabIndex = 14;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.IndianRed;
            this.txtPrice.Location = new System.Drawing.Point(125, 166);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(96, 23);
            this.txtPrice.TabIndex = 15;
            // 
            // txtInventory
            // 
            this.txtInventory.BackColor = System.Drawing.Color.IndianRed;
            this.txtInventory.Location = new System.Drawing.Point(125, 126);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(96, 23);
            this.txtInventory.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.IndianRed;
            this.txtName.Location = new System.Drawing.Point(125, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(96, 23);
            this.txtName.TabIndex = 17;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(125, 49);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(96, 23);
            this.txtId.TabIndex = 18;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(256, 331);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(66, 36);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(184, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 36);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 373);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtMachineId);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblMachineId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radOutsourced);
            this.Controls.Add(this.radInHouse);
            this.Controls.Add(this.label1);
            this.Name = "AddPart";
            this.Text = "AddPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton radInHouse;
        private RadioButton radOutsourced;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblMachineId;
        private Label lblCompanyName;
        private TextBox txtMachineId;
        private TextBox txtCompanyName;
        private TextBox txtMin;
        private TextBox txtMax;
        private TextBox txtPrice;
        private TextBox txtInventory;
        private TextBox txtName;
        private TextBox txtId;
        private Button btnCancel;
        private Button btnSave;
    }
}