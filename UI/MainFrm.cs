using Infrastructure.Controllers;
using Infrastructure.Serializer;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            productsGridView.DataSource = new List<Product>();
            _productsController = new ProductsController(productsGridView);
        }

        #region Control Form Events
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Xml<List<Product>>.SaveBinaryXml("sembrarteDB.bin", _productsController.Products);
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

        private void codeInputFilter_TextChanged(object sender, EventArgs e) => _productsController.FilterDataGridByCode(codeInputFilter);

        private void nameInputFilter_TextChanged(object sender, EventArgs e) => _productsController.FilterDataGridByProductName(nameInputFilter);

        private void detailsInputFilter_TextChanged(object sender, EventArgs e) => _productsController.FilterDataGridByDetails(detailsInputFilter);

        private void priceInputFilter_ValueChanged(object sender, EventArgs e) => _productsController.FilterDataGridByPrice(priceInputFilter);

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedProduct = _productsController.GetSelectedProduct();

            if(selectedProduct == null)
            {
                _productsController.ThrowErrorMessage("Error al obtener producto seleccionado");
                return;
            }

            var editFrm = new EditProductFrm(selectedProduct,_productsController);
            editFrm.Show();
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
            try
            {
                if (Xml<List<Product>>.ReadBinary("sembrarteDB.bin", out List<Product> _data))
                {
                    _productsController.Products = _data;
                    _productsController.UpdateGrid(_data);
                }
                    
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar sembrarteDB.bin");
            }
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
                Xml<List<Product>>.SaveBinaryXml("sembrarteDB.bin", _productsController.Products);
                MessageBox.Show("Se guardo todo re piola!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar los cambios.");
            }
        }
    }
}
