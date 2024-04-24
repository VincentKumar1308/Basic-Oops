using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sealedClass1
{
    public sealed class EmployeeInfo
    {
        private static int s_userID=100;
        public string UserID{get;set;}
        public string Password{get;set;}
        public string KeyInfo{get;set;}

        public EmployeeInfo(string passoword,string keyInfo){
            Password=passoword;
            KeyInfo=keyInfo;
        }

        //methods
        public void UpdateInfo(){
            System.Console.Write("Enter the new passoword : ");
            string passoword=Console.ReadLine();
            Password=passoword;
        }
        public void DisplayInfo(){
            System.Console.WriteLine("Usaer Id : "+UserID+" Password : "+Password+" KeyInfo : "+KeyInfo);

        }
    }
}