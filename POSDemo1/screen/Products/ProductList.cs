using POSDemo1.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSDemo1.screen.Products
{
    public partial class ProductList : Form
    {
        POSTutEntities db = new POSTutEntities();
        POSDemo1.db.Product result;

        int id;
        
        string imagePath = "";

        
       

        public ProductList()
        {
            InitializeComponent();
            db.Products.ToList();
            dataGridView1.DataSource = db.Products.ToList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            
          
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());


                var result = db.Products.SingleOrDefault(x => x.id == id);


                txtBarcod.Text = result.Code;

                txtName.Text = result.Name;
                txtNotes.Text = result.Notes;
                txtPrice.Text = result.Price.ToString();
                txtQty.Text = result.Quantity.ToString();
                pictureBox1.ImageLocation = result.Image;
            



        }

        private void j_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = db.Products.Where(x => x.Code.Contains(textBox1.Text)).ToList();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            if (txtName.Text == "")
            {


                dataGridView1.DataSource = db.Products.Where(x => x.Code == txtBarcod.Text).ToList();
            }
            else

                dataGridView1.DataSource = db.Products.Where(x => x.Code == txtBarcod.Text || x.Name.Contains(txtName.Text)).ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.Products.ToList();
            dataGridView1.DataSource = db.Products.ToList();
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
             result = db.Products.SingleOrDefault(x => x.id == id);

            result.Name = txtName.Text;
            result.Code = txtBarcod.Text;
            result.Price = decimal.Parse(txtPrice.Text);
            result.Quantity = int.Parse(txtQty.Text);
            result.Notes = txtNotes.Text;

          /*  if (imagePath != "")
            {
                string newPath= Environment.CurrentDirectory + " C: \\Users\\saif\\Downloads" + result.id + ".jpg";
                File.Copy(imagePath,newPath,true);
                result.Image = newPath;



            }*/
              db.SaveChanges();
            MessageBox.Show("تم التعديل بنجاح");
            dataGridView1.DataSource = db.Products.ToList();
        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e) {
            try
            {
                id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                result = db.Products.SingleOrDefault(X => X.id == id);
                txtBarcod.Text = result.Code;
                txtName.Text = result.Name;
                txtPrice.Text = result.Price.ToString();
                txtQty.Text = result.Quantity.ToString();
                txtNotes.Text = result.Notes;
                pictureBox1.ImageLocation = result.Image;
            }
            catch { }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
         var r=  MessageBox.Show("?هل انت متاكد من الحذف ?", "تاكيد الحذف", MessageBoxButtons.YesNo);
            if (r== DialogResult.Yes)
            {
                var result = db.Products.Find(id);
                _ = db.Products.Remove(result);
                db.SaveChanges();
                MessageBox.Show("تم الحذف بنجاح");
                dataGridView1.DataSource = db.Products.ToList();          

            }
          

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Products f = new Products();
            f.Show();
        }
    }
}

