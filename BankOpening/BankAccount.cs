using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace BankOpening
{
    public enum Gender{select,male,female,transgender}
    public class BankAccount
    {
        //filed
        private static int s_customerID=1000;
        

        //auto property
        public string CustomerID{get;}
        public string CustomerName{get;set;}
        public double Balance{get;set;}
        public long PhoneNo{get;set;}
        public string MailId{get;set;}
        public DateTime DOB{get;set;}
        public Gender Gender{get;set;}
        

        //indexers
        //constructors
        public BankAccount(){
            s_customerID++;
            CustomerID="HDFC"+s_customerID;
            Balance=0;
        }

        //Methods
        public void Deposit(){
           

            System.Console.Write("Enter the amount  to deposit ");
            double DepositMoney=double.Parse(Console.ReadLine());
             Balance=DepositMoney+Balance;
             System.Console.Write("Your balance is :"+Balance);
        }
        public void WithDraw(){
            System.Console.WriteLine("Enter the amount to withdraw");
            double WithDrawAmount=double.Parse(Console.ReadLine());
            if(Balance>WithDrawAmount){
            Balance=Balance-WithDrawAmount;
            }
            else{
                System.Console.WriteLine("you not having sufficient money");
            }
            System.Console.WriteLine("Your current balance is: "+Balance);
        }

       

    }
}