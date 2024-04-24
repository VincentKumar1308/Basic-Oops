using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualFunction1
{
    public class AreaCalculator
    {
        public double Radius{get;set;}

        //constructors
        public AreaCalculator(double radius){
            Radius=radius;
        }

        //methods
        public virtual double VirtualCalculate(){
            double Area=3.14*Radius*Radius;
            return Area;
        }
    }
}