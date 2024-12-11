namespace ignitis1
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
            email_txt = new TextBox();
            login_button = new Button();
            password_txt = new TextBox();
            Email = new Label();
            Slaptazodis = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // email_txt
            // 
            email_txt.Location = new Point(330, 168);
            email_txt.Name = "email_txt";
            email_txt.Size = new Size(151, 23);
            email_txt.TabIndex = 0;
            // 
            // login_button
            // 
            login_button.Location = new Point(330, 226);
            login_button.Name = "login_button";
            login_button.Size = new Size(151, 23);
            login_button.TabIndex = 2;
            login_button.Text = "Prisijungti";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(330, 197);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(151, 23);
            password_txt.TabIndex = 3;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(288, 171);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 4;
            Email.Text = "Email";
            // 
            // Slaptazodis
            // 
            Slaptazodis.AutoSize = true;
            Slaptazodis.Location = new Point(258, 200);
            Slaptazodis.Name = "Slaptazodis";
            Slaptazodis.Size = new Size(66, 15);
            Slaptazodis.TabIndex = 5;
            Slaptazodis.Text = "Slaptazodis";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.ForeColor = Color.White;
            button1.Location = new Point(637, 12);
            button1.Name = "button1";
            button1.Size = new Size(151, 23);
            button1.TabIndex = 6;
            button1.Text = "Isjungti programa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Slaptazodis);
            Controls.Add(Email);
            Controls.Add(password_txt);
            Controls.Add(login_button);
            Controls.Add(email_txt);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox email_txt;
        private Button login_button;
        private TextBox password_txt;
        private Label Email;
        private Label Slaptazodis;
        private Button button1;
    }
}
