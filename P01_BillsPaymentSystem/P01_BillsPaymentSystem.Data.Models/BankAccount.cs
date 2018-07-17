

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P01_BillsPaymentSystem.Data.Models
{
    public class BankAccount
    {
        [Key]
        public int BankAccountId { get; set; }

        public decimal Balance { get; set; }

        [Required, MaxLength(50)]
        public string BankName { get; set; }

        [Required, MaxLength(20)]
        public string SwiftCode { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

    }
}
