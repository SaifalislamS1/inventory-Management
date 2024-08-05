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

namespace POSDemo1.screen.Customer
{
    public partial class CustomerMangament : Form
    {

        POSTutEntities db = new POSTutEntities();

        string imagePath = "";
        int id;
        POSDemo1.db.Customer result;
        public CustomerMangament()
        {


            InitializeComponent();
            checkBox1.Checked = false;
            dataGridView1.DataSource = db.Customers.ToList();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CustomerMangament_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtNamA.Text == "")
            {


                dataGridView1.DataSource = db.Customers.Where(x => x.Pone.Contains(txtPone.Text)).ToList();
            }
            else

                dataGridView1.DataSource = db.Customers.Where(x => x.Pone.Contains(txtPone.Text) || x.Name.Contains(txtNamA.Text)).ToList();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            db.Customers.ToList();
            dataGridView1.DataSource = db.Customers.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("اضافة عميل جديد", "هل انت متاكد من اضافة عميل جديد", MessageBoxButtons.YesNo);


            if (txtName.Text == "" || txtPhone.Text == "" || txtAdress.Text == "")

            {

                MessageBox.Show("الرجاء ادخال البيانات المطلوبة للعميل ");
            }
            else
            {

                POSDemo1.db.Customer C = new POSDemo1.db.Customer();

                C.Name = txtName.Text;

                C.Pone = txtPhone.Text;
                C.Notes = txtMle.Text;
                C.email = txtGmail.Text;
                C.address = txtAdress.Text;
                C.Company = txtSh.Text;
                C.isActive = checkBox1.Checked;

                db.Customers.Add(C);

                db.SaveChanges();
                MessageBox.Show("تم حفظ العميل بنجاح");
                if (imagePath != "")
                {
                    string r = Environment.CurrentDirectory + "\\screen\\Customers\\" + C.id + "jpg";


                    File.Copy(imagePath, r);


                    C.image = r;
                    db.SaveChanges();
                }
                txtName.Text = "";
                txtPhone.Text = "";
                txtMle.Text = "";
                txtGmail.Text = "";
                txtAdress.Text = "";
                txtGmail.Text = "";
                txtSh.Text = "";
                checkBox1.Checked = false;

                pictureBox1.ImageLocation = "";
                dataGridView1.DataSource = db.Customers.ToList();

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            result = db.Customers.SingleOrDefault(x => x.id == id);
            txtName.Text = result.Name;
            txtAdress.Text = result.address;
            txtGmail.Text = result.email;
            txtPhone.Text = result.Pone;
            txtMle.Text = result.Notes;
            txtSh.Text = result.Company;
            //checkBox1.Checked= (bool)result.isActive;
            pictureBox1.ImageLocation = result.image;




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNamA_TextChanged(object sender, EventArgs e)
        {

        }

        private void j_Click(object sender, EventArgs e)
        {

        }

        private void txtPone_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtGmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الحذف", "تاكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
                del();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSh_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
        void del()
        {
            var r = MessageBox.Show("?هل انت متاكد من الحذف ?", "تاكيد الحذف", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                var result = db.Customers.Find(id);
                _ = db.Customers.Remove(result);
                db.SaveChanges();
                MessageBox.Show("تم الحذف بنجاح");
                dataGridView1.DataSource = db.Customers.ToList();

            }
        }
    }
    }