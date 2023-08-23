using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOpgave {
    public class BankAccount {
        private double balance;

        public BankAccount(double balance = 0) {
            this.balance = balance;
        }

        public bool withdraw(double amount) {
            if (amount <= 0 || balance - amount < 0) { return false; }

            balance -= amount;
            return true;
        }

        public bool deposit(double amount) {
            if (amount <= 0) {  return false; }

            balance += amount;
            return true;
        }

        public override string ToString() { 
            return balance.ToString();
        }
    }
}
