using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Infrastructure.Controllers
{
    public class FiltersController
    {
        private readonly DataGridView _gridView;
        private readonly List<Product> _allProducts;
        private readonly TextBox _nameFilter;
        private readonly TextBox _codeFilter;
        private readonly TextBox _detailsFilter;
        private readonly NumericUpDown _priceFilter;

        private bool HasAnyFilter => HasNameFilter
            || HasCodeFilter
            || HasDetailsFilter
            || HasPriceFilter;

        private bool HasNameFilter => !string.IsNullOrEmpty(_nameFilter.Text);
        private bool HasCodeFilter => !string.IsNullOrEmpty(_codeFilter.Text);
        private bool HasDetailsFilter => !string.IsNullOrEmpty(_detailsFilter.Text);
        private bool HasPriceFilter => (double)_priceFilter.Value != 0.00;

        public FiltersController(DataGridView gridView,List<Product> allProducts,TextBox name, TextBox code, TextBox details, NumericUpDown price)
        {
            _gridView = gridView;
            _allProducts = allProducts;
            _nameFilter = name;
            _codeFilter = code;
            _detailsFilter = details;
            _priceFilter = price;
        }

        private IEnumerable<Product> FilterExpression(Func<Product,bool> expression) => _allProducts.Where(expression);

        public void FilterDataGrid()
        {
            if (HasAnyFilter)
            {
                List<Product> filteredData;

                if (HasCodeFilter)
                {
                    filteredData = new List<Product>();
                    filteredData.AddRange(FilterExpression(p => p.Code.Contains(_codeFilter.Text)));
                    UpdateGrid(filteredData);
                }

                if (HasNameFilter)
                {
                    filteredData = new List<Product>();
                    filteredData.AddRange(FilterExpression(p => p.ProductName.Contains(_nameFilter.Text)));
                    UpdateGrid(filteredData);
                }

                if (HasDetailsFilter)
                {
                    filteredData = new List<Product>();
                    filteredData.AddRange(FilterExpression(p => p.Code.Contains(_detailsFilter.Text)));
                    UpdateGrid(filteredData);
                }

                if (HasPriceFilter)
                {
                    filteredData = new List<Product>();
                    filteredData.AddRange(FilterExpression(p => p.Price == (double)_priceFilter.Value));
                    UpdateGrid(filteredData);
                }
            }
            else
                UpdateGrid(_allProducts);
        }

        public void UpdateGrid(List<Product> products)
        {
            _gridView.DataSource = new List<Product>();
            _gridView.DataSource = products;
        }
    }
}
