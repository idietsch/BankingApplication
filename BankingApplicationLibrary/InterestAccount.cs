﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplicationLibrary {
    public class InterestAccount : Account {

        public decimal InterestRate { get; private set; }

        public void CalcInterest(int Months) {
            var interest = this.Balance * (this.InterestRate / 12) * Months;
            this.Deposit(interest);
        }


        public override string ToString() {
            return $"{base.ToString()}, Interest Rate: {InterestRate}";
        }

        public InterestAccount(double interestRate) : this() {
            InterestRate = Convert.ToDecimal(interestRate);
        }
        public InterestAccount() : base() {
            this.Description = "Interest Account";
        }
    }
}
