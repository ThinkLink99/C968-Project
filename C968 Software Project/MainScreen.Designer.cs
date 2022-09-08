namespace C968_Software_Project
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.btnModifyPart = new System.Windows.Forms.Button();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnLookupPart = new System.Windows.Forms.Button();
            this.txtLookupPart = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtLookupProduct = new System.Windows.Forms.TextBox();
            this.btnLookupProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Managment System";
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.AllowUserToDeleteRows = false;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(8, 62);
            this.dgvParts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.ReadOnly = true;
            this.dgvParts.RowHeadersWidth = 62;
            this.dgvParts.RowTemplate.Height = 33;
            this.dgvParts.Size = new System.Drawing.Size(252, 135);
            this.dgvParts.TabIndex = 1;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(300, 62);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 33;
            this.dgvProducts.Size = new System.Drawing.Size(252, 135);
            this.dgvProducts.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Products";
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.Location = new System.Drawing.Point(204, 200);
            this.btnDeletePart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(56, 26);
            this.btnDeletePart.TabIndex = 5;
            this.btnDeletePart.Text = "Delete";
            this.btnDeletePart.UseVisualStyleBackColor = true;
            // 
            // btnModifyPart
            // 
            this.btnModifyPart.Location = new System.Drawing.Point(144, 200);
            this.btnModifyPart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifyPart.Name = "btnModifyPart";
            this.btnModifyPart.Size = new System.Drawing.Size(56, 26);
            this.btnModifyPart.TabIndex = 6;
            this.btnModifyPart.Text = "Modify";
            this.btnModifyPart.UseVisualStyleBackColor = true;
            this.btnModifyPart.Click += new System.EventHandler(this.btnModifyPart_Click);
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(84, 200);
            this.btnAddPart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(56, 26);
            this.btnAddPart.TabIndex = 7;
            this.btnAddPart.Text = "Add";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnLookupPart
            // 
            this.btnLookupPart.Location = new System.Drawing.Point(95, 35);
            this.btnLookupPart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLookupPart.Name = "btnLookupPart";
            this.btnLookupPart.Size = new System.Drawing.Size(56, 23);
            this.btnLookupPart.TabIndex = 8;
            this.btnLookupPart.Text = "Search";
            this.btnLookupPart.UseVisualStyleBackColor = true;
            // 
            // txtLookupPart
            // 
            this.txtLookupPart.Location = new System.Drawing.Point(155, 35);
            this.txtLookupPart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLookupPart.Name = "txtLookupPart";
            this.txtLookupPart.Size = new System.Drawing.Size(106, 23);
            this.txtLookupPart.TabIndex = 9;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(375, 200);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(56, 26);
            this.btnAddProduct.TabIndex = 12;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.Location = new System.Drawing.Point(435, 200);
            this.btnModifyProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(56, 26);
            this.btnModifyProduct.TabIndex = 11;
            this.btnModifyProduct.Text = "Modify";
            this.btnModifyProduct.UseVisualStyleBackColor = true;
            this.btnModifyProduct.Click += new System.EventHandler(this.btnModifyProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(496, 200);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(56, 26);
            this.btnDeleteProduct.TabIndex = 10;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(496, 237);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 26);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtLookupProduct
            // 
            this.txtLookupProduct.Location = new System.Drawing.Point(446, 35);
            this.txtLookupProduct.Margin = new System.Windows.Forms.Padding(2);
            this.txtLookupProduct.Name = "txtLookupProduct";
            this.txtLookupProduct.Size = new System.Drawing.Size(106, 23);
            this.txtLookupProduct.TabIndex = 15;
            // 
            // btnLookupProduct
            // 
            this.btnLookupProduct.Location = new System.Drawing.Point(386, 35);
            this.btnLookupProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnLookupProduct.Name = "btnLookupProduct";
            this.btnLookupProduct.Size = new System.Drawing.Size(56, 23);
            this.btnLookupProduct.TabIndex = 14;
            this.btnLookupProduct.Text = "Search";
            this.btnLookupProduct.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.txtLookupProduct);
            this.Controls.Add(this.btnLookupProduct);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnModifyProduct);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.txtLookupPart);
            this.Controls.Add(this.btnLookupPart);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.btnModifyPart);
            this.Controls.Add(this.btnDeletePart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgvParts;
        private DataGridView dgvProducts;
        private Label label2;
        private Label label3;
        private Button btnDeletePart;
        private Button btnModifyPart;
        private Button btnAddPart;
        private Button btnLookupPart;
        private TextBox txtLookupPart;
        private Button btnAddProduct;
        private Button btnModifyProduct;
        private Button btnDeleteProduct;
        private Button btnExit;
        private TextBox txtLookupProduct;
        private Button btnLookupProduct;
    }
}