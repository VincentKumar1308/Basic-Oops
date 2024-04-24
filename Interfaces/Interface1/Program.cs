using System;
namespace Interface1;
class Program{
    public static void Main(string[] args)
    {
        Dog dog=new Dog("Pomerian","house","vegetraian");
        dog.DisplayInfo();
        Duck duck =new Duck("Indian Duck","water","fish");
        duck.DisplayInfo();
    }
}