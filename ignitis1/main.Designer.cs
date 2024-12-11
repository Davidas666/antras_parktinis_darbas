namespace ignitis1
{
    partial class main
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
            vardastxt = new Label();
            pavardetxt = new Label();
            email = new Label();
            username = new Label();
            change_password_button = new Button();
            password_change_panel = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            chane_password_button = new Button();
            confirm_password_textbox = new TextBox();
            new_password_textbox = new TextBox();
            old_password_textbox = new TextBox();
            Kainu_panel = new Panel();
            Pavadinimas_txt = new Label();
            mokesciai_txt = new Label();
            vando_txt = new Label();
            elektra_txt = new Label();
            show_price = new Button();
            logout_btn = new Button();
            password_change_panel.SuspendLayout();
            Kainu_panel.SuspendLayout();
            SuspendLayout();
            // 
            // vardastxt
            // 
            vardastxt.AutoSize = true;
            vardastxt.Location = new Point(73, 29);
            vardastxt.Name = "vardastxt";
            vardastxt.Size = new Size(55, 15);
            vardastxt.TabIndex = 0;
            vardastxt.Text = "vardastxt";
            // 
            // pavardetxt
            // 
            pavardetxt.AutoSize = true;
            pavardetxt.Location = new Point(134, 29);
            pavardetxt.Name = "pavardetxt";
            pavardetxt.Size = new Size(63, 15);
            pavardetxt.TabIndex = 1;
            pavardetxt.Text = "pavardetxt";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(220, 29);
            email.Name = "email";
            email.Size = new Size(36, 15);
            email.TabIndex = 2;
            email.Text = "email";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(317, 29);
            username.Name = "username";
            username.Size = new Size(59, 15);
            username.TabIndex = 3;
            username.Text = "username";
            // 
            // change_password_button
            // 
            change_password_button.Location = new Point(557, 352);
            change_password_button.Name = "change_password_button";
            change_password_button.Size = new Size(228, 23);
            change_password_button.TabIndex = 4;
            change_password_button.Text = "Pakeisti slaptazodi";
            change_password_button.UseVisualStyleBackColor = true;
            change_password_button.Click += change_password_button_Click_1;
            // 
            // password_change_panel
            // 
            password_change_panel.Controls.Add(label3);
            password_change_panel.Controls.Add(label2);
            password_change_panel.Controls.Add(label1);
            password_change_panel.Controls.Add(chane_password_button);
            password_change_panel.Controls.Add(confirm_password_textbox);
            password_change_panel.Controls.Add(new_password_textbox);
            password_change_panel.Controls.Add(old_password_textbox);
            password_change_panel.Location = new Point(541, 69);
            password_change_panel.Name = "password_change_panel";
            password_change_panel.Size = new Size(247, 220);
            password_change_panel.TabIndex = 5;
            password_change_panel.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 109);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 9;
            label3.Text = "Pakartokite slaptazodi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 67);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 8;
            label2.Text = "Naujas slaptazodis";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 26);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 7;
            label1.Text = "Senas slaptazodis";
            // 
            // chane_password_button
            // 
            chane_password_button.Location = new Point(130, 157);
            chane_password_button.Name = "chane_password_button";
            chane_password_button.Size = new Size(114, 23);
            chane_password_button.TabIndex = 6;
            chane_password_button.Text = "Pakeisti slaptazodi";
            chane_password_button.UseVisualStyleBackColor = true;
            chane_password_button.Click += chane_password_button_Click_1;
            // 
            // confirm_password_textbox
            // 
            confirm_password_textbox.Location = new Point(130, 106);
            confirm_password_textbox.Name = "confirm_password_textbox";
            confirm_password_textbox.Size = new Size(114, 23);
            confirm_password_textbox.TabIndex = 2;
            // 
            // new_password_textbox
            // 
            new_password_textbox.Location = new Point(130, 64);
            new_password_textbox.Name = "new_password_textbox";
            new_password_textbox.Size = new Size(114, 23);
            new_password_textbox.TabIndex = 1;
            // 
            // old_password_textbox
            // 
            old_password_textbox.Location = new Point(130, 23);
            old_password_textbox.Name = "old_password_textbox";
            old_password_textbox.PasswordChar = '*';
            old_password_textbox.Size = new Size(114, 23);
            old_password_textbox.TabIndex = 0;
            // 
            // Kainu_panel
            // 
            Kainu_panel.Controls.Add(Pavadinimas_txt);
            Kainu_panel.Controls.Add(mokesciai_txt);
            Kainu_panel.Controls.Add(vando_txt);
            Kainu_panel.Controls.Add(elektra_txt);
            Kainu_panel.Location = new Point(58, 69);
            Kainu_panel.Name = "Kainu_panel";
            Kainu_panel.Size = new Size(228, 220);
            Kainu_panel.TabIndex = 7;
            Kainu_panel.Visible = false;
            // 
            // Pavadinimas_txt
            // 
            Pavadinimas_txt.AutoSize = true;
            Pavadinimas_txt.Location = new Point(32, 24);
            Pavadinimas_txt.Name = "Pavadinimas_txt";
            Pavadinimas_txt.Size = new Size(37, 15);
            Pavadinimas_txt.TabIndex = 4;
            Pavadinimas_txt.Text = "Sveiki";
            // 
            // mokesciai_txt
            // 
            mokesciai_txt.AutoSize = true;
            mokesciai_txt.Location = new Point(32, 139);
            mokesciai_txt.Name = "mokesciai_txt";
            mokesciai_txt.Size = new Size(38, 15);
            mokesciai_txt.TabIndex = 3;
            mokesciai_txt.Text = "label1";
            // 
            // vando_txt
            // 
            vando_txt.AutoSize = true;
            vando_txt.Location = new Point(32, 97);
            vando_txt.Name = "vando_txt";
            vando_txt.Size = new Size(38, 15);
            vando_txt.TabIndex = 2;
            vando_txt.Text = "label1";
            // 
            // elektra_txt
            // 
            elektra_txt.AutoSize = true;
            elektra_txt.Location = new Point(32, 58);
            elektra_txt.Name = "elektra_txt";
            elektra_txt.Size = new Size(38, 15);
            elektra_txt.TabIndex = 1;
            elektra_txt.Text = "label1";
            // 
            // show_price
            // 
            show_price.Location = new Point(58, 352);
            show_price.Name = "show_price";
            show_price.Size = new Size(228, 23);
            show_price.TabIndex = 6;
            show_price.Text = "Paziureti duomenys";
            show_price.UseVisualStyleBackColor = true;
            show_price.Click += show_price_Click;
            // 
            // logout_btn
            // 
            logout_btn.Location = new Point(628, 12);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(163, 23);
            logout_btn.TabIndex = 20;
            logout_btn.Text = "Atsijungti";
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 450);
            Controls.Add(logout_btn);
            Controls.Add(Kainu_panel);
            Controls.Add(show_price);
            Controls.Add(password_change_panel);
            Controls.Add(change_password_button);
            Controls.Add(username);
            Controls.Add(email);
            Controls.Add(pavardetxt);
            Controls.Add(vardastxt);
            Name = "main";
            Text = "main";
            password_change_panel.ResumeLayout(false);
            password_change_panel.PerformLayout();
            Kainu_panel.ResumeLayout(false);
            Kainu_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label vardastxt;
        private Label pavardetxt;
        private Label email;
        private Label username;
        private Button change_password_button;
        private Panel password_change_panel;
        private Button chane_password_button;
        private TextBox confirm_password_textbox;
        private TextBox new_password_textbox;
        private TextBox old_password_textbox;
        private Panel Kainu_panel;
        private Label mokesciai_txt;
        private Label vando_txt;
        private Label elektra_txt;
        private Button show_price;
        private Label Pavadinimas_txt;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button logout_btn;
    }
}