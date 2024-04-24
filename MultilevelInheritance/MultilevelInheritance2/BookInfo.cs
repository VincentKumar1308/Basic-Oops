using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance2
{
    public class BookInfo:RackInfo
    {
        //property
         private static int s_bookID=1000;
         public string BOOkID{get;}
         public  string BookName{get;set;}
         public string AuthorName{get;set;}
         public double Price{get;set;}

         //constructor
        
         public  BookInfo(string bookName,string authorName,double price,string departmentName,string degree):base(departmentName, degree){
            BOOkID="BOOKID"+(++s_bookID);
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
         }
         //methods
         public void DisplayInfo(){
            System.Console.WriteLine("---------------Displaying Info----------------------------");
            System.Console.WriteLine($"Department Name : {DepartmentName}\nDegree : {Degree}\nRack Number : {RackNumber}\nColumn Number : {ColumnNumber}\nBook ID : {BOOkID}\nBook Name : {BookName}\nAuthor Name : {AuthorName}");
         }
        
    }
}