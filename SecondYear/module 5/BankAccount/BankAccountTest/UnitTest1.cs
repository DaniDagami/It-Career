using BankAccountNS;
using System;

namespace BankAccountTest {
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void DepositShouldAddMoney() {
            BankAccount account = new BankAccount();
            account.Deposit(50);
            account.Deposit(50);

            Assert.AreEqual(account.Balance, 100);
        }

        [TestCase(100)]
        [TestCase(500)]
        public void DepositShouldAddMoney2(int amount) {
            BankAccount account = new BankAccount();

            account.Deposit(amount);
            account.Deposit(amount);

            Assert.AreEqual(account.Balance, amount * 2);
        }

        [Test]
        public void DepositShouldThrowException() {
            BankAccount account = new BankAccount();


            Assert.Throws<InvalidOperationException>(() => account.Deposit(-50));
        }

        [Test]
        public void DepositShouldThrowExceptionWithMessage() {
            BankAccount account = new BankAccount();

            var ex = Assert.Throws<InvalidOperationException>(() => account.Deposit(-50));
            Assert.That(ex.Message == "negative amount");
        }

        [Test]
        public void WithdrawShouldRemoveMoney() {
            BankAccount account = new BankAccount(200);

            account.Withdarw(50);

            Assert.AreEqual(150, account.Balance);
        }

        [Test]
        public void WithdrawShouldRemoveMoneyExecution() {
            BankAccount account = new BankAccount(200);

            Assert.Throws<InvalidOperationException>(() => account.Withdarw(250));
        }

        [Test]
        public void AccountInitializeWithPositive() {
            BankAccount account = new BankAccount(2000);
            Assert.AreEqual(2000, account.Balance);
        }

        [Test]
        public void AccountInitializeWithNegative() {
            Assert.Throws<ArgumentException>(() => new BankAccount(-2000));
        }
    }
}