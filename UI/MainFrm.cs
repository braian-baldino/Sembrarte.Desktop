using Infrastructure.Controllers;
using Models.Entities;
using SembrarteApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class MainFrm : Form
    {
        private readonly ProductsController _productsController;
        private FiltersController _filtersController;

        #region Movement Props
        private int _move { get; set; }
        private int _moveX { get; set; }
        private int _moveY { get; set; }
        #endregion

        public MainFrm()
        {
            InitializeComponent();
            productsGridView.DataSource = new List<Product>();
            _productsController = new ProductsController(productsGridView);
        }

        #region Control Form Events
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                _productsController.SaveData();
                Application.Exit();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar los cambios.");
            }
        }

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

        private void codeInputFilter_TextChanged(object sender, EventArgs e) => _filtersController.FilterDataGrid();

        private void nameInputFilter_TextChanged(object sender, EventArgs e) => _filtersController.FilterDataGrid();

        private void detailsInputFilter_TextChanged(object sender, EventArgs e) => _filtersController.FilterDataGrid();

        private void priceInputFilter_ValueChanged(object sender, EventArgs e) => _filtersController.FilterDataGrid();

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedProduct = _productsController.GetSelectedProduct();

            if (selectedProduct != null)
            {
                var editFrm = new EditProductFrm(selectedProduct, _productsController);
                editFrm.Show();         
            }
            else
                _productsController.ThrowErrorMessage("Error al obtener producto seleccionado");
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productName = (string)productsGridView?.SelectedRows[0].Cells[1].Value;
            var response = MessageBox.Show($"Posta queres borrar el producto \"{productName}\"?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (response == DialogResult.Yes)
                _productsController.DeleteProduct();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;

            _productsController.LoadData();
            _filtersController = new FiltersController(productsGridView, _productsController.Products,
                nameInputFilter, 
                codeInputFilter, 
                detailsInputFilter, 
                priceInputFilter);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var addProductFrm = new AddProductFrm(_productsController);
            addProductFrm.Show();
        }

        private void saveBtn_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                _productsController.SaveData();
                if(_productsController.Products.Any())
                 MessageBox.Show("Se guardo todo re piola!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar los cambios.");
            }
        }

        private void productsGridView_ColumnHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e) => _productsController.SortColumn(e.ColumnIndex);

        private void duplicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = _productsController.GetSelectedProduct();

            if (selectedItem != null)
            {
                var addProductFrm = new AddProductFrm(_productsController);
                addProductFrm.SetInputs(selectedItem);
                addProductFrm.Show();
            }
            else
                _productsController.ThrowErrorMessage("Error al obtener producto seleccionado");

            
        }

        private void calculateBuyPriceBtn_Click(object sender, EventArgs e)
        {
            var calculateBuyPriceForm = new CalculateBuyPriceForm(_productsController);
            calculateBuyPriceForm.Show();
        }
    }
}
