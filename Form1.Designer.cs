namespace App_tiennuoc
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
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            tbxpass = new TextBox();
            txbEmail = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(499, 297);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(331, 297);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 195);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 127);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 8;
            label1.Text = "Email";
            // 
            // tbxpass
            // 
            tbxpass.Location = new Point(331, 188);
            tbxpass.Name = "tbxpass";
            tbxpass.Size = new Size(262, 27);
            tbxpass.TabIndex = 7;
            tbxpass.TextChanged += tbxpass_TextChanged;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(331, 124);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(262, 27);
            txbEmail.TabIndex = 6;
            txbEmail.TextChanged += txbEmail_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbxpass);
            Controls.Add(txbEmail);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox tbxpass;
        private TextBox txbEmail;
    }
}
