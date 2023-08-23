using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOpgave {
    internal class UserInterface {
        BankAccount account = new BankAccount(1000);

        public void showInterface() {
            bool run = true;
            double amount = 0;
            
            while (run) {
                Console.Clear();
                Console.WriteLine("Account thingie");
                Console.WriteLine("1. Check balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Exit");
                Console.Write("> ");
                char input = Console.ReadKey().KeyChar;

                switch (input) {
                    case '1': //Check Balance
                        Console.Clear();
                        Console.WriteLine("Balance");
                        Console.WriteLine("Your current balance: " + account.ToString());
                        Console.WriteLine("press any button to continue...");
                        Console.ReadKey();
                        break;
                    case '2': //Withdraw
                        Console.Clear();
                        Console.WriteLine("Withdraw");
                        Console.Write("> ");
                        double.TryParse(Console.ReadLine(), out amount);
                        if (account.withdraw(amount)) {
                            Console.WriteLine("Succes!\nnew balance: " + account.ToString());
                        }
                        else {
                            Console.WriteLine("An error occcured while trying to withdraw");
                        }
                        Console.WriteLine("press any button to continue...");
                        Console.ReadKey();
                        break;
                    case '3': //Deposit
                        Console.Clear();
                        Console.WriteLine("Deposit");
                        Console.Write("> ");
                        double.TryParse(Console.ReadLine(), out amount);
                        if (account.deposit(amount)) {
                            Console.WriteLine("Succes!\nnew balance: " + account.ToString());
                        }
                        else {
                            Console.WriteLine("An error occcured while trying to deposit");
                        }
                        Console.WriteLine("press any button to continue...");
                        Console.ReadKey();
                        break;
                    case '4': //Exit
                        run = false;
                        break;
                    default: //Invalid choice
                        Console.WriteLine("\nNot a valid option!");
                        Console.WriteLine("press any button to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
