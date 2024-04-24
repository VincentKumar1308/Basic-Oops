using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EbBill
{
    public class Calculations
    {
        //field
        private static int s_MeterId=1000;
         private static int s_BillId=1020;
            
        
        //autoproperty
        public string MeterId{get;}
        public string BillId{get;}
        public string UserName{get;set;}
        public long PhoneNo{get;set;}
        public string MailId{get;set;}
        public double UnitsUsed{get;set;}

        //indexers
        //constructors
        public Calculations(){
            UnitsUsed=0;
            s_MeterId++;
            MeterId="EB"+s_MeterId;
            s_BillId++;
            BillId="EBBILL"+s_BillId;

        }
        //deconstructors

        //methods
        public void CalculateAmount(){
            System.Console.Write("Enter the no of units used: ");
            UnitsUsed=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Bill ID: "+BillId);
            System.Console.WriteLine("User Name: "+UserName);
            System.Console.WriteLine("Units Used:"+UnitsUsed);
            System.Console.WriteLine("Total Amount: "+(UnitsUsed*5));

        }
        public void Registration(){
         
            System.Console.WriteLine("Registration Page");
            System.Console.Write("Name: ");
            UserName=Console.ReadLine();
            System.Console.Write("Phone Number: ");
            PhoneNo=long.Parse(Console.ReadLine());
            System.Console.Write("Enter your MailID : ");
            MailId=Console.ReadLine();
            System.Console.WriteLine("Registration Successful");
            System.Console.WriteLine("Your Meter ID : "+MeterId);

        }
        
        
        }

    }
