namespace ProductApp
{
    partial class frmProductManager
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
            System.Windows.Forms.Label readerIdLabel;
            System.Windows.Forms.Label readerNameLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label addressLabel;
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dgvListProduct = new System.Windows.Forms.DataGridView();
            readerIdLabel = new System.Windows.Forms.Label();
            readerNameLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // readerIdLabel
            // 
            readerIdLabel.AutoSize = true;
            readerIdLabel.Location = new System.Drawing.Point(45, 21);
            readerIdLabel.Name = "readerIdLabel";
            readerIdLabel.Size = new System.Drawing.Size(76, 17);
            readerIdLabel.TabIndex = 33;
            readerIdLabel.Text = "Product Id:";
            // 
            // readerNameLabel
            // 
            readerNameLabel.AutoSize = true;
            readerNameLabel.Location = new System.Drawing.Point(45, 49);
            readerNameLabel.Name = "readerNameLabel";
            readerNameLabel.Size = new System.Drawing.Size(102, 17);
            readerNameLabel.TabIndex = 35;
            readerNameLabel.Text = "Product Name:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(45, 78);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(69, 17);
            categoryLabel.TabIndex = 37;
            categoryLabel.Text = "Category:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(45, 134);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(42, 17);
            dateLabel.TabIndex = 39;
            dateLabel.Text = "Date:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(45, 106);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(79, 17);
            addressLabel.TabIndex = 41;
            addressLabel.Text = "Description";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(544, 490);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 38);
            this.btnExit.TabIndex = 47;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(445, 490);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 38);
            this.btnUpdate.TabIndex = 45;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(347, 490);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(96, 38);
            this.btnInsert.TabIndex = 44;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(148, 490);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(96, 38);
            this.btnLoad.TabIndex = 43;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(247, 490);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(96, 38);
            this.btnNew.TabIndex = 46;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(155, 18);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(257, 22);
            this.txtProductID.TabIndex = 34;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(155, 47);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(257, 22);
            this.txtProductName.TabIndex = 36;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(155, 74);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(257, 22);
            this.txtCategory.TabIndex = 38;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(155, 130);
            this.txtDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(257, 22);
            this.txtDate.TabIndex = 40;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(155, 103);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(257, 22);
            this.txtDescription.TabIndex = 42;
            // 
            // dgvListProduct
            // 
            this.dgvListProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProduct.Location = new System.Drawing.Point(37, 196);
            this.dgvListProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListProduct.Name = "dgvListProduct";
            this.dgvListProduct.RowHeadersWidth = 51;
            this.dgvListProduct.RowTemplate.Height = 24;
            this.dgvListProduct.Size = new System.Drawing.Size(731, 281);
            this.dgvListProduct.TabIndex = 32;
            // 
            // frmProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 549);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(readerIdLabel);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(readerNameLabel);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dgvListProduct);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProductManager";
            this.Text = "ProductInformation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DataGridView dgvListProduct;
    }
}

