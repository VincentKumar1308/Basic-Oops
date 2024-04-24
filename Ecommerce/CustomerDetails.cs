using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Ecommerce
{
    
    public class CustomerDetails
    {
        private static int s_CustomerID=1000;
        //autoproperty
        public string CustomerID{get;set;}
        public string Name{get;set;}
        public string City{get;set;}
        public long PhoneNO{get;set;}
        public  string MailID{get;set;}
        public int WalletBalance{get;set;}

        //constructors
        public  CustomerDetails(string name,string city,long number,string mail,int balance){
            s_CustomerID++;
            CustomerID="CID"+s_CustomerID;
            Name=name;
            City=city;
            PhoneNO=number;
            MailID=mail;
            WalletBalance=balance;

           
        }
        public void walletBalance(){
            System.Console.WriteLine("Your current balance is : "+WalletBalance);

        }
        public void WalletRecharge(){
            System.Console.WriteLine("Do you want to recharge? yes");
            string RechargeOption=Console.ReadLine();
            if(RechargeOption.ToLower()=="yes"){
                System.Console.Write("Enter the  amount to Recharge  :");
                int recharge=int.Parse(Console.ReadLine());
                WalletBalance=WalletBalance+recharge;
                System.Console.WriteLine("Your wallet balance after recharge is : "+WalletBalance);
            }
        }


       
    }
}