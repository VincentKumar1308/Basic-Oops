using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchialInheritance2
{
    public class SalaryInfo
    {
        public double BasicSalary{get;set;}
        public int Month{get;set;}

        //constructors
        public SalaryInfo(double basicSalary,int month){
            BasicSalary=basicSalary;
            Month=month;
        }
        

    }
}