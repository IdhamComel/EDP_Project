using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        private Form2 previosForm;
        public Form3(Form2 form2)
        {
            InitializeComponent();
            previosForm = form2;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // Add Delete button column if it doesn't exist
            if (!dataGridView2.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
                deleteBtn.HeaderText = "Action";
                deleteBtn.Text = "Delete";
                deleteBtn.UseColumnTextForButtonValue = true;
                deleteBtn.Name = "Delete";
                dataGridView2.Columns.Add(deleteBtn);
            }
            LoadData();
            LoadTotalBooks();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            previosForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                QR qrForm = new QR(this);
                qrForm.Show();  // Show QR payment form
                this.Hide();
            }
            else if (radioButton3.Checked)
            {
                DebitCreditCardDeatails cardForm = new DebitCreditCardDeatails(this);
                cardForm.Show(); // Show Card payment form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a payment method.", "Payment Method Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                // Confirm before delete
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Get ID from selected row
                    int bookBorrowCode = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["bookBorrowCode"].Value);

                    // Delete from database
                    DeleteFromDatabase(bookBorrowCode);

                    // Refresh DataGridView
                    LoadData();
                    LoadTotalBooks();
                }
            }
        }
        private void DeleteFromDatabase(int bookBorrowCode)
        {
            string connectionString = "your_connection_string_here";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM book_borrowed WHERE bookBorrowCode = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", bookBorrowCode);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void LoadData()
        {
            string connectionString = "your_connection_string_here";
            string query = "SELECT * FROM book_borrowed";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView2.DataSource = table;
            }
        }
        private void LoadTotalBooks()
        {
            string connectionString = "your_connection_string_here";
            string query = "SELECT COUNT(*) FROM book_borrowed";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int totalBooks = (int)cmd.ExecuteScalar(); // Get count value
                conn.Close();

                // Assuming labelTotalBooks is your label in the form
                labelTotalBooks.Text = totalBooks.ToString();
            }
        }
    }
}
