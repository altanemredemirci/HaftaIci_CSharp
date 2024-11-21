namespace _19_WinForm
{
    partial class Register
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
            groupBox1 = new GroupBox();
            txt_rpassword = new TextBox();
            cmb_district = new ComboBox();
            label13 = new Label();
            cmb_city = new ComboBox();
            label7 = new Label();
            rctxt_address = new RichTextBox();
            nmr_age = new NumericUpDown();
            dt_birthdate = new DateTimePicker();
            rd_man = new RadioButton();
            rd_woman = new RadioButton();
            msk_phone = new MaskedTextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txt_email = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txt_name = new TextBox();
            txt_surname = new TextBox();
            label6 = new Label();
            label3 = new Label();
            btn_visible = new Button();
            label1 = new Label();
            btn_login = new Button();
            txt_username = new TextBox();
            txt_password = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_age).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_rpassword);
            groupBox1.Controls.Add(cmb_district);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(cmb_city);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(rctxt_address);
            groupBox1.Controls.Add(nmr_age);
            groupBox1.Controls.Add(dt_birthdate);
            groupBox1.Controls.Add(rd_man);
            groupBox1.Controls.Add(rd_woman);
            groupBox1.Controls.Add(msk_phone);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Controls.Add(txt_surname);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btn_visible);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn_login);
            groupBox1.Controls.Add(txt_username);
            groupBox1.Controls.Add(txt_password);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(38, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(878, 463);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kayıt Paneli";
            // 
            // txt_rpassword
            // 
            txt_rpassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txt_rpassword.Location = new Point(122, 123);
            txt_rpassword.Name = "txt_rpassword";
            txt_rpassword.PasswordChar = '*';
            txt_rpassword.Size = new Size(282, 29);
            txt_rpassword.TabIndex = 38;
            // 
            // cmb_district
            // 
            cmb_district.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cmb_district.FormattingEnabled = true;
            cmb_district.Items.AddRange(new object[] { "İstanbul", "Ankara", "Ardahan", "Kars", "Siirt", "Hakkari", "Muş", "Adana", "Bayburt", "Çanakkale" });
            cmb_district.Location = new Point(559, 270);
            cmb_district.Name = "cmb_district";
            cmb_district.Size = new Size(281, 29);
            cmb_district.TabIndex = 37;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label13.Location = new Point(451, 270);
            label13.Name = "label13";
            label13.Size = new Size(40, 21);
            label13.TabIndex = 36;
            label13.Text = "İlçe:";
            // 
            // cmb_city
            // 
            cmb_city.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cmb_city.FormattingEnabled = true;
            cmb_city.Items.AddRange(new object[] { "İstanbul", "Ankara", "Ardahan", "Kars", "Siirt", "Hakkari", "Muş", "Adana", "Bayburt", "Çanakkale" });
            cmb_city.Location = new Point(559, 222);
            cmb_city.Name = "cmb_city";
            cmb_city.Size = new Size(281, 29);
            cmb_city.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(451, 220);
            label7.Name = "label7";
            label7.Size = new Size(52, 21);
            label7.TabIndex = 33;
            label7.Text = "Şehir:";
            // 
            // rctxt_address
            // 
            rctxt_address.Location = new Point(559, 320);
            rctxt_address.Name = "rctxt_address";
            rctxt_address.Size = new Size(280, 96);
            rctxt_address.TabIndex = 32;
            rctxt_address.Text = "";
            // 
            // nmr_age
            // 
            nmr_age.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            nmr_age.Location = new Point(558, 173);
            nmr_age.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            nmr_age.Name = "nmr_age";
            nmr_age.Size = new Size(282, 29);
            nmr_age.TabIndex = 31;
            nmr_age.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // dt_birthdate
            // 
            dt_birthdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dt_birthdate.Location = new Point(558, 120);
            dt_birthdate.MinDate = new DateTime(1989, 1, 1, 0, 0, 0, 0);
            dt_birthdate.Name = "dt_birthdate";
            dt_birthdate.Size = new Size(282, 29);
            dt_birthdate.TabIndex = 30;
            // 
            // rd_man
            // 
            rd_man.AutoSize = true;
            rd_man.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            rd_man.Location = new Point(678, 81);
            rd_man.Name = "rd_man";
            rd_man.Size = new Size(67, 25);
            rd_man.TabIndex = 29;
            rd_man.TabStop = true;
            rd_man.Text = "Erkek";
            rd_man.UseVisualStyleBackColor = true;
            // 
            // rd_woman
            // 
            rd_woman.AutoSize = true;
            rd_woman.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            rd_woman.Location = new Point(556, 81);
            rd_woman.Name = "rd_woman";
            rd_woman.Size = new Size(69, 25);
            rd_woman.TabIndex = 28;
            rd_woman.TabStop = true;
            rd_woman.Text = "Kadın";
            rd_woman.UseVisualStyleBackColor = true;
            // 
            // msk_phone
            // 
            msk_phone.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            msk_phone.Location = new Point(558, 33);
            msk_phone.Mask = "0000 000 00 00";
            msk_phone.Name = "msk_phone";
            msk_phone.Size = new Size(282, 29);
            msk_phone.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(451, 175);
            label8.Name = "label8";
            label8.Size = new Size(37, 21);
            label8.TabIndex = 21;
            label8.Text = "Yaş:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.Location = new Point(450, 318);
            label9.Name = "label9";
            label9.Size = new Size(57, 21);
            label9.TabIndex = 23;
            label9.Text = "Adres:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(451, 126);
            label10.Name = "label10";
            label10.Size = new Size(110, 21);
            label10.TabIndex = 19;
            label10.Text = "Doğum Tarihi:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.Location = new Point(451, 36);
            label11.Name = "label11";
            label11.Size = new Size(68, 21);
            label11.TabIndex = 15;
            label11.Text = "Telefon:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label12.Location = new Point(451, 81);
            label12.Name = "label12";
            label12.Size = new Size(71, 21);
            label12.TabIndex = 17;
            label12.Text = "Cinsiyet:";
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txt_email.Location = new Point(122, 267);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(282, 29);
            txt_email.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(13, 270);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 13;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(13, 175);
            label5.Name = "label5";
            label5.Size = new Size(35, 21);
            label5.TabIndex = 9;
            label5.Text = "Ad:";
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txt_name.Location = new Point(122, 172);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(282, 29);
            txt_name.TabIndex = 10;
            // 
            // txt_surname
            // 
            txt_surname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txt_surname.Location = new Point(122, 220);
            txt_surname.Name = "txt_surname";
            txt_surname.Size = new Size(282, 29);
            txt_surname.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(13, 220);
            label6.Name = "label6";
            label6.Size = new Size(59, 21);
            label6.TabIndex = 11;
            label6.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(13, 126);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 7;
            label3.Text = "Tekrar Şifre:";
            // 
            // btn_visible
            // 
            btn_visible.BackColor = SystemColors.ActiveCaption;
            btn_visible.ForeColor = SystemColors.ButtonHighlight;
            btn_visible.Location = new Point(345, 322);
            btn_visible.Name = "btn_visible";
            btn_visible.Size = new Size(59, 37);
            btn_visible.TabIndex = 6;
            btn_visible.Text = "Göster";
            btn_visible.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(13, 36);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.ActiveCaption;
            btn_login.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_login.ForeColor = SystemColors.ButtonHighlight;
            btn_login.Location = new Point(122, 320);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(206, 37);
            btn_login.TabIndex = 4;
            btn_login.Text = "KAYDET";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txt_username.Location = new Point(122, 33);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(282, 29);
            txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txt_password.Location = new Point(122, 78);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(282, 29);
            txt_password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(13, 81);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 2;
            label2.Text = "Şifre:";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 519);
            Controls.Add(groupBox1);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmr_age).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_email;
        private Label label4;
        private Label label5;
        private TextBox txt_name;
        private TextBox txt_surname;
        private Label label6;
        private TextBox textBox1;
        private Label label3;
        private Button btn_visible;
        private Label label1;
        private Button btn_login;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label label2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private MaskedTextBox msk_phone;
        private RadioButton rd_man;
        private RadioButton rd_woman;
        private DateTimePicker dt_birthdate;
        private NumericUpDown nmr_age;
        private RichTextBox rctxt_address;
        private Label label7;
        private ComboBox comboBox1;
        private ComboBox cmb_city;
        private ComboBox cmb_district;
        private Label label13;
        private TextBox txt_rpassword;
    }
}