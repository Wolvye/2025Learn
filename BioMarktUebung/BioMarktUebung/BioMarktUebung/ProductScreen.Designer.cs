namespace BioMarktUebung
{
    partial class ProductScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductScreen));
            this.lblProName = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxBrand = new System.Windows.Forms.TextBox();
            this.lblMarke = new System.Windows.Forms.Label();
            this.lblKategorie = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.productsDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProName
            // 
            this.lblProName.AutoSize = true;
            this.lblProName.BackColor = System.Drawing.Color.Transparent;
            this.lblProName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProName.ForeColor = System.Drawing.Color.White;
            this.lblProName.Location = new System.Drawing.Point(55, 41);
            this.lblProName.Name = "lblProName";
            this.lblProName.Size = new System.Drawing.Size(39, 13);
            this.lblProName.TabIndex = 0;
            this.lblProName.Text = "Name";
            // 
            // txtBoxName
            // 
            this.txtBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxName.ForeColor = System.Drawing.Color.White;
            this.txtBoxName.Location = new System.Drawing.Point(122, 38);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(367, 20);
            this.txtBoxName.TabIndex = 1;
            // 
            // txtBoxBrand
            // 
            this.txtBoxBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtBoxBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxBrand.ForeColor = System.Drawing.Color.White;
            this.txtBoxBrand.Location = new System.Drawing.Point(122, 64);
            this.txtBoxBrand.Name = "txtBoxBrand";
            this.txtBoxBrand.Size = new System.Drawing.Size(249, 20);
            this.txtBoxBrand.TabIndex = 3;
            // 
            // lblMarke
            // 
            this.lblMarke.AutoSize = true;
            this.lblMarke.BackColor = System.Drawing.Color.Transparent;
            this.lblMarke.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarke.ForeColor = System.Drawing.Color.White;
            this.lblMarke.Location = new System.Drawing.Point(55, 67);
            this.lblMarke.Name = "lblMarke";
            this.lblMarke.Size = new System.Drawing.Size(42, 13);
            this.lblMarke.TabIndex = 2;
            this.lblMarke.Text = "Marke";
            // 
            // lblKategorie
            // 
            this.lblKategorie.AutoSize = true;
            this.lblKategorie.BackColor = System.Drawing.Color.Transparent;
            this.lblKategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorie.ForeColor = System.Drawing.Color.White;
            this.lblKategorie.Location = new System.Drawing.Point(55, 93);
            this.lblKategorie.Name = "lblKategorie";
            this.lblKategorie.Size = new System.Drawing.Size(61, 13);
            this.lblKategorie.TabIndex = 4;
            this.lblKategorie.Text = "Kategorie";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(55, 119);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 13);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Preis";
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPrice.ForeColor = System.Drawing.Color.White;
            this.txtBoxPrice.Location = new System.Drawing.Point(122, 116);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(75, 20);
            this.txtBoxPrice.TabIndex = 1;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.comboBoxCategory.ForeColor = System.Drawing.Color.White;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Obst",
            "Gemüse",
            "Fisch",
            "Drogerie",
            "Fleisch",
            "Getränke"});
            this.comboBoxCategory.Location = new System.Drawing.Point(122, 90);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(249, 21);
            this.comboBoxCategory.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.Location = new System.Drawing.Point(525, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Sichern";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEdit.Location = new System.Drawing.Point(606, 38);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Bearbeiten";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnClear.Location = new System.Drawing.Point(414, 67);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Leeren";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(525, 77);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // productsDGV
            // 
            this.productsDGV.AllowUserToAddRows = false;
            this.productsDGV.AllowUserToDeleteRows = false;
            this.productsDGV.AllowUserToResizeColumns = false;
            this.productsDGV.AllowUserToResizeRows = false;
            this.productsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.productsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDGV.Location = new System.Drawing.Point(58, 156);
            this.productsDGV.MultiSelect = false;
            this.productsDGV.Name = "productsDGV";
            this.productsDGV.ReadOnly = true;
            this.productsDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.productsDGV.RowHeadersVisible = false;
            this.productsDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.productsDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.productsDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.productsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDGV.Size = new System.Drawing.Size(704, 277);
            this.productsDGV.TabIndex = 11;
            this.productsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDGV_CellContentClick);
            // 
            // ProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 461);
            this.Controls.Add(this.productsDGV);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.lblKategorie);
            this.Controls.Add(this.txtBoxBrand);
            this.Controls.Add(this.lblMarke);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProductScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkte";
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProName;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxBrand;
        private System.Windows.Forms.Label lblMarke;
        private System.Windows.Forms.Label lblKategorie;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView productsDGV;
    }
}