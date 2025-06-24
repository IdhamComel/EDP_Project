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
            groupBox1.Location = new Point(77, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 233);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sign Up ";
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.Silver;
            registerButton.Cursor = Cursors.Hand;
            registerButton.FlatStyle = FlatStyle.Popup;
            registerButton.Location = new Point(391, 188);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(75, 23);
            registerButton.TabIndex = 8;
            registerButton.Text = "Sign Up";
            registerButton.UseVisualStyleBackColor = false;
            // 
            // confirmPasswordSignUpTextBox
            // 
            confirmPasswordSignUpTextBox.Location = new Point(181, 143);
            confirmPasswordSignUpTextBox.Name = "confirmPasswordSignUpTextBox";
            confirmPasswordSignUpTextBox.Size = new Size(148, 23);
            confirmPasswordSignUpTextBox.TabIndex = 7;
            // 
            // passwordSignUpTextBox
            // 
            passwordSignUpTextBox.Location = new Point(134, 111);
            passwordSignUpTextBox.Name = "passwordSignUpTextBox";
            passwordSignUpTextBox.Size = new Size(142, 23);
            passwordSignUpTextBox.TabIndex = 6;
            // 
            // emailSignUpTextBox
            // 
            emailSignUpTextBox.Location = new Point(113, 78);
            emailSignUpTextBox.Name = "emailSignUpTextBox";
            emailSignUpTextBox.Size = new Size(236, 23);
            emailSignUpTextBox.TabIndex = 5;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(133, 46);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(236, 23);
            fullNameTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 146);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 3;
            label4.Text = "Confirm Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 114);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 81);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Email :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 49);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Fullname :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ScrollBar;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("STXingkai", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(210, 19);
            label5.Name = "label5";
            label5.Size = new Size(234, 39);
            label5.TabIndex = 1;
            label5.Text = "  Hi ! Welcome .";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.library;
            ClientSize = new Size(660, 329);
            Controls.Add(label5);
            Controls.Add(groupBox1);
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