using Products.Data;
using Products.Models;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace Products
{
    public partial class ProductsForm : Form
    {
        // Name of the column containing category Id
        private string _colCatId = "Id";
        private string _colProdId = "Id";

        private BindingSource _catBindingSource = new BindingSource();
        private BindingSource _prodBindingSource = new BindingSource();

        private readonly ICategoryRepository _catRepository;
        private readonly IProductRepository _prodRepository;

        // Dependency injection through constructor
        public ProductsForm(ICategoryRepository catRepository, IProductRepository prodRepository)
        {
            InitializeComponent();
            _catRepository = catRepository;
            _prodRepository = prodRepository;

            dgvProducts.DataBindingComplete += DgvProducts_DataBindingComplete;
            dgvCategories.DataBindingComplete += DgvCategories_DataBindingComplete;
        }

        private async void BtnShowAllCategories_Click(object sender, EventArgs e)
        {
            btnShowAllCats.Enabled = false;

            try
            {
                // Connect the list to the grid view control
                _catBindingSource.DataSource = await _catRepository.ShowAllCategoriesAsync();
                dgvCategories.DataSource = _catBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error handling showing all categories event: {ex.Message}");
            }
            finally
            {
                btnShowAllCats.Enabled = true;
            }
        }

        private async void BtnSearchCats_Click(object sender, EventArgs e)
        {
            // Disable search button to prevent multiple clicks
            btnSearchCat.Enabled = false;

            try
            {
                _catBindingSource.DataSource = await _catRepository.SearchCategoriesAsync(tbSearchCat.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error handling search event: {ex.Message}");
            }
            finally
            {
                btnSearchCat.Enabled = true;
            }
        }

        private async void BtnAddCategory_Click(object sender, EventArgs e)
        {
            btnAddCat.Enabled = false;

            try
            {
                // Validating all category fields
                if (!FieldValidator.AllFieldsHaveValue(tbCatName.Text, tbCatDescript.Text))
                    return;

                // New item to be added to the database
                var addedCat = new Category
                {
                    Name = tbCatName.Text,
                    Description = tbCatDescript.Text
                };

                var result = await _catRepository.AddNewCategoryAsync(addedCat);

                // Refresh table
                _catBindingSource.DataSource = await _catRepository.ShowAllCategoriesAsync();

                ClearCatFields();

                MessageBox.Show($"{result} new row was inserted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error handling adding category event: {ex.Message}");
            }
            finally
            {
                btnAddCat.Enabled = true;
            }
        }


        private async void BtnDelSelCategory_Click(object sender, EventArgs e)
        {
            btnDeleteSelCat.Enabled = false;

            try
            {
                // Get the row number clicked
                var rowClicked = dgvCategories.CurrentRow.Index;

                // Retrieve category ID
                var delCatId = (int)dgvCategories.Rows[rowClicked].Cells[_colCatId].Value;
                var result = await _catRepository.DeleteCategoryAsync(delCatId);
                _catBindingSource.DataSource = await _catRepository.ShowAllCategoriesAsync();
                MessageBox.Show($"{result} row was deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error handling category deletion: {ex.Message}");
            }
            finally
            {
                btnDeleteSelCat.Enabled = true;
            }
        }

        private async void DgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Clicking the column header won't produce any result
                if (e.RowIndex < 0)
                    return;

                var catId = (int)dgvCategories.Rows[e.RowIndex].Cells[_colCatId].Value;

                _prodBindingSource.DataSource = await _prodRepository.ShowProductsByCategoryAsync(catId);
                dgvProducts.DataSource = _prodBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing products by category: {ex.Message}");
            }
        }

        private async void BtnShowAllProducts_Click(object sender, EventArgs e)
        {
            btnShowAllProds.Enabled = false;

            try
            {
                _prodBindingSource.DataSource = await _prodRepository.ShowAllProductsAsync();
                dgvProducts.DataSource = _prodBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing all products: {ex.Message}");
            }
            finally
            {
                btnShowAllProds.Enabled = true;
            }
        }

        private async void BtnSearchProducts_Click(object sender, EventArgs e)
        {
            btnSearchProds.Enabled = false;

            try
            {
                _prodBindingSource.DataSource = await _prodRepository.SearchProductsAsync(tbSearchProds.Text);
                // dgvProducts.DataSource = _prodBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching products: {ex.Message}");
            }
            finally
            {
                btnSearchProds.Enabled = true;
            }
        }

        private async void BtnAddProduct_Click(object sender, EventArgs e)
        {
            btnAddPro.Enabled = false;

            try
            {
                // Validate all fields are entered correctly.
                if (!FieldValidator.ValidateFields(tbProdName.Text,
                                                   tbProdDescript.Text,
                                                   tbProdRetPrice.Text,
                                                   tbProdWholePrice.Text,
                                                   tbVendorId.Text,
                                                   tbCatId.Text))
                    return;

                var addedProd = CreateProdObject();

                var addResult = await _prodRepository.AddNewProductAsync(addedProd);
                _prodBindingSource.DataSource = await _prodRepository.ShowAllProductsAsync();

                ClearProductFields();

                MessageBox.Show($"{addResult} new product was added.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding new product: {ex.Message}");
            }
            finally
            {
                btnAddPro.Enabled = true;
            }
        }

        private async void BtnDelSelProduct_Click(object sender, EventArgs e)
        {
            btnDelSelProd.Enabled = false;

            try
            {
                var rowCliced = dgvProducts.CurrentRow.Index;
                var delSelId = (int)dgvProducts.Rows[rowCliced].Cells[_colProdId].Value;

                var delSelResult = await _prodRepository.DeleteProductAsync(delSelId);
                _prodBindingSource.DataSource = await _prodRepository.ShowAllProductsAsync();
                MessageBox.Show($"{delSelResult} product was deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleteing product: {ex.Message}");
            }
            finally
            {
                btnDelSelProd.Enabled = true;
            }
        }

        private void DgvCategories_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GridViewFormatter.FormatCategoriesGrid(dgvCategories);
        }

        private void DgvProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            GridViewFormatter.FormatProductGrid(dgvProducts);
        }

        // Helper method to assign new values to Product object.
        private Product CreateProdObject()
        {
            var retPrice = Convert.ToDecimal(tbProdRetPrice.Text);
            var wsPrice = Convert.ToDecimal(tbProdWholePrice.Text);

            var vendorId = Convert.ToInt32(tbVendorId.Text);
            var catId = Convert.ToInt32(tbCatId.Text);


            var addedProd = new Product
            {
                Name = tbProdName.Text,
                Description = tbProdDescript.Text,
                RetailPrice = retPrice,
                WholesalePrice = wsPrice,
                VendorId = vendorId,
                CatId = catId
            };
            return addedProd;
        }

        // Helper method to clear all category fields after adding new category
        private void ClearCatFields()
        {
            tbCatName.Clear();
            tbCatDescript.Clear();
        }

        // Helper method to clear all product fields after adding new product
        private void ClearProductFields()
        {
            tbProdName.Clear();
            tbProdDescript.Clear();
            tbProdRetPrice.Clear();
            tbProdWholePrice.Clear();
            tbVendorId.Clear();
            tbCatId.Clear();
        }
    }
}