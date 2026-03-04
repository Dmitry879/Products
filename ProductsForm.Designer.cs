namespace Products
{
    partial class ProductsForm
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
            gbCategory = new GroupBox();
            btnAddCat = new Button();
            lblDescript = new Label();
            lblCatName = new Label();
            tbCatName = new TextBox();
            tbCatDescript = new TextBox();
            gbProduct = new GroupBox();
            tbVendorId = new TextBox();
            lblVendorId = new Label();
            tbCatId = new TextBox();
            btnAddPro = new Button();
            lblRetPrice = new Label();
            lblCatId = new Label();
            lblWholePrice = new Label();
            lblProdName = new Label();
            tbProdName = new TextBox();
            tbProdDescript = new TextBox();
            tbProdWholePrice = new TextBox();
            lblProdDescript = new Label();
            tbProdRetPrice = new TextBox();
            dgvCategories = new DataGridView();
            dgvProducts = new DataGridView();
            lblCats = new Label();
            lblProducts = new Label();
            btnShowAllCats = new Button();
            btnShowAllProds = new Button();
            btnSearchCat = new Button();
            btnSearchProds = new Button();
            btnDeleteSelCat = new Button();
            btnDelSelProd = new Button();
            tbSearchCat = new TextBox();
            tbSearchProds = new TextBox();
            gbCategory.SuspendLayout();
            gbProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // gbCategory
            // 
            gbCategory.Controls.Add(btnAddCat);
            gbCategory.Controls.Add(lblDescript);
            gbCategory.Controls.Add(lblCatName);
            gbCategory.Controls.Add(tbCatName);
            gbCategory.Controls.Add(tbCatDescript);
            gbCategory.Location = new Point(12, 12);
            gbCategory.Name = "gbCategory";
            gbCategory.Size = new Size(367, 208);
            gbCategory.TabIndex = 0;
            gbCategory.TabStop = false;
            gbCategory.Text = "Add Category";
            // 
            // btnAddCat
            // 
            btnAddCat.Cursor = Cursors.Hand;
            btnAddCat.Location = new Point(11, 169);
            btnAddCat.Name = "btnAddCat";
            btnAddCat.Size = new Size(85, 29);
            btnAddCat.TabIndex = 2;
            btnAddCat.Text = "Add";
            btnAddCat.UseVisualStyleBackColor = true;
            btnAddCat.Click += BtnAddCategory_Click;
            // 
            // lblDescript
            // 
            lblDescript.AutoSize = true;
            lblDescript.Location = new Point(11, 101);
            lblDescript.Name = "lblDescript";
            lblDescript.Size = new Size(85, 20);
            lblDescript.TabIndex = 3;
            lblDescript.Text = "Description";
            // 
            // lblCatName
            // 
            lblCatName.AutoSize = true;
            lblCatName.Location = new Point(11, 33);
            lblCatName.Name = "lblCatName";
            lblCatName.Size = new Size(113, 20);
            lblCatName.TabIndex = 2;
            lblCatName.Text = "Category Name";
            // 
            // tbCatName
            // 
            tbCatName.Location = new Point(11, 56);
            tbCatName.Name = "tbCatName";
            tbCatName.Size = new Size(329, 27);
            tbCatName.TabIndex = 0;
            // 
            // tbCatDescript
            // 
            tbCatDescript.Location = new Point(11, 124);
            tbCatDescript.Name = "tbCatDescript";
            tbCatDescript.Size = new Size(329, 27);
            tbCatDescript.TabIndex = 1;
            // 
            // gbProduct
            // 
            gbProduct.Controls.Add(tbVendorId);
            gbProduct.Controls.Add(lblVendorId);
            gbProduct.Controls.Add(tbCatId);
            gbProduct.Controls.Add(btnAddPro);
            gbProduct.Controls.Add(lblRetPrice);
            gbProduct.Controls.Add(lblCatId);
            gbProduct.Controls.Add(lblWholePrice);
            gbProduct.Controls.Add(lblProdName);
            gbProduct.Controls.Add(tbProdName);
            gbProduct.Controls.Add(tbProdDescript);
            gbProduct.Controls.Add(tbProdWholePrice);
            gbProduct.Controls.Add(lblProdDescript);
            gbProduct.Controls.Add(tbProdRetPrice);
            gbProduct.Location = new Point(12, 226);
            gbProduct.Name = "gbProduct";
            gbProduct.Size = new Size(367, 473);
            gbProduct.TabIndex = 1;
            gbProduct.TabStop = false;
            gbProduct.Text = "Add Product";
            // 
            // tbVendorId
            // 
            tbVendorId.Location = new Point(11, 303);
            tbVendorId.Name = "tbVendorId";
            tbVendorId.Size = new Size(335, 27);
            tbVendorId.TabIndex = 7;
            // 
            // lblVendorId
            // 
            lblVendorId.AutoSize = true;
            lblVendorId.Location = new Point(11, 280);
            lblVendorId.Name = "lblVendorId";
            lblVendorId.Size = new Size(75, 20);
            lblVendorId.TabIndex = 16;
            lblVendorId.Text = "Vendor ID";
            // 
            // tbCatId
            // 
            tbCatId.Location = new Point(11, 375);
            tbCatId.Name = "tbCatId";
            tbCatId.Size = new Size(335, 27);
            tbCatId.TabIndex = 8;
            // 
            // btnAddPro
            // 
            btnAddPro.Cursor = Cursors.Hand;
            btnAddPro.Location = new Point(11, 422);
            btnAddPro.Name = "btnAddPro";
            btnAddPro.Size = new Size(91, 29);
            btnAddPro.TabIndex = 9;
            btnAddPro.Text = "Add";
            btnAddPro.UseVisualStyleBackColor = true;
            btnAddPro.Click += BtnAddProduct_Click;
            // 
            // lblRetPrice
            // 
            lblRetPrice.AutoSize = true;
            lblRetPrice.Location = new Point(11, 155);
            lblRetPrice.Name = "lblRetPrice";
            lblRetPrice.Size = new Size(83, 20);
            lblRetPrice.TabIndex = 12;
            lblRetPrice.Text = "Retail Price";
            // 
            // lblCatId
            // 
            lblCatId.AutoSize = true;
            lblCatId.Location = new Point(11, 352);
            lblCatId.Name = "lblCatId";
            lblCatId.Size = new Size(88, 20);
            lblCatId.TabIndex = 14;
            lblCatId.Text = "Category ID";
            // 
            // lblWholePrice
            // 
            lblWholePrice.AutoSize = true;
            lblWholePrice.Location = new Point(11, 221);
            lblWholePrice.Name = "lblWholePrice";
            lblWholePrice.Size = new Size(114, 20);
            lblWholePrice.TabIndex = 11;
            lblWholePrice.Text = "Wholesale Price";
            // 
            // lblProdName
            // 
            lblProdName.AutoSize = true;
            lblProdName.Location = new Point(11, 32);
            lblProdName.Name = "lblProdName";
            lblProdName.Size = new Size(104, 20);
            lblProdName.TabIndex = 9;
            lblProdName.Text = "Product Name";
            // 
            // tbProdName
            // 
            tbProdName.Location = new Point(11, 55);
            tbProdName.Name = "tbProdName";
            tbProdName.Size = new Size(335, 27);
            tbProdName.TabIndex = 3;
            // 
            // tbProdDescript
            // 
            tbProdDescript.Location = new Point(11, 111);
            tbProdDescript.Name = "tbProdDescript";
            tbProdDescript.Size = new Size(335, 27);
            tbProdDescript.TabIndex = 4;
            // 
            // tbProdWholePrice
            // 
            tbProdWholePrice.Location = new Point(11, 244);
            tbProdWholePrice.Name = "tbProdWholePrice";
            tbProdWholePrice.Size = new Size(335, 27);
            tbProdWholePrice.TabIndex = 6;
            // 
            // lblProdDescript
            // 
            lblProdDescript.AutoSize = true;
            lblProdDescript.Location = new Point(11, 88);
            lblProdDescript.Name = "lblProdDescript";
            lblProdDescript.Size = new Size(85, 20);
            lblProdDescript.TabIndex = 10;
            lblProdDescript.Text = "Description";
            // 
            // tbProdRetPrice
            // 
            tbProdRetPrice.Location = new Point(11, 178);
            tbProdRetPrice.Name = "tbProdRetPrice";
            tbProdRetPrice.Size = new Size(335, 27);
            tbProdRetPrice.TabIndex = 5;
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Cursor = Cursors.Hand;
            dgvCategories.Location = new Point(404, 50);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.Size = new Size(1083, 284);
            dgvCategories.TabIndex = 2;
            dgvCategories.CellClick += DgvCategories_CellClick;
            dgvCategories.DataBindingComplete += DgvCategories_DataBindingComplete;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(404, 394);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(1083, 283);
            dgvProducts.TabIndex = 3;
            dgvProducts.DataBindingComplete += DgvProducts_DataBindingComplete;
            // 
            // lblCats
            // 
            lblCats.AutoSize = true;
            lblCats.Location = new Point(404, 12);
            lblCats.Name = "lblCats";
            lblCats.Size = new Size(80, 20);
            lblCats.TabIndex = 4;
            lblCats.Text = "Categories";
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Location = new Point(404, 353);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(66, 20);
            lblProducts.TabIndex = 5;
            lblProducts.Text = "Products";
            // 
            // btnShowAllCats
            // 
            btnShowAllCats.Cursor = Cursors.Hand;
            btnShowAllCats.Location = new Point(490, 8);
            btnShowAllCats.Name = "btnShowAllCats";
            btnShowAllCats.Size = new Size(87, 29);
            btnShowAllCats.TabIndex = 10;
            btnShowAllCats.Text = "Show All";
            btnShowAllCats.UseVisualStyleBackColor = true;
            btnShowAllCats.Click += BtnShowAllCategories_Click;
            // 
            // btnShowAllProds
            // 
            btnShowAllProds.Cursor = Cursors.Hand;
            btnShowAllProds.Location = new Point(483, 350);
            btnShowAllProds.Name = "btnShowAllProds";
            btnShowAllProds.Size = new Size(155, 29);
            btnShowAllProds.TabIndex = 14;
            btnShowAllProds.Text = "Show All Products";
            btnShowAllProds.UseVisualStyleBackColor = true;
            btnShowAllProds.Click += BtnShowAllProducts_Click;
            // 
            // btnSearchCat
            // 
            btnSearchCat.Cursor = Cursors.Hand;
            btnSearchCat.Location = new Point(1188, 10);
            btnSearchCat.Name = "btnSearchCat";
            btnSearchCat.Size = new Size(81, 29);
            btnSearchCat.TabIndex = 12;
            btnSearchCat.Text = "Search";
            btnSearchCat.UseVisualStyleBackColor = true;
            btnSearchCat.Click += BtnSearchCats_Click;
            // 
            // btnSearchProds
            // 
            btnSearchProds.Cursor = Cursors.Hand;
            btnSearchProds.Location = new Point(1188, 350);
            btnSearchProds.Name = "btnSearchProds";
            btnSearchProds.Size = new Size(81, 29);
            btnSearchProds.TabIndex = 16;
            btnSearchProds.Text = "Search";
            btnSearchProds.UseVisualStyleBackColor = true;
            btnSearchProds.Click += BtnSearchProducts_Click;
            // 
            // btnDeleteSelCat
            // 
            btnDeleteSelCat.Cursor = Cursors.Hand;
            btnDeleteSelCat.Location = new Point(1291, 9);
            btnDeleteSelCat.Name = "btnDeleteSelCat";
            btnDeleteSelCat.Size = new Size(196, 29);
            btnDeleteSelCat.TabIndex = 13;
            btnDeleteSelCat.Text = "Delete Selected Category";
            btnDeleteSelCat.UseVisualStyleBackColor = true;
            btnDeleteSelCat.Click += BtnDelSelCategory_Click;
            // 
            // btnDelSelProd
            // 
            btnDelSelProd.Cursor = Cursors.Hand;
            btnDelSelProd.Location = new Point(1291, 350);
            btnDelSelProd.Name = "btnDelSelProd";
            btnDelSelProd.Size = new Size(196, 29);
            btnDelSelProd.TabIndex = 17;
            btnDelSelProd.Text = "Delete Selected Product";
            btnDelSelProd.UseVisualStyleBackColor = true;
            btnDelSelProd.Click += BtnDelSelProduct_Click;
            // 
            // tbSearchCat
            // 
            tbSearchCat.Location = new Point(599, 10);
            tbSearchCat.Name = "tbSearchCat";
            tbSearchCat.Size = new Size(571, 27);
            tbSearchCat.TabIndex = 11;
            // 
            // tbSearchProds
            // 
            tbSearchProds.Location = new Point(654, 350);
            tbSearchProds.Name = "tbSearchProds";
            tbSearchProds.Size = new Size(516, 27);
            tbSearchProds.TabIndex = 15;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1515, 711);
            Controls.Add(tbSearchProds);
            Controls.Add(tbSearchCat);
            Controls.Add(btnDelSelProd);
            Controls.Add(btnDeleteSelCat);
            Controls.Add(btnSearchProds);
            Controls.Add(btnSearchCat);
            Controls.Add(btnShowAllProds);
            Controls.Add(btnShowAllCats);
            Controls.Add(lblProducts);
            Controls.Add(lblCats);
            Controls.Add(dgvProducts);
            Controls.Add(dgvCategories);
            Controls.Add(gbProduct);
            Controls.Add(gbCategory);
            Name = "ProductsForm";
            Text = "Products";
            gbCategory.ResumeLayout(false);
            gbCategory.PerformLayout();
            gbProduct.ResumeLayout(false);
            gbProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbCategory;
        private GroupBox gbProduct;
        private Button btnAddCat;
        private Label lblDescript;
        private Label lblCatName;
        private TextBox tbCatName;
        private TextBox tbCatDescript;
        private Label lblRetPrice;
        private Label lblWholePrice;
        private Label lblProdName;
        private TextBox tbProdName;
        private TextBox tbProdDescript;
        private TextBox tbProdWholePrice;
        private Label lblProdDescript;
        private TextBox tbProdRetPrice;
        private Button btnAddPro;
        private DataGridView dgvCategories;
        private DataGridView dgvProducts;
        private Label lblCats;
        private Label lblProducts;
        private Button btnShowAllCats;
        private Button btnShowAllProds;
        private Button btnSearchCat;
        private Button btnSearchProds;
        private Button btnDeleteSelCat;
        private Button btnDelSelProd;
        private TextBox tbSearchCat;
        private TextBox tbSearchProds;
        private TextBox tbCatId;
        private Label lblCatId;
        private TextBox tbVendorId;
        private Label lblVendorId;
    }
}
