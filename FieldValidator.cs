using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    internal class FieldValidator
    {
        // Helper method to validate all product fields at once
        public static bool ValidateFields(string name,
                                          string description,
                                          string retPrice,
                                          string wsPrice,
                                          string venId,
                                          string catId)
        {
            return AllFieldsHaveValue(name,
                                      description,
                                      retPrice,
                                      wsPrice,
                                      venId,
                                      catId) &&
                   EveryPriceIsValid(retPrice, wsPrice) &&
                   EveryIdIsValid(venId, catId);
        }

        // Helper method to ensure category fields are not empty
        public static bool AllFieldsHaveValue(string name, string description)
        {
            return FieldHasValue(name, "Category name") &&
                   FieldHasValue(description, "Category description");

        }

        // Overloading EveryFieldHasValue method to check product fields
        private static bool AllFieldsHaveValue(string name,
                                               string description,
                                               string retPrice,
                                               string wsPrice,
                                               string venId,
                                               string catId)
        {
            return FieldHasValue(name, "Product name") &&
                   FieldHasValue(description, "Product description") &&
                   FieldHasValue(retPrice, "Product retail price") &&
                   FieldHasValue(wsPrice, "Product wholesale price") &&
                   FieldHasValue(venId, "Product vendor ID") &&
                   FieldHasValue(catId, "Product category ID");
        }

        // Helper method to ensure a single field is filled out
        private static bool FieldHasValue(string fieldType, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(fieldType))
            {
                MessageBox.Show($"{fieldName} cannot be empty.");
                return false;
            }
            return true;
        }


        private static bool EveryPriceIsValid(string retPriceTxt, string wsPriceTxt)
        {
            return ValidDecimalPrice(retPriceTxt, "Retail price") &&
                   ValidDecimalPrice(wsPriceTxt, "Wholesale price");
        }

        private static bool ValidDecimalPrice(string priceTxt, string field)
        {
            if (!decimal.TryParse(priceTxt, out decimal price))
            {
                MessageBox.Show($"{field} must be a valid number.");
                return false;
            }

            if (price < 0)
            {
                MessageBox.Show($"{field} cannot be a negative number.");
                return false;
            }

            if (!ValidPriceFormat(price))
            {
                MessageBox.Show($"{field} cannot have more than two decimal places.");
                return false;
            }


            return true;
        }

        // Helper method to ensure the price is entered in the correct format
        private static bool ValidPriceFormat(decimal price)
        {
            var decimalPlaces = BitConverter.GetBytes(decimal.GetBits(price)[3])[2];
            return decimalPlaces <= 2;
        }

        private static bool EveryIdIsValid(string venIdTxt, string catIdTxt)
        {
            return IdIsValid(venIdTxt, "vendor") && IdIsValid(catIdTxt, "category");
        }

        private static bool IdIsValid(string idTxt, string idType)
        {
            if (!int.TryParse(idTxt, out int id) || id < 1)
            {
                MessageBox.Show($"Please, enter valid {idType} id.");
                return false;
            }

            return true;
        }
    }
}
