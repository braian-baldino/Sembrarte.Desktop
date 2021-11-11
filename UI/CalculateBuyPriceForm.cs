using Infrastructure.Controllers;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infrastructure.Utilities;

namespace SembrarteApp
{
    public partial class CalculateBuyPriceForm : Form
    {
        private readonly ProductsController _productsController;
        private readonly List<Product> _products;

        #region Movement Props
        private int _move { get; set; }
        private int _moveX { get; set; }
        private int _moveY { get; set; }
        #endregion

        public CalculateBuyPriceForm(ProductsController controller)
        {
            InitializeComponent();
            _productsController = controller;
            _products = _productsController.Products;
        }

        private void CalculateBuyPriceForm_Load(object sender, EventArgs e)
        {
            codeComboBox.DataSource = new List<string>();
            if (_products.Any())
            {
                var productsHashSet = new HashSet<string>();
                _products.ForEach(p => productsHashSet.Add(p.Code != string.Empty ? p.Code.Trim().ToLower() : p.Code));
                codeComboBox.DataSource = productsHashSet.ToList();
            }
                
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                var filterCode = (string)codeComboBox.SelectedItem ?? string.Empty;
                var porcentage = (int)porcentageInput.Value;
                var productsCount = _products.Where(p => p.Code == filterCode && p.BuyPrice > 0).ToList().Count;
                var ivaText = ivaCheckBox.Checked ? "Incluido" : "No incluido";

                var sb = new StringBuilder();
                sb.AppendLine($"Se aplicara el {porcentage}% a {productsCount} productos:");
                sb.AppendLine($"Codigo: {filterCode}");
                sb.AppendLine($"IVA: {ivaText}");

                var response = MessageBox.Show(sb.ToString(), "Aplicar margen", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (response == DialogResult.Yes)
                {
                    foreach (var product in _products)
                    {
                        if (product.Code == filterCode && product.BuyPrice > 0)
                        {
                            var buyPrice = ivaCheckBox.Checked ? Calculator.CalculateIVA(product.BuyPrice) : product.BuyPrice;
                            product.Price = Calculator.ApplyPorcentage(buyPrice, porcentage);
                        }
                            
                    }

                    _productsController.UpdateGridFromFilteredGrid();
                    _productsController.SaveData();
                    MessageBox.Show("Se aplico todo re piola!");
                    Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se aplico nada porque algo fallo :(");
                Close();
            }      
        }

        private void btnMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        #region Mouse Events
        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            _move = 1;
            _moveX = e.X;
            _moveY = e.Y;
        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (_move == 1)
                SetDesktopLocation(MousePosition.X - _moveX, MousePosition.Y - _moveY);
        }

        private void titleBar_MouseUp(object sender, MouseEventArgs e)
        {
            _move = 0;
        }
        #endregion
    }
}
