using DataBaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Models;
using System.Security.Principal;

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

        //Add
        public void AddUser(User user)
        {
            using (var db = new AppDbContext(options))
            {
                db.Users.Add(user);
                db?.SaveChanges();
            }
        }
        public void AddCurrency(Currency currency)
        {
            using (var db = new AppDbContext(options))
            {
                db.Currencies.Add(currency);
                db?.SaveChanges();
            }
        }

        public void AddIncome(Income income)
        {
            using (var db = new AppDbContext(options))
            {
                db.Incomes.Add(income);
                db?.SaveChanges();
            }
        }

        public void AddExpence(Expence spending)
        {
            using (var db = new AppDbContext(options))
            {
                db.Expences.Add(spending);
                db?.SaveChanges();
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

        //Get
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

        //Delete
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

        public void DeleteIncome(Income income)
        {
            using (var db = new AppDbContext(options))
            {
                db.Incomes.Remove(income);
                db?.SaveChanges();
            }
        }

        public void DeleteExpence(Expence expence)
        {
            using (var db = new AppDbContext(options))
            {
                db.Expences.Remove(expence);
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

        //Update
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
                var updatingIncome = db.Incomes.First(x => x.Id ==income.Id);
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