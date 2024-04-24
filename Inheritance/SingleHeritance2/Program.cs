using System;
using System.Collections.Generic;
namespace SingleHeritance2;
class Program{
    public static void Main(string[] args)
    {
        List<AccountInfo> accountInfoList=new List<AccountInfo>();
        AccountInfo account=new AccountInfo("West Mambalam","HDFC2003GH1",5000,"Vincent","Joseph",93611982,"vincent@gmail.com",new DateTime(2000,11,12),Gender.Male);
        AccountInfo account1=new AccountInfo("West Thambaram","SBI1023RD",3500,"MUGESJ","Vengat",09711982,"vincent@gmail.com",new DateTime(2000,01,24),Gender.Male);
        AccountInfo account2=new AccountInfo(" Paris","CORP14DN4",7000,"dhoni","Joseph",675432,"hgfd@gmail.com",new DateTime(1900,11,12),Gender.Male);
        accountInfoList.AddRange(new List<AccountInfo>{account,account1,account2});
        foreach(AccountInfo accountInfo in accountInfoList){
            //account info
            System.Console.WriteLine("-------------------");
            accountInfo.ShowAccountInfo();
        }

        foreach(AccountInfo accountInfo in accountInfoList){
           //Deposit
            System.Console.WriteLine("-------------------");
            accountInfo.Deposit();
        }

        foreach(AccountInfo accountInfo in accountInfoList){
            //withdraw
            System.Console.WriteLine("-------------------");
            accountInfo.WithDraw();
        }
        

    }
}