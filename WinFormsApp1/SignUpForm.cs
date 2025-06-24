using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            // Wire up register button if not done in designer
            registerButton.Click += registerButton_Click;
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            // Set password characters
            passwordSignUpTextBox.PasswordChar = '•';
            confirmPasswordSignUpTextBox.PasswordChar = '•';
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(fullNameTextBox.Text))
            {
                MessageBox.Show("Please enter your full name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string email = emailSignUpTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prevent users from registering with admin emails
            if (email.EndsWith("@admin.shareshelf.my"))
            {
                MessageBox.Show("Admin email domains are restricted.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (passwordSignUpTextBox.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (passwordSignUpTextBox.Text != confirmPasswordSignUpTextBox.Text)
            {
                MessageBox.Show("Passwords do not match.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Registration successful! You can now log in.",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Return to login form when closing
            foreach (Form form in Application.OpenForms)
            {
                if (form is Form1)
                {
                    form.Show();
                    break;
                }
            }
        }
    }
}