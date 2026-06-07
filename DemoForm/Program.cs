using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoLib.User;

namespace DemoForm
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AuthorizeForm authorizeForm = new AuthorizeForm();
            if (authorizeForm.ShowDialog() == DialogResult.OK)
            {
                User user = authorizeForm.GetCurrentUser();
                Application.Run(new MainForm(user));
            }
        }
    }
}
