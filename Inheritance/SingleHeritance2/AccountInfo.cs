using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SingleHeritance2
{
    public class AccountInfo:PersonalInfo
    {
        private static long s_accountNumber=91245443;
        public string AccountNumber{get;}
        public string BranchName{get;set;}
        public string IFSCCode{get;set;}
        public double Balance{get;set;}
        public int withDraw{get;set;}
        public int deposit{get;set;}

        //constructors
        public  AccountInfo(string branchName,string ifscCode,double balance,string name,string fatherName,long phoneNo,string mailID,DateTime dob,Gender gender):base(name,fatherName,phoneNo,mailID,dob,gender){
            AccountNumber="ACNo"+(++s_accountNumber);
            BranchName=branchName;
            IFSCCode=ifscCode;
            Balance=balance;
           
        }

        //methods
        public void ShowAccountInfo(){
            System.Console.WriteLine($"Name {Name}\nFather Name : {FatherName}\nPhone : {PhoneNo}\nMail ID : {MailID}\nDOB : {MailID}\nGender : {Gender}\nAccount Number  : {AccountNumber}\nBranch Name :{BranchName}\nIFSC Code : {IFSCCode}\nBalance :{Balance}");
        }
        public void Deposit(){
            System.Console.Write("Enter the deposit money : ");
            deposit=int.Parse(Console.ReadLine());
            Balance=Balance+deposit;
            System.Console.WriteLine($"Successfully Deposited and Your balance is {Balance}");

        }
        public void WithDraw(){
            System.Console.Write("Enter the amount to withdraw : ");
            withDraw=int.Parse(Console.ReadLine());
            if(withDraw>Balance){
                System.Console.WriteLine($"Your have insufficient money, and your  current balance is {Balance}");
            }
            else{
                System.Console.WriteLine($"Your Current balance after withdrawal is {Balance-withDraw}");
            }
        }

    }
}