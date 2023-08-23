namespace XUnitTestBankAccount {
    public class UnitTest1 {
        [Fact]
        public void WithdrawTests() {
            BankAccount b = new BankAccount(1000);

            //Normal withdraws
            Assert.True(b.withdraw(100));
            Assert.True(b.ToString() == "900"); 
            Assert.True(b.withdraw(200));
            Assert.True(b.ToString() == "700"); 

            //Withdrawing negative numbers
            Assert.True(!b.withdraw(-500));
            Assert.True(b.ToString() == "700"); 

            //Withdrawing more than account holds
            Assert.True(!b.withdraw(1000));
            Assert.True(b.ToString() == "700");

            //Withdrawing zero
            Assert.True(!b.withdraw(0));
            Assert.True(b.ToString() == "700");
        }

        [Fact]
        public void DepositTests() {
            BankAccount b = new BankAccount(1000);

            //Normal deposits
            Assert.True(b.deposit(100));
            Assert.True(b.ToString() == "1100");
            Assert.True(b.deposit(200));
            Assert.True(b.ToString() == "1300");

            //Depositing negative numbers
            Assert.True(!b.deposit(-500));
            Assert.True(b.ToString() == "1300");

            //Depositing zero
            Assert.True(!b.withdraw(0));
            Assert.True(b.ToString() == "1300");
        }
    }
}