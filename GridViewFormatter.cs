using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    internal class GridViewFormatter
    {
        private static string _catIdCol = "Id";
        private static string _catNameCol = "Name";
        private static string _catDescriptCol = "Description";

        private static string _prodIdCol = "Id";
        private static string _prodNameCol = "Name";
        private static string _prodDescriptCol = "Description";
        private static string _prodRetPriceCol = "RetailPrice";
        private static string _prodWsPriceCol = "WholesalePrice";
        private static string _prodVenIdCol = "VendorId";
        private static string _prodCatIdCol = "CatId";
        
        public static void FormatCategoriesGrid(DataGridView gridView)
        {
            SetColumnWidt(gridView, _catIdCol, 7);
            SetColumnWidt(gridView, _catNameCol, 20);
            SetColumnWidt(gridView, _catDescriptCol, 73);

            WrapColumn(gridView, _catDescriptCol);
        }
        
        public static void FormatProductGrid(DataGridView gridView)
        {
            SetColumnWidt(gridView, _prodIdCol, 5);
            SetColumnWidt(gridView, _prodNameCol, 20);
            SetColumnWidt(gridView, _prodDescriptCol, 45);
            SetColumnWidt(gridView, _prodRetPriceCol, 7);
            SetColumnWidt(gridView, _prodWsPriceCol, 8);
            SetColumnWidt(gridView, _prodVenIdCol, 7);
            SetColumnWidt(gridView, _prodCatIdCol, 8);

            RenameProdColHeaders(gridView);

            WrapColumn(gridView, _prodNameCol);
            WrapColumn(gridView, _prodDescriptCol);
        }

        private static void WrapColumn(DataGridView gridView, string colName)
        {
            gridView.Columns[colName].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            gridView.RowTemplate.Height = 60;
        }

        private static void RenameProdColHeaders(DataGridView gridView)
        {
            gridView.Columns[_prodRetPriceCol].HeaderText = "Retail Price";
            gridView.Columns[_prodWsPriceCol].HeaderText = "Wholesale Price";
            gridView.Columns[_prodVenIdCol].HeaderText = "Vendor ID";
            gridView.Columns[_prodCatIdCol].HeaderText = "Category ID";
        }

        private static void SetColumnWidt(DataGridView gridView, string colName, int percentage)
        {
            gridView.Columns[colName].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridView.Columns[colName].FillWeight = percentage;
        }
    }
}
