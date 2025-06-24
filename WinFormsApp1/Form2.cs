using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private string[] bookTypes = { "Comic", "Novel", "Encyclopedia", "Magazine" };
        private int currentBookTypeIndex = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Set default dates
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today.AddDays(7);

            // Initialize book type display
            UpdateBookTypeDisplay();
        }

        private void UpdateBookTypeDisplay()
        {
            label2.Text = bookTypes[currentBookTypeIndex];
            // In real app, you would change the picture based on book type
            // pictureBox1.Image = Image.FromFile($"{bookTypes[currentBookTypeIndex]}.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Next button
            currentBookTypeIndex = (currentBookTypeIndex + 1) % bookTypes.Length;
            UpdateBookTypeDisplay();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Previous button
            currentBookTypeIndex = (currentBookTypeIndex - 1 + bookTypes.Length) % bookTypes.Length;
            UpdateBookTypeDisplay();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Add button
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a title.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add to DataGridView
            dataGridView1.Rows.Add(
                bookTypes[currentBookTypeIndex],
                textBox1.Text,
                textBox2.Text,
                textBox3.Text
            );

            // Clear fields
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            // Limit to 3 books
            if (dataGridView1.Rows.Count > 3)
            {
                MessageBox.Show("Maximum of 3 books allowed.",
                    "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Add.Enabled = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Price Details link
            string prices = @"BOOK TYPE PRICES:
- Comic: $5 per week
- Novel: $3 per week
- Encyclopedia: $7 per week
- Magazine: $2 per week

Late fee: $1 per day per book";
            MessageBox.Show(prices, "Price Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Proceed button
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one book to proceed.",
                    "No Books Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Your books have been reserved successfully!",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Automatically set return date 7 days after start date
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(7);
        }
    }
}