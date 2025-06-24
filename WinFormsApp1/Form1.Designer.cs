namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            linkLabel2 = new LinkLabel();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            linkLabel3 = new LinkLabel();
            checkBox1 = new CheckBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.library;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(35, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 219);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(217, 160);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(99, 15);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forgot password";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(365, 180);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(113, 124);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '•';
            textBox3.Size = new Size(203, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(113, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 23);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 127);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 44);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(434, 324);
            label3.Name = "label3";
            label3.Size = new Size(134, 15);
            label3.TabIndex = 3;
            label3.Text = "Don't have an account ?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(574, 324);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(47, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(34, 319);
            label4.Name = "label4";
            label4.Size = new Size(227, 23);
            label4.TabIndex = 5;
            label4.Text = "\" Your Imagination Starts Here \"";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(402, 275);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(123, 15);
            linkLabel3.TabIndex = 9;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Terms and Conditions";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(305, 275);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(95, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "I agree to the";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(305, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(461, 219);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "ShareShelf Library";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(84, 85);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 7;
            label5.Text = "as";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(113, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(102, 23);
            comboBox1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.InactiveCaption;
            label6.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 35);
            label6.Name = "label6";
            label6.Size = new Size(226, 38);
            label6.TabIndex = 11;
            label6.Text = "SHARESHELF";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 373);
            Controls.Add(label6);
            Controls.Add(checkBox1);
            Controls.Add(linkLabel3);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Log In";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Label label4;
        private LinkLabel linkLabel3;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
    }
}
