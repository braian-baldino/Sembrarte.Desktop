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

namespace UI
{
    public partial class EditProductFrm : Form
    {
        private readonly ProductsController _productsController;
        private readonly Product _product;

        #region Movement Props
        private int _move { get; set; }
        private int _moveX { get; set; }
        private int _moveY { get; set; }
        #endregion

        public EditProductFrm(Product product)
        {
            InitializeComponent();
            _product = product;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnAccept_Click(object sender, EventArgs e)
        {
            

        }

        private void InitializeInputValues()
        {
            codeInput.Text = _product.Code;
            nameInput.Text = _product.ProductName;
            descriptionInput.Text = _product.Details;
            priceInput.Value = (decimal)_product.Price;
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
        #endregion

        private void EditProductFrm_Load(object sender, EventArgs e)
        {
            InitializeInputValues();
        }
    }
}
