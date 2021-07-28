using Infrastructure.Controllers;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class MainFrm : Form
    {
        private readonly ProductsController _productsController;

        public MainFrm()
        {
            _productsController = new ProductsController();        
            InitializeComponent();

            productsGridView.DataSource = _productsController.Products;
        }

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
    }
}
