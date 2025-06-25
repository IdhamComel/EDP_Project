namespace WinFormsApp1
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            registerButton = new Button();
            confirmPasswordSignUpTextBox = new TextBox();
            passwordSignUpTextBox = new TextBox();
            emailSignUpTextBox = new TextBox();
            fullNameTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(registerButton);
            groupBox1.Controls.Add(confirmPasswordSignUpTextBox);
            groupBox1.Controls.Add(passwordSignUpTextBox);
            groupBox1.Controls.Add(emailSignUpTextBox);
            groupBox1.Controls.Add(fullNameTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(88, 95);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(559, 311);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sign Up ";
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.Silver;
            registerButton.Cursor = Cursors.Hand;
            registerButton.FlatStyle = FlatStyle.Popup;
            registerButton.Location = new Point(447, 251);
            registerButton.Margin = new Padding(3, 4, 3, 4);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(86, 31);
            registerButton.TabIndex = 8;
            registerButton.Text = "Sign Up";
            registerButton.UseVisualStyleBackColor = false;
           
            // 
            // confirmPasswordSignUpTextBox
            // 
            confirmPasswordSignUpTextBox.Location = new Point(207, 191);
            confirmPasswordSignUpTextBox.Margin = new Padding(3, 4, 3, 4);
            confirmPasswordSignUpTextBox.Name = "confirmPasswordSignUpTextBox";
            confirmPasswordSignUpTextBox.Size = new Size(169, 27);
            confirmPasswordSignUpTextBox.TabIndex = 7;
            // 
            // passwordSignUpTextBox
            // 
            passwordSignUpTextBox.Location = new Point(153, 148);
            passwordSignUpTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordSignUpTextBox.Name = "passwordSignUpTextBox";
            passwordSignUpTextBox.Size = new Size(162, 27);
            passwordSignUpTextBox.TabIndex = 6;
            // 
            // emailSignUpTextBox
            // 
            emailSignUpTextBox.Location = new Point(129, 104);
            emailSignUpTextBox.Margin = new Padding(3, 4, 3, 4);
            emailSignUpTextBox.Name = "emailSignUpTextBox";
            emailSignUpTextBox.Size = new Size(269, 27);
            emailSignUpTextBox.TabIndex = 5;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(152, 61);
            fullNameTextBox.Margin = new Padding(3, 4, 3, 4);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(269, 27);
            fullNameTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 195);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 3;
            label4.Text = "Confirm Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 152);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 108);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Email :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 65);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Fullname :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ScrollBar;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Microsoft Sans Serif", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(240, 25);
            label5.Name = "label5";
            label5.Size = new Size(364, 54);
            label5.TabIndex = 1;
            label5.Text = "  Hi ! Welcome .";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.library;
            ClientSize = new Size(754, 439);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignUpForm";
            Text = "SignUpForm";
            Load += SignUpForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button registerButton;
        private TextBox confirmPasswordSignUpTextBox;
        private TextBox passwordSignUpTextBox;
        private TextBox emailSignUpTextBox;
        private TextBox fullNameTextBox;
        private Label label1;
        private Label label5;
    }
}