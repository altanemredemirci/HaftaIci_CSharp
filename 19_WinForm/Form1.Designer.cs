namespace _19_WinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            label2 = new Label();
            btn_login = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            btn_visible = new Button();
            lnk_register = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            txt_password.Location = new Point(122, 85);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(282, 29);
            txt_password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(13, 88);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 2;
            label2.Text = "Şifre:";
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.ActiveCaption;
            btn_login.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_login.ForeColor = SystemColors.ButtonHighlight;
            btn_login.Location = new Point(122, 134);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(217, 37);
            btn_login.TabIndex = 4;
            btn_login.Text = "GİRİŞ YAP";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(420, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lnk_register);
            groupBox1.Controls.Add(btn_visible);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn_login);
            groupBox1.Controls.Add(txt_username);
            groupBox1.Controls.Add(txt_password);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(55, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(578, 197);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giriş Paneli";
            // 
            // btn_visible
            // 
            btn_visible.BackColor = SystemColors.ActiveCaption;
            btn_visible.ForeColor = SystemColors.ButtonHighlight;
            btn_visible.Location = new Point(345, 134);
            btn_visible.Name = "btn_visible";
            btn_visible.Size = new Size(59, 37);
            btn_visible.TabIndex = 6;
            btn_visible.Text = "Göster";
            btn_visible.UseVisualStyleBackColor = false;
            btn_visible.MouseLeave += btn_visible_MouseLeave;
            btn_visible.MouseHover += btn_visible_MouseHover;
            // 
            // lnk_register
            // 
            lnk_register.AutoSize = true;
            lnk_register.Location = new Point(20, 144);
            lnk_register.Name = "lnk_register";
            lnk_register.Size = new Size(48, 15);
            lnk_register.TabIndex = 7;
            lnk_register.TabStop = true;
            lnk_register.Text = "Kayıt Ol";
            lnk_register.LinkClicked += lnk_register_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 316);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label label2;
        private Button btn_login;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button btn_visible;
        private LinkLabel lnk_register;
    }
}
