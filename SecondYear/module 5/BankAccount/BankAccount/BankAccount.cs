using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountNS {
    public class BankAccount {

        private int balance;
        public int Balance {
            get { return balance; }
            set {
                if(value < 0) throw new ArgumentException("negative amount");
                balance = value;
            }
        }
        public BankAccount(int amount) {
            this.Balance = amount;
        }
        public BankAccount() { }

        public void Deposit(int amount) {
            if(amount < 0) {
                throw new InvalidOperationException("negative amount");
            }
            this.Balance += amount;
        }
        public void Withdarw(int amount) {
            if(amount < 0) {
                throw new InvalidOperationException("negative amount");
            } else if(this.Balance <= amount) {
                throw new InvalidOperationException("withdrawing to much money");
            }
            this.Balance -= amount;
        }
    }
}
