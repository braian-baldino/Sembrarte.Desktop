using Infrastructure.Controllers;
using Infrastructure.Entities;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class AddProductFrm : Form
    {
        private readonly ProductsController _productsController;

        #region Movement Props
        private int _move { get; set; }
        private int _moveX { get; set; }
        private int _moveY { get; set; }
        #endregion

        public AddProductFrm(ProductsController productsController)
        {
            InitializeComponent();
            _productsController = productsController;
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        public void SetInputs(Product product)
        {
            codeInput.Text = product.Code;
            descriptionInput.Text = product.Details;
            nameInput.Text = product.ProductName;
            priceInput.Value = (decimal)product.Price;
            buyPriceInput.Value = (decimal)product.BuyPrice;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var newProduct = new Product()
            {
                Code = codeInput?.Text ?? string.Empty,
                ProductName = nameInput?.Text ?? string.Empty,
                Details = descriptionInput?.Text ?? string.Empty,
                Price = (double)priceInput.Value,
                BuyPrice = (double)buyPriceInput.Value
            };

             var success = _productsController.AddProduct(newProduct);

            if (!success)
            {
                var errorMessage = $"Error al cargar producto: {newProduct.Code} {newProduct.ProductName}";
                _productsController.ThrowErrorMessage(errorMessage);
                Close();
                return;
            }

            MessageBox.Show($"Se agrego el producto {newProduct.ProductName}", "✔", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
        }

        private void ClearInputs()
        {
            codeInput.Text = string.Empty;
            nameInput.Text = string.Empty;
            descriptionInput.Text = string.Empty;
            priceInput.Value = (decimal)0;
            buyPriceInput.Value = (decimal)0;
        }

        #region Mouse Events
        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            _move = 1;
            _moveX = e.X;
            _moveY = e.Y;
        }

        private void titleBar_MouseUp(object sender, MouseEventArgs e)
        {
            _move = 0;
        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (_move == 1)
                SetDesktopLocation(MousePosition.X - _moveX, MousePosition.Y - _moveY);
        }
        private void lblTitle_MouseUp(object sender, MouseEventArgs e)
        {
            _move = 0;
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            _move = 1;
            _moveX = e.X;
            _moveY = e.Y;
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (_move == 1)
                SetDesktopLocation(MousePosition.X - _moveX, MousePosition.Y - _moveY);
        }
        #endregion

        private void btnMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
