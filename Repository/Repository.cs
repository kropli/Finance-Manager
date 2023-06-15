using DataBaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Models;
using System.Security.Principal;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace DbClass
{
    public class Repository
    {
        DbContextOptions<AppDbContext> options;
        public Repository()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string DBPath = config["DBPath"];

            options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlite($"Data Source={DBPath}")
                .Options;
        }

        public void AddWallet(Wallet wallet)
        {
            using (var db = new AppDbContext(options))
            {
                db.Wallets.Add(wallet);
                db.SaveChanges();
            }
        }

        public void RemoveWallet(Wallet wallet)
        {
            using (var db = new AppDbContext(options))
            {
                db.Wallets.Remove(wallet);
                db.SaveChanges();
            }
        }

        public List<Wallet> GetAllWallets()
        {
            using (var db = new AppDbContext(options))
            {
                return db.Wallets.ToList();
            }
        }

        public bool LoginToAccount(string accountName)
        {
            using (var db = new AppDbContext(options))
            {
                var account = db.Accounts.FirstOrDefault(x => x.User.Login == accountName);
                if (account != null)
                {
                    // Выполнение входа в аккаунт
                    // ...
                    return true;
                }
            }

            return false;
        }

        public void RemoveExpenseCategory(string category)
        {
            using (var db = new AppDbContext(options))
            {
                var expenseCategory = db.ExpenceCategories.FirstOrDefault(x => x.Category == category);
                if (expenseCategory != null)
                {
                    db.ExpenceCategories.Remove(expenseCategory);
                    db.SaveChanges();
                }
            }
        }

        public List<ExpenceCategory> GetAllExpenseCategories()
        {
            using (var db = new AppDbContext(options))
            {
                return db.ExpenceCategories.ToList();
            }
        }

        public List<IncomeSource> GetAllIncomeSources()
        {
            using (var db = new AppDbContext(options))
            {
                return db.IncomeSources.ToList();
            }
        }

        public void AddUser(User user)
        {
            using (var db = new AppDbContext(options))
            {
                try
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                catch (DbUpdateException ex)
                {
                    Exception innerException = ex.InnerException;
                    // Обработайте внутреннее исключение для получения подробностей об ошибке
                    // например, innerException.Message
                }
            }
        }

        public void AddIncomeSource(string source)
        {
            using (var db = new AppDbContext(options))
            {
                IncomeSource incomeSource = new IncomeSource { Source = source };
                db.IncomeSources.Add(incomeSource);
                db.SaveChanges();
            }
        }

        public void RemoveIncomeSource(string source)
        {
            using (var db = new AppDbContext(options))
            {
                IncomeSource incomeSource = db.IncomeSources.FirstOrDefault(s => s.Source == source);
                if (incomeSource != null)
                {
                    db.IncomeSources.Remove(incomeSource);
                    db.SaveChanges();
                }
            }
        }

        public void AddCurrency(Currency currency)
        {
            using (var db = new AppDbContext(options))
            {
                db.Currencies.Add(currency);
                db.SaveChanges();
            }
        }

        public void AddExpenseCategory(string category)
        {
            using (var db = new AppDbContext(options))
            {
                db.ExpenceCategories.Add(new ExpenceCategory { Category = category });
                db.SaveChanges();
            }
        }

        public void AddAccount(Account account)
        {
            using (var db = new AppDbContext(options))
            {
                db.Accounts.Add(account);
                db?.SaveChanges();
            }
        }

        public Account GetAccount(int id)
        {
            using (var db = new AppDbContext(options))
            {
                return db.Accounts.FirstOrDefault(x => x.Id == id);
            }
        }

        public List<Account> GetAllAccounts()
        {
            using (var db = new AppDbContext(options))
            {
                return db.Accounts.ToList();
            }
        }

        public Income GetIncome(int id)
        {
            using (var db = new AppDbContext(options))
            {
                return db.Incomes.FirstOrDefault(x => x.Id == id);
            }
        }

        public List<Income> GetAllIncomes()
        {
            using (var db = new AppDbContext(options))
            {
                return db.Incomes.ToList();
            }
        }

        public Expence GetExpence(int id)
        {
            using (var db = new AppDbContext(options))
            {
                return db.Expences.FirstOrDefault(x => x.Id == id);
            }
        }

        public List<Expence> GetAllExpences()
        {
            using (var db = new AppDbContext(options))
            {
                return db.Expences.ToList();
            }
        }

        public Currency GetCurrency(int id)
        {
            using (var db = new AppDbContext(options))
            {
                return db.Currencies.FirstOrDefault(x => x.Id == id);
            }
        }

        public Currency GetCurrency(string title)
        {
            using (var db = new AppDbContext(options))
            {
                return db.Currencies.FirstOrDefault(x => x.Title == title);
            }
        }

        public List<Currency> GetAllCurrencies()
        {
            using (var db = new AppDbContext(options))
            {
                return db.Currencies.ToList();
            }
        }

        public User GetUser(int id)
        {
            using (var db = new AppDbContext(options))
            {
                return db.Users.FirstOrDefault(x => x.Id == id);
            }
        }

        public List<User> GetAllUsers()
        {
            using (var db = new AppDbContext(options))
            {
                return db.Users.ToList();
            }
        }

        public void DeleteUser(User user)
        {
            using (var db = new AppDbContext(options))
            {
                db.Users.Remove(user);
                db?.SaveChanges();
            }
        }

        public void DeleteAccount(Account account)
        {
            using (var db = new AppDbContext(options))
            {
                db.Accounts.Remove(account);
                db?.SaveChanges();
            }
        }

        public void DeleteCurrency(Currency currency)
        {
            using (var db = new AppDbContext(options))
            {
                db.Currencies.Remove(currency);
                db?.SaveChanges();
            }
        }

        public void UpdateUser(User user)
        {
            using (var db = new AppDbContext(options))
            {
                var updatingUser = db.Users.First(x => x.Id == user.Id);
                updatingUser.Login = user.Login;
                updatingUser.Password = user.Password;
                db?.SaveChanges();
            }
        }

        public void UpdateIncome(Income income)
        {
            using (var db = new AppDbContext(options))
            {
                var updatingIncome = db.Incomes.First(x => x.Id == income.Id);
                updatingIncome.Description = income.Description;
                updatingIncome.AccountId = income.AccountId;
                updatingIncome.Amount = income.Amount;
                updatingIncome.Date = income.Date;
                db?.SaveChanges();
            }
        }

        public void UpdateExpence(Expence expence)
        {
            using (var db = new AppDbContext(options))
            {
                var updatingExpence = db.Expences.First(x => x.Id == expence.Id);
                updatingExpence.Description = expence.Description;
                updatingExpence.AccountId = expence.AccountId;
                updatingExpence.Amount = expence.Amount;
                updatingExpence.Date = expence.Date;
                db?.SaveChanges();
            }
        }

        public void UpdateAccount(Account account)
        {
            using (var db = new AppDbContext(options))
            {
                var updatingAccount = db.Accounts.First(x => x.Id == account.Id);
                updatingAccount.UserId = account.UserId;
                updatingAccount.CurrencyId = account.CurrencyId;
                updatingAccount.Balance = account.Balance;
                db?.SaveChanges();
            }
        }
    }
}
