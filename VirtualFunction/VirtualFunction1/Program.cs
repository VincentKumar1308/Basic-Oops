using System;
namespace VirtualFunction1;
class Program{
    public static void Main(string[] args)
    {

        //objects for the volume
        VolumeCalculator volume =new VolumeCalculator(12.5,13);
        System.Console.WriteLine("Volume : "+volume.VirtualCalculate());

        //objects for the area
        AreaCalculator area=new AreaCalculator(14);
        System.Console.WriteLine("Area  : "+area.VirtualCalculate());

    }
}