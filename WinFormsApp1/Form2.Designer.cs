namespace WinFormsApp1
{
    partial class Form2
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            Next = new Button();
            Previous = new Button();
            groupBox1 = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Add = new Button();
            Proceed = new Button();
            linkLabel1 = new LinkLabel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.comic;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(50, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 223);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 32);
            label1.Name = "label1";
            label1.Size = new Size(178, 17);
            label1.TabIndex = 1;
            label1.Text = "Choose Your Type of Book :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 328);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Comic";
            // 
            // Next
            // 
            Next.BackColor = SystemColors.ActiveCaption;
            Next.FlatStyle = FlatStyle.Popup;
            Next.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Next.Location = new Point(167, 324);
            Next.Name = "Next";
            Next.Size = new Size(75, 23);
            Next.TabIndex = 3;
            Next.Text = "Next >";
            Next.UseVisualStyleBackColor = false;
            Next.Click += button1_Click;
            // 
            // Previous
            // 
            Previous.BackColor = SystemColors.ActiveCaption;
            Previous.FlatStyle = FlatStyle.Popup;
            Previous.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Previous.Location = new Point(19, 324);
            Previous.Name = "Previous";
            Previous.Size = new Size(75, 23);
            Previous.TabIndex = 4;
            Previous.Text = "< Previous";
            Previous.UseVisualStyleBackColor = false;
            Previous.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(275, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(491, 234);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fill UpThe Book's Details ";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(121, 183);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(110, 146);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(33, 152);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 8;
            label7.Text = "Date Start :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(33, 189);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 7;
            label6.Text = "Date Return :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(77, 106);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 72);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 23);
            textBox1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 109);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 2;
            label5.Text = "ISBN :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 75);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 1;
            label4.Text = "Author/Publisher :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 40);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 0;
            label3.Text = "Tittle :";
            // 
            // Add
            // 
            Add.BackColor = SystemColors.ActiveBorder;
            Add.FlatStyle = FlatStyle.Popup;
            Add.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.Location = new Point(691, 272);
            Add.Name = "Add";
            Add.Size = new Size(75, 23);
            Add.TabIndex = 6;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += button3_Click;
            // 
            // Proceed
            // 
            Proceed.BackColor = SystemColors.Window;
            Proceed.FlatStyle = FlatStyle.Popup;
            Proceed.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Proceed.Location = new Point(713, 465);
            Proceed.Name = "Proceed";
            Proceed.Size = new Size(75, 23);
            Proceed.TabIndex = 6;
            Proceed.Text = "Proceed";
            Proceed.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(275, 269);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(71, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Price Details";
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(275, 339);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Size = new Size(397, 122);
            dataGridView1.TabIndex = 8;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(275, 311);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 9;
            label8.Text = "Your Pick :";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(linkLabel1);
            Controls.Add(Proceed);
            Controls.Add(groupBox1);
            Controls.Add(Add);
            Controls.Add(Previous);
            Controls.Add(Next);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Book Pick";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button Next;
        private Button Previous;
        private GroupBox groupBox1;
        private Button Add;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button Proceed;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label label6;
        private LinkLabel linkLabel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label8;
    }
}