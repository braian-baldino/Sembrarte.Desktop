using Infrastructure.Serializer;
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
        private bool SortAscending = false;

        public List<Product> Products { get; set; }

        public ProductsController(DataGridView gridView )
        {
            _gridView = gridView;
            Products = new List<Product>();
        }

        #region Public Methods

        public void LoadData()
        {
            try
            {
                if (Xml<List<Product>>.ReadBinary("sembrarteDB.bin", out List<Product> _data))
                {
                    Products = _data
                        .OrderBy(x => x.Code)
                        .ToList();

                    UpdateGrid(Products);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar sembrarteDB.bin");
            }
        }

        public void SaveData()
        {
            try
            {
                Xml<List<Product>>.SaveBinaryXml("sembrarteDB.bin", Products);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public void SortColumn(int columnIndex)
        {
            List<Product> sortedData;
            switch (_gridView.Columns[columnIndex].DataPropertyName)
            {
                case "Code":
                    sortedData = SortAscending?Products.OrderBy(x => x.Code).ToList(): Products.OrderByDescending(x => x.Code).ToList();
                    break;
                case "ProductName":
                    sortedData = SortAscending ? Products.OrderBy(x => x.ProductName).ToList() : Products.OrderByDescending(x => x.ProductName).ToList();
                    break;
                case "Details":
                    sortedData = SortAscending ? Products.OrderBy(x => x.Details).ToList() : Products.OrderByDescending(x => x.Details).ToList();
                    break;
                case "Price":
                    sortedData = SortAscending ? Products.OrderBy(x => x.Price).ToList() : Products.OrderByDescending(x => x.Price).ToList();
                    break;
                default:
                    sortedData = SortAscending ? Products.OrderBy(x => x.Code).ToList() : Products.OrderByDescending(x => x.Code).ToList();
                    break;
            }

            UpdateGrid(sortedData);
          
            SortAscending = !SortAscending;
        }

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

        public void DeleteProduct()
        {
            if (_gridView.SelectedRows[0] != null && _gridView.SelectedRows.Count == 1)
            {
                var code = (string)_gridView.SelectedRows[0].Cells[0].Value;
                var productName = (string)_gridView.SelectedRows[0].Cells[1].Value;
                var details = (string)_gridView.SelectedRows[0].Cells[2].Value;

                var gridProducts = GetGridProducts();

                foreach (var p in Products)
                {
                    if (p.Code == code && p.ProductName == productName && p.Details == details)
                    {
                        gridProducts.Remove(p);
                        Products.Remove(p);
                        break;
                    }
                }

                UpdateGrid(gridProducts);
            }            
        }

        public void EditProduct(Product newProductInfo)
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
                        p.Code = newProductInfo.Code;
                        p.ProductName = newProductInfo.ProductName;
                        p.Details = newProductInfo.Details;
                        p.Price = newProductInfo.Price;
                        break;
                    }
                }

                UpdateGrid(GetGridProducts());
            }
        }

        public void ThrowErrorMessage(string message)
        {
            var title = "Error";    
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region Private Methods
  
        public void UpdateGrid(List<Product> products)
        {
            _gridView.DataSource = new List<Product>();
            _gridView.DataSource = products;
        }

        private List<Product> GetGridProducts() => (List<Product>)_gridView.DataSource ?? new List<Product>();

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
