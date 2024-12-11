namespace ignitis1
{
    partial class vadybininkas
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
            dataGridView1 = new DataGridView();
            bendrijos_id = new DataGridViewTextBoxColumn();
            elektra = new DataGridViewTextBoxColumn();
            vando = new DataGridViewTextBoxColumn();
            mokesciai = new DataGridViewTextBoxColumn();
            pavadinimas = new DataGridViewTextBoxColumn();
            edit_btn = new Button();
            edit1 = new Panel();
            skaiciai = new TextBox();
            vissible_edit_button = new Button();
            vandens_kaina = new Button();
            panel1 = new Panel();
            skaiciai_vando = new TextBox();
            edit_btn2 = new Button();
            panel2 = new Panel();
            skaiciai3 = new TextBox();
            edit_btn3 = new Button();
            mokesciu_kaina = new Button();
            logout_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            edit1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { bendrijos_id, elektra, vando, mokesciai, pavadinimas });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(559, 263);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // bendrijos_id
            // 
            bendrijos_id.DataPropertyName = "bendrijos_id";
            bendrijos_id.FillWeight = 150F;
            bendrijos_id.HeaderText = "bendrijos_id";
            bendrijos_id.Name = "bendrijos_id";
            bendrijos_id.ReadOnly = true;
            bendrijos_id.Visible = false;
            bendrijos_id.Width = 150;
            // 
            // elektra
            // 
            elektra.DataPropertyName = "elektra";
            elektra.HeaderText = "Elektros kaina";
            elektra.Name = "elektra";
            elektra.ReadOnly = true;
            elektra.Width = 150;
            // 
            // vando
            // 
            vando.DataPropertyName = "vando";
            vando.HeaderText = "Vandens kaina";
            vando.Name = "vando";
            vando.ReadOnly = true;
            vando.Width = 150;
            // 
            // mokesciai
            // 
            mokesciai.DataPropertyName = "mokesciai";
            mokesciai.HeaderText = "Mokesciu kaina";
            mokesciai.Name = "mokesciai";
            mokesciai.ReadOnly = true;
            // 
            // pavadinimas
            // 
            pavadinimas.DataPropertyName = "pavadinimas";
            pavadinimas.HeaderText = "Bendrijos pavadinimas";
            pavadinimas.Name = "pavadinimas";
            pavadinimas.ReadOnly = true;
            // 
            // edit_btn
            // 
            edit_btn.Location = new Point(29, 47);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(137, 23);
            edit_btn.TabIndex = 1;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = true;
            edit_btn.Click += edit_btn_Click;
            // 
            // edit1
            // 
            edit1.Controls.Add(skaiciai);
            edit1.Controls.Add(edit_btn);
            edit1.Location = new Point(28, 281);
            edit1.Name = "edit1";
            edit1.Size = new Size(212, 100);
            edit1.TabIndex = 3;
            edit1.Visible = false;
            // 
            // skaiciai
            // 
            skaiciai.Location = new Point(29, 18);
            skaiciai.Name = "skaiciai";
            skaiciai.Size = new Size(137, 23);
            skaiciai.TabIndex = 5;
            // 
            // vissible_edit_button
            // 
            vissible_edit_button.Location = new Point(28, 405);
            vissible_edit_button.Name = "vissible_edit_button";
            vissible_edit_button.Size = new Size(212, 23);
            vissible_edit_button.TabIndex = 4;
            vissible_edit_button.Text = "Keisti elektros kaina";
            vissible_edit_button.UseVisualStyleBackColor = true;
            vissible_edit_button.Click += vissible_edit_button_Click;
            // 
            // vandens_kaina
            // 
            vandens_kaina.Location = new Point(265, 405);
            vandens_kaina.Name = "vandens_kaina";
            vandens_kaina.Size = new Size(212, 23);
            vandens_kaina.TabIndex = 5;
            vandens_kaina.Text = "Keisti vandens kaina";
            vandens_kaina.UseVisualStyleBackColor = true;
            vandens_kaina.Click += vandens_kaina_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(skaiciai_vando);
            panel1.Controls.Add(edit_btn2);
            panel1.Location = new Point(265, 281);
            panel1.Name = "panel1";
            panel1.Size = new Size(212, 100);
            panel1.TabIndex = 6;
            panel1.Visible = false;
            // 
            // skaiciai_vando
            // 
            skaiciai_vando.Location = new Point(29, 18);
            skaiciai_vando.Name = "skaiciai_vando";
            skaiciai_vando.Size = new Size(137, 23);
            skaiciai_vando.TabIndex = 5;
            // 
            // edit_btn2
            // 
            edit_btn2.Location = new Point(29, 47);
            edit_btn2.Name = "edit_btn2";
            edit_btn2.Size = new Size(137, 23);
            edit_btn2.TabIndex = 1;
            edit_btn2.Text = "Edit";
            edit_btn2.UseVisualStyleBackColor = true;
            edit_btn2.Click += edit_btn2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(skaiciai3);
            panel2.Controls.Add(edit_btn3);
            panel2.Location = new Point(503, 281);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 100);
            panel2.TabIndex = 8;
            panel2.Visible = false;
            // 
            // skaiciai3
            // 
            skaiciai3.Location = new Point(29, 18);
            skaiciai3.Name = "skaiciai3";
            skaiciai3.Size = new Size(137, 23);
            skaiciai3.TabIndex = 5;
            // 
            // edit_btn3
            // 
            edit_btn3.Location = new Point(29, 47);
            edit_btn3.Name = "edit_btn3";
            edit_btn3.Size = new Size(137, 23);
            edit_btn3.TabIndex = 1;
            edit_btn3.Text = "Edit";
            edit_btn3.UseVisualStyleBackColor = true;
            edit_btn3.Click += edit_btn3_Click;
            // 
            // mokesciu_kaina
            // 
            mokesciu_kaina.Location = new Point(503, 405);
            mokesciu_kaina.Name = "mokesciu_kaina";
            mokesciu_kaina.Size = new Size(212, 23);
            mokesciu_kaina.TabIndex = 7;
            mokesciu_kaina.Text = "Keisti mokesciu kaina";
            mokesciu_kaina.UseVisualStyleBackColor = true;
            mokesciu_kaina.Click += mokesciu_kaina_Click;
            // 
            // logout_btn
            // 
            logout_btn.Location = new Point(625, 12);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(163, 23);
            logout_btn.TabIndex = 19;
            logout_btn.Text = "Atsijungti";
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // vadybininkas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logout_btn);
            Controls.Add(panel2);
            Controls.Add(mokesciu_kaina);
            Controls.Add(panel1);
            Controls.Add(vandens_kaina);
            Controls.Add(vissible_edit_button);
            Controls.Add(edit1);
            Controls.Add(dataGridView1);
            Name = "vadybininkas";
            Text = "vadybininkas";
            Load += vadybininkas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            edit1.ResumeLayout(false);
            edit1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn bendrijos_id;
        private DataGridViewTextBoxColumn elektra;
        private DataGridViewTextBoxColumn vando;
        private DataGridViewTextBoxColumn mokesciai;
        private DataGridViewTextBoxColumn pavadinimas;
        private Button edit_btn;
        private TextBox editstatus_txt;
        private Panel edit1;
        private Button vissible_edit_button;
        private TextBox skaiciai;
        private Button vandens_kaina;
        private Panel panel1;
        private TextBox skaiciai_vando;
        private Button edit_btn2;
        private Panel panel2;
        private TextBox skaiciai3;
        private Button edit_btn3;
        private Button mokesciu_kaina;
        private Button logout_btn;
    }
}