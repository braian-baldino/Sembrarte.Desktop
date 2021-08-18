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

        public void FilterDataGrid()
        {
            if (HasAnyFilter)
            {
                if (HasCodeFilter)
                    FilterByCondition(p => p.Code.Contains(_codeFilter.Text));

                if (HasNameFilter)
                    FilterByCondition(p => p.ProductName.Contains(_nameFilter.Text));

                if (HasDetailsFilter)
                    FilterByCondition(p => p.Details.Contains(_detailsFilter.Text));

                if (HasPriceFilter)
                    FilterByCondition(p => p.Price == (double)_priceFilter.Value);

            }
            else
                UpdateGrid(_allProducts);
        }

        private IEnumerable<Product> FilterExpression(Func<Product, bool> expression) => _allProducts.Where(expression);

        private void FilterByCondition(Func<Product, bool> expression)
        {
            var filteredData = new List<Product>();

            filteredData.AddRange(FilterExpression(expression));
            UpdateGrid(filteredData);
        }

        private void UpdateGrid(List<Product> products)
        {
            _gridView.DataSource = new List<Product>();
            _gridView.DataSource = products;
        }
    }
}
