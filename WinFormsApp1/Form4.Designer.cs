namespace WinFormsApp1
{
    partial class Form4
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radioButton3 = new RadioButton();
            button1 = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            linkLabel1 = new LinkLabel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(35, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 179);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Overdue Penalty !";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(132, 115);
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
            label3.Location = new Point(321, 137);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 6;
            label3.Text = "RM";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(215, 134);
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
            label2.Location = new Point(187, 67);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "days";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 50);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(49, 42);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(39, 50);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Total Overdue :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(500, 34);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 157);
            groupBox2.TabIndex = 1;
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
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(35, 216);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(87, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Overdue Policy";
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(34, 289);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Size = new Size(407, 107);
            dataGridView1.TabIndex = 3;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(34, 262);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 9;
            label5.Text = "Overdue Book :";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 408);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(linkLabel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form4";
            Text = "Overdue Penalty";
            Load += Form4_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private GroupBox groupBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private LinkLabel linkLabel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label5;
        private RadioButton radioButton3;
    }
}