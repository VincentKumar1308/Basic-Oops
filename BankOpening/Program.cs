using System;
using System.Collections.Generic;
using BankOpening;
namespace bankOpening;
class Program{
    public static void Main(string[] args)
    {
        List<BankAccount> BankStore=new List<BankAccount>();
        bool flag=true;
       
        do{
       
        Console.WriteLine("\n1.Registration 2.Login 3.Exit");
        bool check=int.TryParse(Console.ReadLine(),null,out int choice);
        
        while(!check){
            Console.WriteLine("Please enter the correct choice");
            Console.WriteLine("1.Registration \n2.Login \n3.Exit");
            check=int.TryParse(Console.ReadLine(),null,out  choice);
        }

            if(choice==1){
                 BankAccount bank=new BankAccount();
                 System.Console.WriteLine("Enter your name: ");
                 bank.CustomerName=Console.ReadLine();
                 System.Console.WriteLine("Select your Gender: 1.male 2. female 3.Transgender ");
                 int genderValue=int.Parse(Console.ReadLine());
                 bank.Gender=(Gender)genderValue;
                 System.Console.WriteLine("Enter your phone no: ");
                 bank.PhoneNo=long.Parse(Console.ReadLine());
                 System.Console.Write("Enter your mailID: ");
                 bank.MailId=Console.ReadLine();
                 System.Console.WriteLine("Enter your date of birth in the format of dd/MM/yyyy");
                 bank.DOB=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                 System.Console.WriteLine("The account created succcessfully and your CUSTOMERID is: "+bank.CustomerID);
                 System.Console.WriteLine("Enter the initial amount  to deposit");
                 bank.Deposit();  
                 BankStore.Add(bank);
            }

            if(choice==2){
               {
                System.Console.WriteLine("Enter your Customer ID: ");
                string id=Console.ReadLine();
                foreach (BankAccount student in BankStore){
                    if(id==student.CustomerID){
                        flag=false;
                        System.Console.WriteLine("1.Deposit 2.Withdraw 3.Balance 4.Exit");
                        int choose=int.Parse(Console.ReadLine());
                        if(choose==1){
                            student.Deposit();
                        }
                        else if(choose==2){
                            student.WithDraw();
                        }
                        else if(choose==3){
                            System.Console.WriteLine("Your balance is: "+student.Balance);
                        }
                        else if(choose==4){
                            break;
                        }
                    }
                    
                    
                }
                if(flag){
                   
                        System.Console.WriteLine("Invalid user ID");
                    
                }
                }
            }
           
             
          
        
        }while(true);
        
    }
}