using Infrastructure.Controllers;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class MainFrm : Form
    {
        private readonly ProductsController _productsController;

        #region Movement Props
        private int _move { get; set; }
        private int _moveX { get; set; }
        private int _moveY { get; set; }
        #endregion

        public MainFrm()
        {
            InitializeComponent();

            _productsController = new ProductsController();        

            productsGridView.DataSource = _productsController.Products;
        }

        #region Control Form Events
        private void btnClose_Click(object sender, EventArgs e) => Application.Exit();

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestore.Visible = true;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRestore.Visible = false;
            btnMaximize.Visible = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        #endregion

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var addProductFrm = new AddProductFrm(_productsController);
            addProductFrm.Show();
        }

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
