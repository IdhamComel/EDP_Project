using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class DebitCreditCardDeatails : Form
    {
        private Form3 previousPage;
        public DebitCreditCardDeatails(Form3 form3)
        {
            InitializeComponent();
            previousPage = form3;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            previousPage.Show();
            this.Close();
        }
    }
}
