using System;

namespace BankingApplicationLibrary {
    
    public abstract class Account {
        private static int NextAcctNbr = 1;
        private const int AcctNbrInct = 9;

        public decimal Balance { get; set; }
        public int AcctNbr { get; private set; }
        public string Description { get; set; } = "Amount";

        private int AttemptsToOverdraw = 0;

        private bool CheckAmountGTZero(decimal amount) {
            return (amount <= 0) ? false : true;               
        }
        private bool IsSufficientFunds(decimal amount) {
            if (Balance >= amount) {
                return true;
            }
            AttemptsToOverdraw++;
            return false;
        }
        


        public void Deposit(decimal amount) {
            if (CheckAmountGTZero(amount)) {
            Balance += amount;
            }
        }
        public bool Withdraw(decimal amount) {
            if(CheckAmountGTZero(amount) && IsSufficientFunds(amount)) {
            Balance -= amount;
                return true;
            }
            return false;
        }
        public void Transfer(decimal amount, Account toAccount) {
            if (this.Withdraw(amount)) {
                toAccount.Deposit(amount);
            }
        }

        public override string ToString() {
            return $"Account Number: {AcctNbr}, Desc: {Description}, Balance: {Balance}";
        }

        public Account() {
            this.AcctNbr = NextAcctNbr;
            NextAcctNbr += AcctNbrInct;
        }
        public void Debug() {
            Console.WriteLine(this);
        }
    }
}
