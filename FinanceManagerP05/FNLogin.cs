using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbClass;
using Models;

namespace FinanceManagerP05
{
    public partial class FNLogin : Form
    {
        private Repository repository;

        public FNLogin()
        {
            InitializeComponent();

            repository = new Repository();
        }
        private void AddUser(User user)
        {
            repository.AddUser(user);
        }
        private List<User> GetAllUsers()
        {
            return repository.GetAllUsers();
        }
        private void DeleteUser(User user)
        {
            repository.DeleteUser(user);
        }
        private void UpdateUser(User user)
        {
            repository.UpdateUser(user);
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;

            // Создание нового объекта User
            User newUser = new User
            {
                Login = username,
            };

            // Вызов метода AddUser из репозитория
            var repository = new Repository();
            repository.AddUser(newUser);

            MessageBox.Show("Пользователь успешно добавлен!");
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string accountName = accountNameTextBox.Text;

            // Вызов метода LoginToAccount из репозитория
            var repository = new Repository();
            bool success = repository.LoginToAccount(accountName);

            if (success)
            {
                MessageBox.Show("Вход выполнен успешно!");
            }
            else
            {
                MessageBox.Show("Не удалось выполнить вход. Проверьте имя аккаунта.");
            }
        }


    }
}
