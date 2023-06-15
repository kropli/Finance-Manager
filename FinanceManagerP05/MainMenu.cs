using DbClass;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManagerP05
{
    public partial class MainMenu : Form
    {
        private readonly Repository repository;

        public MainMenu()
        {
            InitializeComponent();
            repository = new Repository();
        }

        // Метод для загрузки всех Wallets из базы данных в ListBox
        private void LoadWallets()
        {
            List<Wallet> wallets = repository.GetAllWallets();

            // Очистка ListBox перед загрузкой данных
            walletsListBox.Items.Clear();

            // Добавление каждого Wallet в ListBox
            foreach (var wallet in wallets)
            {
                walletsListBox.Items.Add(wallet.Name);
            }
        }

        // Метод для загрузки всех Currency из базы данных в ListBox
        private void LoadCurrencies()
        {
            List<Currency> currencies = repository.GetAllCurrencies();

            // Очистка ListBox перед загрузкой данных
            currenciesListBox.Items.Clear();

            // Добавление каждой Currency в ListBox
            foreach (var currency in currencies)
            {
                currenciesListBox.Items.Add(currency.Title);
            }
        }

        // Обработчик события загрузки формы MainMenu
        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Вызов методов для загрузки данных в ListBox при загрузке формы
            LoadWallets();
            LoadCurrencies();
            LoadExpenseCategories();
            LoadIncomeSources();
        }

        // Обработчик события кнопки для добавления категории расходов
        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            string category = categoryTextBox.Text;

            repository.AddExpenseCategory(category);

            MessageBox.Show("Категория расходов успешно добавлена!");

            // Обновление ListBox после добавления категории
            LoadExpenseCategories();
        }

        // Обработчик события кнопки для удаления категории расходов
        private void RemoveCategoryButton_Click(object sender, EventArgs e)
        {
            if (expenseCategoriesListBox.SelectedItem != null)
            {
                string category = expenseCategoriesListBox.SelectedItem.ToString();

                repository.RemoveExpenseCategory(category);

                MessageBox.Show("Категория расходов успешно удалена!");

                // Обновление ListBox после удаления категории
                LoadExpenseCategories();
            }
        }

        // Обработчик события кнопки для добавления источника дохода
        private void AddSourceButton_Click(object sender, EventArgs e)
        {
            string source = sourceTextBox.Text;

            repository.AddIncomeSource(source);

            MessageBox.Show("Источник дохода успешно добавлен!");

            // Обновление ListBox после добавления источника
            LoadIncomeSources();
        }

        // Обработчик события кнопки для удаления источника дохода
        private void RemoveSourceButton_Click(object sender, EventArgs e)
        {
            if (incomeSourcesListBox.SelectedItem != null)
            {
                string source = incomeSourcesListBox.SelectedItem.ToString();

                repository.RemoveIncomeSource(source);

                MessageBox.Show("Источник дохода успешно удален!");

                // Обновление ListBox после удаления источника
                LoadIncomeSources();
            }
        }

        // Метод для загрузки всех категорий расходов из базы данных в ListBox
        private void LoadExpenseCategories()
        {
            List<ExpenceCategory> categories = repository.GetAllExpenseCategories();

            expenseCategoriesListBox.Items.Clear();

            foreach (var category in categories)
            {
                expenseCategoriesListBox.Items.Add(category.Category);
            }
        }

        // Метод для загрузки всех источников дохода из базы данных в ListBox
        private void LoadIncomeSources()
        {
            List<IncomeSource> sources = repository.GetAllIncomeSources();

            incomeSourcesListBox.Items.Clear();

            foreach (var source in sources)
            {
                incomeSourcesListBox.Items.Add(source.Source);
            }
        }
    }
}
