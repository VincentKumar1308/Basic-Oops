using System;
namespace MultilevelInheritance2;
class Program{
    public static void Main(string[] args)
    {
        BookInfo book=new BookInfo("BLACK PEARL","JACKSPARROW",20000,"ADVENTURE","JOURNALISM");
        book.DisplayInfo();
         BookInfo book1=new BookInfo("BCONTROL SYSTEM","WILLSPIN",12000,"UWIN","MATURITY");
         BookInfo book2=new BookInfo("ELECTRONICS PHYSICS ","VINCENT",5000,"ELECTRICAL","ELECTRICITY");
         book1.DisplayInfo();
         book2.DisplayInfo();

    }
}