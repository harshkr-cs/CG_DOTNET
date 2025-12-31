using System;
namespace BankingSystem{
    class BankAccount{
        public string AccountNumber {get; private set;}
        public decimal Balance {get; private set;}

        public BankAccount(string AccountNumber,decimal initialBalance){
               if(!string.IsNullOrWhiteSpace(AccountNumber)){
                throw new ArgumentException("Account no. can't have space or null");
               }
               if(initialBalance<0){
                throw new ArgumentException(nameof(initialBalance),"Account no. can't have space or null");
               }
               this.AccountNumber=AccountNumber;
               this.Balance=initialBalance;
        }
    }
}