using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualFunction1
{
    public class VolumeCalculator:AreaCalculator
    {
        public double Height{get;set;}

        //constructors
        public VolumeCalculator(double height,double radius):base(radius){
            Height=height;
        }

        //methods
        public override double VirtualCalculate(){
            double Volume=3.14*Radius*Radius*Height;
            return Volume;
        }

    }
}