using POSDemo1.screen.Customer;
using POSDemo1.screen.Products;
using POSDemo1.screen.Users;
using System;
using System.Windows.Forms;

namespace POSDemo1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void AddUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
           NewUsers frm= new NewUsers();
            frm.Show();


        }

        private void AddProdcutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products P = new Products();
            P.Show();
           
        }

        private void EditProdcutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductList ProductList = new ProductList();    
            ProductList.Show();
        }

        private void قائمةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerMangament s=new CustomerMangament();
            s.Show();
            
        }

        private void قائمةالموردونToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void الموردونToolStripMenuItem1_Click(object sender, EventArgs e)
        { 
           
        }
    }
}
