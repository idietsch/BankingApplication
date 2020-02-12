using System;

namespace BankingApplicationLibrary {
    
    public class Account {
        public decimal Balance { get; set; }
        public string AcctNbr { get; set; }
        public string Description { get; set; }
        
        public void Deposit(decimal amount) {

        }
        public void Withdraw(decimal amount) {

        }
        public void Transfer(decimal amount, Account toAccount, Account fromAccount) {

        }

        public Account() { }
    }
}
