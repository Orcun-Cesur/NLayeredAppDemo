using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntitiyFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.FormsScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IProductDal productDal1 = new IProductDal;
            IProductDal productDal = productDal1;
            dgwProducts.DataSource = productDal1.GetAll();
            //dgwProducts.DataSource = _productDal.GetAll().Where(p=>p.Name.Contains(key)).ToList();
        }
    }
}
