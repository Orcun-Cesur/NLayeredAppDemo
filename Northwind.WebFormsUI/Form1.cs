using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete;
using Northwind.DataAccess.Concrete.EntitiyFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new NhProductDal());
        }
        private IProductService _productService;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dqwProduct.DataSource = _productService.GetAll();
        }
    }
}
