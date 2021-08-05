using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Infrastructure.Controllers
{
    public class ProductsController
    {
        private readonly DataGridView _gridView;

        public List<Product> Products { get; set; }

        public ProductsController(DataGridView gridView)
        {
            _gridView = gridView;
            Products = new List<Product>();

            //Remove
            GenerateMockData();
        }

        #region Public Methods

        public Product GetSelectedProduct()
        {
            if(_gridView.SelectedRows[0] != null && _gridView.SelectedRows.Count == 1)
            {
                var code = (string)_gridView.SelectedRows[0].Cells[0].Value;
                var productName = (string)_gridView.SelectedRows[0].Cells[1].Value;
                var details = (string)_gridView.SelectedRows[0].Cells[2].Value;

                return Products.SingleOrDefault(p => p.Code == code && p.ProductName == productName && p.Details == details);
            }

            return null;
        }

        public bool AddProduct(Product product)
        {
            try
            {
                if (product == null)
                    throw new Exception();

                Products.Add(product);
                UpdateGrid(Products);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RemoveProduct(Product product)
        {
            try
            {
                if (product == null)
                    throw new Exception();

                var result = Products.Remove(product);

                UpdateGrid(Products);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void DeleteProduct()
        {
            if (_gridView.SelectedRows[0] != null && _gridView.SelectedRows.Count == 1)
            {
                var code = (string)_gridView.SelectedRows[0].Cells[0].Value;
                var productName = (string)_gridView.SelectedRows[0].Cells[1].Value;
                var details = (string)_gridView.SelectedRows[0].Cells[2].Value;

                foreach (var p in Products)
                {
                    if (p.Code == code && p.ProductName == productName && p.Details == details)
                    {
                        Products.Remove(p);
                        break;
                    }
                }

                UpdateGrid(Products);
            }            
        }

        public void ThrowErrorMessage(string message)
        {
            var title = "Error";    
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void FilterDataGridByProductName(TextBox input)
        {
            if (!string.IsNullOrEmpty(input.Text))
            {
                var filteredData = new List<Product>();
                var filter = input.Text.ToLower();

                Products.ForEach(item => AddByProductName(filteredData, item, filter));

                if (filteredData.Any())
                    UpdateGrid(filteredData);            
            }
            else
                UpdateGrid(Products);
        }

        public void FilterDataGridByCode(TextBox input)
        {
            if (!string.IsNullOrEmpty(input.Text))
            {
                var filteredData = new List<Product>();
                var filter = input.Text.ToLower();

                Products.ForEach(item => AddByCode(filteredData, item, filter));

                if (filteredData.Any())
                    UpdateGrid(filteredData);
            }
            else
                UpdateGrid(Products);
        }

        public void FilterDataGridByDetails(TextBox input)
        {
            if (!string.IsNullOrEmpty(input.Text))
            {
                var filteredData = new List<Product>();
                var filter = input.Text.ToLower();

                Products.ForEach(item => AddByDetail(filteredData, item, filter));

                if (filteredData.Any())
                    UpdateGrid(filteredData);
            }
            else
                UpdateGrid(Products);
        }

        public void FilterDataGridByPrice(NumericUpDown numericInput)
        {
            if ((double)numericInput.Value != 0.00)
            {
                var filteredData = new List<Product>();
                var filter = (double)numericInput.Value;

                Products.ForEach(item => AddByPrice(filteredData, item, filter));

                if (filteredData.Any())
                    UpdateGrid(filteredData);
            }
            else
                UpdateGrid(Products);
        }

        #endregion

        #region Private Methods
        private void AddByProductName(List<Product> filteredData,Product product,string filter)
        {
            if (product.ProductName.ToLower().Contains(filter))
                filteredData.Add(product);
        }

        private void AddByPrice(List<Product> filteredData, Product product, double filter)
        {
            if ((int)product.Price == (int)filter)
                filteredData.Add(product);
        }

        private void AddByDetail(List<Product> filteredData, Product product, string filter)
        {
            if (product.Details.ToLower().Contains(filter))
                filteredData.Add(product);
        }

        private void AddByCode(List<Product> filteredData, Product product, string filter)
        {
            if (product.Code.ToLower().Contains(filter))
                filteredData.Add(product);
        }

        private void UpdateGrid(List<Product> products)
        {
            _gridView.DataSource = new List<Product>();
            _gridView.DataSource = products;
        }

        private void GenerateMockData()
        {
            //Mock Data
            Products.Add(new Product()
            {
                Code = string.Empty,
                ProductName = "Lapicera",
                Details = "Roja",
                Price = 5.20
            });
            Products.Add(new Product()
            {
                Code = "GB520",
                ProductName = "Bastidor",
                Details = "Tela blanca 20x50",
                Price = 520.00
            });
            Products.Add(new Product()
            {
                Code = "H-80006",
                ProductName = "Acrilico Eterna",
                Details = "Magenta 25 ml",
                Price = 150.00
            });

            UpdateGrid(Products);
        }
        #endregion
    }
}
