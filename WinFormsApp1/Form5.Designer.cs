namespace WinFormsApp1
{
    partial class Form5
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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            button2 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            groupBox2 = new GroupBox();
            radioButton3 = new RadioButton();
            button1 = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(404, 233);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Select";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 13;
            label1.Text = "Your Picks :";
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(38, 68);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.Size = new Size(441, 159);
            dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            Column1.HeaderText = "Book Type";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tittle";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Author";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "ISBN";
            Column4.Name = "Column4";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(38, 303);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 179);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Extension Details";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(137, 115);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(49, 42);
            textBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(39, 115);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 7;
            label4.Text = "Total Book :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(351, 137);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 6;
            label3.Text = "RM";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(245, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            textBox2.Text = "Total Amount :";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(192, 67);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "weeks";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 50);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(49, 42);
            textBox1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(39, 50);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 0;
            label5.Text = "Total Extension :";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(38, 230);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(92, 15);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Extension Policy";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(559, 303);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 157);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Payment Method";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(23, 88);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(118, 19);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "Debit/Credit Card";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(119, 128);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Pay";
            button1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(23, 63);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(69, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "E-Wallet";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(23, 38);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cash";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(599, 162);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(588, 125);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(511, 131);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 19;
            label7.Text = "Date Start :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(511, 168);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 18;
            label6.Text = "Date Return :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(511, 83);
            label8.Name = "label8";
            label8.Size = new Size(119, 17);
            label8.TabIndex = 22;
            label8.Text = "Date of Extension ";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 529);
            Controls.Add(label8);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(linkLabel1);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form5";
            Text = "Extension";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label5;
        private LinkLabel linkLabel1;
        private GroupBox groupBox2;
        private RadioButton radioButton3;
        private Button button1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label label6;
        private Label label8;
    }
}