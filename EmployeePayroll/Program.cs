using System;
using System.Collections.Generic;
namespace EmployeePayroll;
 class Program{
    public static void Main(string[] args)
    {
      //creating list
      List<Payroll> EmployeStore=new List<Payroll>();

      System.Console.WriteLine("\nEmployee Payroll Management\n");
      //main menu
      do{
        Payroll EmployeePay=new Payroll();
      System.Console.WriteLine("1.Registration   2.Login   3.Exit");
      int choice=int.Parse(Console.ReadLine());
      bool  flag2=false;
      do{
        switch(choice){
          case 1:{
            System.Console.WriteLine("\nRegistration");
            EmployeePay.Registration();
            EmployeStore.Add(EmployeePay);
            break;
          }
          case 2:
          {
            System.Console.WriteLine("\nLogin Page");
             System.Console.WriteLine("Enter your Employee ID : ");
            string ID=Console.ReadLine();
            bool flag=true;
            bool  flag1=false;
            foreach(Payroll Pay in EmployeStore){
              if(ID==Pay.EmployeeID){
                flag=false;
                do{
                  System.Console.WriteLine("1. Calculate salary  2. Display Details  3. Exit");
                  int choose=int.Parse(Console.ReadLine());
                  switch(choose){
                    case 1:
                    {
                      System.Console.WriteLine("Calculating Salary\n");
                      System.Console.WriteLine("Your Salary is : "+((Pay.WorkingDays-Pay.NoOfLeave)*500));
                      break;
                    }
                    case 2:
                    {
                      System.Console.WriteLine("\n2.Display Details\n");
                      Pay.Display();
                      break;
                    }
                    case 3:{
                      Console.WriteLine("Thank You ");
                      break;
                    }
                  } 
                  System.Console.WriteLine("\nDo you  want to continue in submenu(current salary details ? yes");
                  string Cons=Console.ReadLine();
                  if(Cons=="yes"){
                    flag1=true;
                  } 
                  else{
                    flag1=false;
                  }               
                }while(flag1);
              }
            }
            if(flag){
              System.Console.WriteLine("Invalid User ID ");
            }

            break;
          }
          case 3:{
            System.Console.WriteLine("Thank you visit Again!");
            break;
          }
        }
        System.Console.WriteLine("\nDo you want to return to main menu? yes");
        string Continue=Console.ReadLine();
        if(Continue=="yes"){
          flag2=true;
        }

      }while(!flag2);

      }while(true);

        
    }
 
 }