using System;
namespace HybridInheritance1;
class Program{
    public static void Main(string[] args)
    {
        MarkSheet marksheet1=new MarkSheet( new DateTime(2000,11,16),new int[] {10,98,100,78,69,67},new int[]{10,45,65,76,86,98} ,new int[]{76,77,87,98,46,56},new int[]{87,45,67,89,77,45} ,90,"vincent","joseph",9361198268,2000,Gender.Male);
        marksheet1.ShowUGMarkSheet();
        MarkSheet marksheet2=new MarkSheet( new DateTime(2005,11,30),new int[] {65,68,80,88,69,67},new int[]{50,45,65,76,86,68} ,new int[]{76,77,87,98,46,56},new int[]{45,65,67,59,47,45} ,80,"mukesh","venkat",9150716,2010,Gender.Male);
        marksheet2.ShowUGMarkSheet();
    }
}