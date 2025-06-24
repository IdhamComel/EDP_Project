using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private bool _termsBoxShown = false;
        public Form1()
        {
            InitializeComponent();
            // Manually wire up events if they're not connected in designer
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set password character to dot
            textBox3.PasswordChar = '•';

            // Add roles to combo box
            comboBox1.Items.Add("User");
            comboBox1.Items.Add("Admin");
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Login button functionality remains the same
            if (!checkBox1.Checked)
            {
                MessageBox.Show("You must agree to the Terms and Conditions to proceed.",
                    "Agreement Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string email = textBox2.Text.Trim();
            string password = textBox3.Text;
            string role = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (email.Contains("@") && password.Length >= 6)
            {
                MessageBox.Show("Login successful!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.",
                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fixed Sign Up link handler
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Check if SignUpForm is already open
            foreach (Form form in Application.OpenForms)
            {
                if (form is SignUpForm)
                {
                    form.BringToFront(); // Bring existing form to front
                    return; // Exit without creating a new one
                }
            }

            // Only create if no existing instance
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.FormClosed += (s, args) => this.Show(); // Show login form when closed
            this.Hide();
            signUpForm.Show();
        }

        // Forgot Password link handler
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact the administrator to reset your password.",
                "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Terms and Conditions link handler
        // Helper method to check for open Terms message box
        private bool IsMessageBoxOpen()
        {
            if (_termsBoxShown)
                return true;

            _termsBoxShown = true;
            return false;
        }

        // Updated Terms and Conditions handler
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Prevent multiple message boxes
            if (IsMessageBoxOpen())
                return;

            string terms = @"TERMS AND CONDITIONS

1. You must be a registered member to borrow books.
2. Books can be borrowed for one week at a time.
3. Late returns will incur a fine of RM 5 per day.
4. Maximum of 3 books can be borrowed at once.
5. Damaged or lost books must be replaced or paid for.

By checking the 'I agree' box, you accept these terms and conditions.";

            MessageBox.Show(terms, "Terms and Conditions",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset when the message box closes
            _termsBoxShown = false;
        }
    }
}



