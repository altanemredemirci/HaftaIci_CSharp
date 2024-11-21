using System.Diagnostics;

namespace _19_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            if (username == "admin" && password == "ab18")
            {
                MessageBox.Show("Giriþ Baþarýlý");
            }
            else
            {
                MessageBox.Show("Giriþ Bilgileriniz Hatalý!!");
                txt_username.Text = "";
                txt_password.Clear();
            }
        }

        private void sifreGoster()
        {
            if (txt_password.PasswordChar == '*')
                txt_password.PasswordChar = '\0';
            else
                txt_password.PasswordChar = '*';
        }

        private void btn_visible_MouseHover(object sender, EventArgs e)
        {
            sifreGoster();
        }

        private void btn_visible_MouseLeave(object sender, EventArgs e)
        {
            sifreGoster();
        }

        private void lnk_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
    }
}
