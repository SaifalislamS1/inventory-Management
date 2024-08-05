using POSDemo1.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSDemo1
{
    public partial class Form1 : Form
    {
        POSTutEntities db = new POSTutEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            var result = db.Users.Where(y => y.UserName == textBox1.Text&& y.Password==textBox2.Text).ToList();
            MessageBox.Show(result.Count().ToString());

            if (result.Count() > 0)
            {
                this.Close();
                Thread th = new Thread(openForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else { MessageBox.Show("User name or password are invalide"); }
            void openForm()
            {
                Application.Run(new MainForm());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
