using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sealedClass1
{
    public class Hack:EmployeeInfo  //error occurs due to because of the sealed class, class which all sealed cannot be inherited
    {
        //properties
        private static int s_storeUserID=1000;
        public string  StorePassword{get;set;}

        //methods
        public void ShowKeyInfo(){
            System.Console.WriteLine($"Keyinformation "+EmployeeInfo.KeyInfo);
        }
        public void GetUserInfo(){
            System.Console.Write("Enter the name : ");
           string name=Console.ReadLine();
           System.Console.Write("Enter the father Name : ");
          string fatherName=Console.ReadLine(); 
          System.Console.Write("Enter the mobile  number : ");
          string mobile=Console.ReadLine();
          System.Console.Write("Enter your Gender  : ");
          Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        }
        public void ShowUserInfo(){
            
        }
        
    }
}