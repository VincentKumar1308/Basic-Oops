using System;
using System.Collections.Generic;
namespace EbBill;
class Program{
    public static void Main(string[] args)
    {
        List<Calculations> Storing=new List<Calculations>();
        bool flag=true;
        
       do{
         Calculations calculate=new Calculations();
       
        System.Console.WriteLine("\n Welcome to the Electrical Board \n");
        System.Console.WriteLine("1.Registration \t2.login \t3.Exit");
        int choice=int.Parse(Console.ReadLine());
        if(choice==1){
          
           calculate.Registration();
            Storing.Add(calculate);
        }
        else if(choice==2){
         
            System.Console.WriteLine("\nWelcome to Login Page\n");
            System.Console.WriteLine("Enter your MeterID : ");
            string check=Console.ReadLine();
            foreach(Calculations Store in Storing){
                if(check==Store.MeterId){
                    flag=false;
                    
                }
                bool flag1=false;
                 do{
                System.Console.WriteLine("\n1.Calculate Amount \t2.Display UserDetails \t3.Exit");
                int choose=int.Parse(Console.ReadLine());
                    
                    switch(choose){
                        case 1:{
                            System.Console.WriteLine("Calculating Amount\n");
                            System.Console.Write("Enter the Units : ");
                            Store.UnitsUsed=int.Parse(Console.ReadLine());
                            System.Console.WriteLine("Bill ID : "+Store.BillId);
                            System.Console.WriteLine("Total Amount : "+(Store.UnitsUsed*5));   
                            break;
                        }
                        case 2:
                        {
                            System.Console.WriteLine("Displaying User Details");
                            System.Console.WriteLine("METER ID : "+Store.MeterId);
                            System.Console.WriteLine("USER NAME : "+Store.UserName);
                            System.Console.WriteLine("PHONE NUMBER : "+Store.PhoneNo);
                            System.Console.WriteLine("MAIL ID : "+Store.MailId);
                            break;
                        }
                        case 3:
                        {
                            System.Console.WriteLine("Thank You Visit Again!");
                            break;
                        }
                    }
                    System.Console.WriteLine("Do you want to continue? yes");
                    string Cons=Console.ReadLine();
                    if(Cons=="yes"){
                        flag1=true;
                    }
                   
                }while(flag1);
            }
            if(flag){
                System.Console.WriteLine("Invalid Meter ID ");
            }

        }
        else if(choice==3){
            System.Console.WriteLine("Thank You");
            break;
        }

       }while(true);
}
}
