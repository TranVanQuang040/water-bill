namespace App_tiennuoc
{
    partial class Input1
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
            txbexit = new Button();
            listView1 = new ListView();
            STT = new ColumnHeader();
            Name = new ColumnHeader();
            Phone = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            Total = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            txbSTT = new TextBox();
            txbName = new TextBox();
            txbPhone = new TextBox();
            txbLast = new TextBox();
            txbThis = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txbcus = new ComboBox();
            label7 = new Label();
            button1 = new Button();
            Delete = new Button();
            button3 = new Button();
            label8 = new Label();
            txbFee = new TextBox();
            button2 = new Button();
            tbAmount = new TextBox();
            label9 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // txbexit
            // 
            txbexit.Location = new Point(1014, 139);
            txbexit.Name = "txbexit";
            txbexit.Size = new Size(94, 29);
            txbexit.TabIndex = 0;
            txbexit.Text = "Exit";
            txbexit.UseVisualStyleBackColor = true;
            txbexit.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { STT, Name, Phone, columnHeader1, columnHeader6, columnHeader3, Total, columnHeader2 });
            listView1.Location = new Point(-1, 210);
            listView1.Name = "listView1";
            listView1.Size = new Size(1121, 450);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // STT
            // 
            STT.Text = "STT";
            // 
            // Name
            // 
            Name.Text = "Name";
            Name.Width = 200;
            // 
            // Phone
            // 
            Phone.Text = "Phone";
            Phone.Width = 150;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Customer";
            columnHeader1.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Water last month";
            columnHeader6.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Water this month";
            columnHeader3.Width = 150;
            // 
            // Total
            // 
            Total.Text = "Total ";
            Total.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Water Fee";
            columnHeader2.Width = 100;
            // 
            // txbSTT
            // 
            txbSTT.Location = new Point(82, 21);
            txbSTT.Name = "txbSTT";
            txbSTT.Size = new Size(125, 27);
            txbSTT.TabIndex = 2;
            txbSTT.TextChanged += TxtSTT_TextChanged;
            // 
            // txbName
            // 
            txbName.Location = new Point(82, 75);
            txbName.Name = "txbName";
            txbName.Size = new Size(125, 27);
            txbName.TabIndex = 3;
            // 
            // txbPhone
            // 
            txbPhone.Location = new Point(345, 21);
            txbPhone.Name = "txbPhone";
            txbPhone.Size = new Size(125, 27);
            txbPhone.TabIndex = 4;
            // 
            // txbLast
            // 
            txbLast.Location = new Point(662, 21);
            txbLast.Name = "txbLast";
            txbLast.Size = new Size(125, 27);
            txbLast.TabIndex = 6;
            // 
            // txbThis
            // 
            txbThis.Location = new Point(662, 69);
            txbThis.Name = "txbThis";
            txbThis.Size = new Size(125, 27);
            txbThis.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 8;
            label1.Text = "STT";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 78);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 9;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(289, 24);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 10;
            label3.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(531, 24);
            label5.Name = "label5";
            label5.Size = new Size(125, 20);
            label5.TabIndex = 12;
            label5.Text = "Water Last Month";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(531, 78);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 13;
            label6.Text = "Water This Month";
            // 
            // txbcus
            // 
            txbcus.FormattingEnabled = true;
            txbcus.Items.AddRange(new object[] { "Household customer\t", "Services public", "Busniness services", "Production units" });
            txbcus.Location = new Point(345, 78);
            txbcus.Name = "txbcus";
            txbcus.Size = new Size(151, 28);
            txbcus.TabIndex = 14;
            txbcus.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(226, 81);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 15;
            label7.Text = "Customer Types";
            label7.Click += label7_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1014, 34);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 18;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Delete
            // 
            Delete.Location = new Point(1014, 104);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 19;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1014, 69);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 20;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(531, 123);
            label8.Name = "label8";
            label8.Size = new Size(119, 20);
            label8.TabIndex = 21;
            label8.Text = "Total This Month";
            // 
            // txbFee
            // 
            txbFee.Location = new Point(662, 159);
            txbFee.Name = "txbFee";
            txbFee.Size = new Size(125, 27);
            txbFee.TabIndex = 22;
            txbFee.TextChanged += txbFee_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(891, 73);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 23;
            button2.Text = "Calculate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tbAmount
            // 
            tbAmount.Location = new Point(662, 116);
            tbAmount.Name = "tbAmount";
            tbAmount.Size = new Size(125, 27);
            tbAmount.TabIndex = 24;
            tbAmount.TextChanged += tbAmount_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(556, 166);
            label9.Name = "label9";
            label9.Size = new Size(75, 20);
            label9.TabIndex = 25;
            label9.Text = "Water Fee";
            // 
            // Input1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 659);
            Controls.Add(label9);
            Controls.Add(tbAmount);
            Controls.Add(button2);
            Controls.Add(txbFee);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(Delete);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(txbcus);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbThis);
            Controls.Add(txbLast);
            Controls.Add(txbPhone);
            Controls.Add(txbName);
            Controls.Add(txbSTT);
            Controls.Add(listView1);
            Controls.Add(txbexit);
/*            Name = "Input1";
*/            Text = " ";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button txbexit;
        private ListView listView1;
        private ColumnHeader STT;
        private ColumnHeader Name;
        private ColumnHeader Phone;
        private TextBox txbSTT;
        private TextBox txbName;
        private TextBox txbPhone;
        private TextBox txbLast;
        private TextBox txbThis;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox txbcus;
        private Label label7;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader6;
        private Button button1;
        private Button Delete;
        private Button button3;
        private ColumnHeader columnHeader3;
        private Label label8;
        private TextBox txbFee;
        private Button button2;
        private TextBox tbAmount;
        private Label label9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ColumnHeader Total;
        private ColumnHeader columnHeader2;
    }
}