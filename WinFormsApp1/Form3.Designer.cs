namespace WinFormsApp1
{
    partial class Form3
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            button1 = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(21, 52);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.Size = new Size(441, 159);
            dataGridView1.TabIndex = 0;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 1;
            label1.Text = "Your Picks :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 275);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Total Book :";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(94, 273);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(57, 40);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(227, 273);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            textBox2.Text = "Total Amount :";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(346, 277);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 5;
            label3.Text = "RM";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(526, 52);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(214, 159);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Payment Method";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(26, 85);
            radioButton3.Margin = new Padding(4, 3, 4, 3);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(118, 19);
            radioButton3.TabIndex = 10;
            radioButton3.TabStop = true;
            radioButton3.Text = "Debit/Credit Card";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(133, 130);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Pay";
            button1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(26, 60);
            radioButton2.Margin = new Padding(4, 3, 4, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(69, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "E-Wallet";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(26, 35);
            radioButton1.Margin = new Padding(4, 3, 4, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cash";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(387, 217);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(632, 351);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveBorder;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(713, 351);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 13;
            button4.Text = "Done";
            button4.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 387);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form3";
            Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private GroupBox groupBox1;
        private Button button1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}