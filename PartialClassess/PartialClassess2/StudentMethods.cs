using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClassess2
{
    public partial class StudentInfo
    {
        public void Total(){
            int total=Physics+Chemistry+Maths;
            System.Console.WriteLine("The  toatl marks is : "+total);
        }
        public void Percentage(){
            double percentage=(double)(Physics+Chemistry+Maths)/3.0;
            System.Console.WriteLine("The percentage of the student is : "+percentage);
        }
    }
}