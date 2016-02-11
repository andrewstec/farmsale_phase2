using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Organic_Launch;

namespace WebApplication1.Models
{
    public class AccountRepo
    {
        public IEnumerable<Account> GetAllAccounts()
        {
            FarmSaleDBEntities1 db = new FarmSaleDBEntities1();
            return db.Accounts.ToList();
        }

        public Account GetAccount(int id)
        {
            FarmSaleDBEntities1 db = new FarmSaleDBEntities1();
            Account account = db.Accounts.Where(a => a.accountID == id).FirstOrDefault();
            return account;
        }

        //Need to add encryption to password
        public void AddAccount(string username, string password, string email, string accountType)
        {
            FarmSaleDBEntities1 db = new FarmSaleDBEntities1();

            Account account = new Account();
            account.username = username;
            account.password = password;//Add encryption? Do we need this field?
            account.email = email;
            account.accountType = accountType;

            db.Accounts.Add(account);
            db.SaveChanges();
        }

        public void RemoveAccount(int id)
        {
            FarmSaleDBEntities1 db = new FarmSaleDBEntities1();
            Account account = db.Accounts.Where(a => a.accountID == id).FirstOrDefault();
            db.Accounts.Remove(account);
            db.SaveChanges();
        }

        public void UpdateAccount(int id, string username, string password, string email, string accountType)
        {
            FarmSaleDBEntities1 db = new FarmSaleDBEntities1();
            Account account = db.Accounts.Where(a => a.accountID == id).FirstOrDefault();
            if (account != null)
            {
                account.username = username;
                account.password = password;//Do we need this here?
                account.email = email;
                //Not sure if necessary
                //account.accountType = accountType;
                db.SaveChanges();
            }
        }
    }
}