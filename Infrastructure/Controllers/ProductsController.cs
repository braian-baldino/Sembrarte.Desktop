using Models.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Infrastructure.Controllers
{
    public class ProductsController
    {
        #region Private Props

        private IList<Product> _selectedItems { get; set; }

        #endregion

        #region Public Props

        public List<Product> Products { get; set; }
        public int NumberOfSelectedItems => SelectedItems?.Count ?? 0;

        public IList<Product> SelectedItems
        {
            get => _selectedItems ?? new List<Product>();
            set
            {
                if (value != null)
                    _selectedItems = value;
            }
        }

        #endregion

        public ProductsController()
        {
            Products = new List<Product>();
            Products.Add(new Product()
            {
                Code = "XC520D",
                ProductName = "Lapicera",
                Details = "Color Azul",
                Price = 5.00
            });
            Products.Add(new Product()
            {
                Code = "BG86C",
                ProductName = "Acrilico",
                Details = "50 ml Magenta",
                Price = 125.00
            });
        }

        #region Public Methods

        public void AddProduct(Product product)
        {
            try
            {
                if (product != null)
                    Products.Add(product);

                throw new Exception();
            }
            catch (Exception)
            {
                var title = "Error";
                var textMessage = $"Error al cargar producto: {product.Code} {product.ProductName}";
                MessageBox.Show(textMessage, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
