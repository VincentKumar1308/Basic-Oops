using System;
namespace classCollegeAdmission;
class Program{
    public static void Main(string[] args)
    {
        FileHandling.Create();
        Operation.AddDefaultData();
        Operation.MainMenu();
        FileHandling.WriteToCSV();
    }
}