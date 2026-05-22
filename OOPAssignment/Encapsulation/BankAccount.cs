using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment.Encapsulation
{
    public class BankAccount
    {
        // Private  
        private decimal _balance;
        private readonly string _pin;

        // Public properties
        public string Owner { get; }

        // Read-only balance more like a getter for the balance because its private
        public decimal Balance
        {
            get
            {
                return _balance;
            }
        }

        // Constructor
        public BankAccount(string owner, string pin, decimal initialDeposit = 0)
        {
            // Validate owner
            if (string.IsNullOrWhiteSpace(owner))
            {
                throw new ArgumentException(
                    "Owner name cannot be empty."
                );
            }

            // Validate PIN
            if (pin.Length != 4)
            {
                throw new ArgumentException(
                    "PIN must be exactly 4 digits."
                );
            }

            // Validate initial deposit
            if (initialDeposit < 0)
            {
                throw new ArgumentException(
                    "Initial deposit cannot be negative."
                );
            }

            Owner = owner;
            _pin = pin;
            _balance = initialDeposit;
        }

        // Validate PIN without exposing it
        public bool ValidatePin(string input)
        {
            //Using If staments for Comparison
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            if (_pin == input)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Deposit money
        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException(
                    "Deposit amount must be greater than zero."
                );
            }

            _balance += amount;

            Console.WriteLine(
                $"Deposit successful +R{amount}. New balance:R {_balance:R}"
            );
        }

        // Withdraw money
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException(
                    "Withdrawal amount must be greater than zero."
                );
            }

            if (amount > _balance)
            {
                throw new InvalidOperationException(
                    "Insufficient funds."
                );
            }

            _balance -= amount;

            Console.WriteLine(
                $"Withdrawal successful .-R{amount}. New balance: R{_balance}"
            );
        }
    }
}
