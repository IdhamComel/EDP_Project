using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class QR : Form
    {
        private Form3 previousPage;
        public QR(Form3 form3)
        {
            InitializeComponent();
            previousPage =form3;
   
        }

        private void QR_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            previousPage.Show();
            this.Close();
        }
    }
}
