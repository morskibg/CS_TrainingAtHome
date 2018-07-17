using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using Microsoft.EntityFrameworkCore;
using P01_BillsPaymentSystem.Data;
using P01_BillsPaymentSystem.Data.Models;
using P01_BillsPaymentSystem.Data.Models.Enums;

namespace P01_BillsPaymentSystem
{
    public class StartUp
    {
        public static void Main()
        {
            using (var dbContext = new BillsPaymentSystemContext())
            {
                //dbContext.Database.EnsureDeleted();
                //dbContext.Database.EnsureCreated();
                //dbContext.Database.Migrate();
                Seed(dbContext);
                
                 

            }


        }

        private static bool IsValid(object obj)
        {
            var validationContext = new ValidationContext(obj);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(obj, validationContext, results, true);
            return isValid;
        }
        private static void Seed(BillsPaymentSystemContext db)
        {
            using (db)
            {
                var user = new User()
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Email = "vando@gmail.com",
                    Password = "12345"
                };
                
                var creditCards = new CreditCard[]
                    {
                         new CreditCard
                         {
                            ExpirationDate =  DateTime.ParseExact("12/03/2005", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                            Limit = 20000m,
                            MoneyOwed = 1000m
                         },

                        new CreditCard
                        {
                            ExpirationDate =  DateTime.ParseExact("24/01/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                            Limit = 1000m,
                            MoneyOwed = 200m
                        }

                    };

                var bankAccount = new BankAccount()
                {
                    Balance = 1600m,
                    BankName = "UNICREDIT",
                    SwiftCode = "UNIC"
                };

                var paymentMethods = new PaymentMethod[]
                    {
                        new PaymentMethod()
                        {
                            UserId = 1,
                            CreditCardId = 0,
                            PaymentType = PaymentType.CreditCard
                        },

                        new PaymentMethod()
                        {
                            UserId = 1,
                            //CreditCardId = 1,
                            PaymentType = PaymentType.CreditCard
                        },

                        new PaymentMethod()
                        {
                            UserId = 1,
                            CreditCardId = 0,
                            BankAccountId = 1,
                            PaymentType = PaymentType.BankAccount
                        }
                        
                    };
                foreach (var pm in paymentMethods)
                {
                    Console.WriteLine(IsValid(pm));
                }
                
                db.Users.Add(user);
                db.CreditCards.AddRange(creditCards);
                db.BankAccounts.Add(bankAccount);
                db.PaymentMethods.AddRange(paymentMethods);

                //db.SaveChanges();
            }
        }
    }
}
