using System;
namespace HierarchialInheritance1;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Teacher Details");
        Teacher teacher1=new Teacher("ECE","elctronic communication","B.E",2024,12,"Vincent","Joseph",new DateTime(2000,12,12),"vincent@gmail.com",Gender.Male);
        Teacher teacher2=new Teacher("EEE","electrical department","M.E",2021,21,"sudha","Venkat",new DateTime(2001,11,11),"sudha@gmail.com",Gender.Femle);
        Teacher teacher3=new Teacher("CSE","Computer Department","B.E",2018,22,"mukesh","vetri",new DateTime(1989,12,12),"mukesh@gmail.com",Gender.Male);
        teacher1.ShowDetails();
        teacher2.ShowDetails();
        teacher3.ShowDetails();
        System.Console.WriteLine("Student Details");
        StudentInfo student=new StudentInfo("BE","ECE","first","Sudha","Devaraj",new DateTime(2002,03,19),"sudha@gmail.com",Gender.Femle);
        StudentInfo student1=new StudentInfo("MBBS","Cardiology","second","Vineeth","Kaprov",new DateTime(2000,11,30),"vineeth@gmail.com",Gender.Male);
        StudentInfo student2=new StudentInfo("B.Arts","Science","third","Praveen","Prakash",new DateTime(2004,03,19),"praveen@gmail.com",Gender.Femle);
        student.ShowDetails();
        student1.ShowDetails();
        student2.ShowDetails();
        System.Console.WriteLine("Principal Details");
        PrincipalInfo pirncipal=new PrincipalInfo("Msc Maths",7,13,"Vincent","Joseph",new DateTime(2014,11,15),"vincent@gmail.com",Gender.Male);
        PrincipalInfo pirncipal2=new PrincipalInfo("M.E Psycology",6,15,"SUDHA","NAGARAJ",new DateTime(2015,11,15),"sudha@gmail.com",Gender.Femle);
        PrincipalInfo pirncipal3=new PrincipalInfo("B.sc Zoology",8,31,"Vignesh","Shankar",new DateTime(2019,10,16),"vicky@gmail.com",Gender.Male);
        pirncipal.ShowDetails();
        pirncipal2.ShowDetails();
        pirncipal3.ShowDetails();

     

    }
}