using POSDemo1.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSDemo1.screen.Products
{
    public partial class Products : Form
    {
        POSTutEntities db = new POSTutEntities();
        string imagepath;

        public object P { get; private set; }

        public Products()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtParcod.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("يرجاء اكمال البيانات المطلوبة اولا");
            }
            else
            {
                POSDemo1.db.Product product = new POSDemo1.db.Product();
                product.Name = txtName.Text;
                product.Code = txtParcod.Text;
                product.Price = decimal.Parse(txtPrice.Text);
                product.Notes = txtNotes.Text;
                product.Quantity=int.Parse(txtQty.Text);   
                
                db.Products.Add(product);
                db.SaveChanges();
                MessageBox.Show("تم حفظ المنتج بنجاح");
                // string newPath = Environment.CurrentDirectory + "\\images\\products\\" + pictureBox1.id + ".jpg";

                txtParcod.Text = "";
                txtName.Text = "";
                txtQty.Text = "";
                txtNotes.Text = "";
                txtPrice.Text = "";
                pictureBox1.ImageLocation = "";
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if(o.ShowDialog() == DialogResult.OK)
            {
                imagepath =o.FileName;
                pictureBox1.ImageLocation=o.FileName;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductList l = new ProductList();
            l.Show();
        }
    }
}
