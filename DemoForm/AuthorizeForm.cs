using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoLib.User;

namespace DemoForm
{
    public partial class AuthorizeForm : Form
    {
        private User currentUser_ = null;
        private UserService userService_;
        public AuthorizeForm()
        {
            InitializeComponent();

            UserRepository userRepository = new UserRepository();
            userService_ = new UserService(userRepository);
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите логин");
                return;
            }

            if (!userService_.CheckLogin(loginBox.Text))
            {
                MessageBox.Show("Указанного вами логина не существует");
                return;
            }

            if (string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите пароль");
                return;
            }

            if (!userService_.Authorize(loginBox.Text, passwordBox.Text))
            {
                MessageBox.Show("Пароль неверный");
                return;
            }

            currentUser_ = userService_.Getuser(loginBox.Text);
            DialogResult = DialogResult.OK;
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public User GetCurrentUser()
        {
            return currentUser_;
        }
    }
}
