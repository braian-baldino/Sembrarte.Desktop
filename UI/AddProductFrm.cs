using Infrastructure.Controllers;
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
    public partial class AddProductFrm : Form
    {
        private readonly ProductsController _productsController;

        public AddProductFrm(ProductsController productsController)
        {
            InitializeComponent();
            _productsController = productsController;
        }
    }
}
