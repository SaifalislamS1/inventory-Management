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

namespace POSDemo1.screen.Users
{
   
    public partial class NewUsers : Form
    {
        readonly POSTutEntities db = new POSTutEntities();
        private string imagePath;

        public NewUsers()
        {
            InitializeComponent();
            MessageBox.Show(Environment.CurrentDirectory);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            User obj = new User
            {
                UserName = txtUser.Text,
                Password = txtPass.Text,
                Image = imagePath
            };
            db.Users.Add(obj);
            db.SaveChanges();
            MessageBox.Show("Hiiiii");
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog= new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            { 
            pictureBox1.ImageLocation = dialog.FileName;
            }
            imagePath = dialog.FileName;
            dialog.ShowDialog();
           
        }

        private void NewUsers_Load(object sender, EventArgs e)
        {

        }
    }
}
