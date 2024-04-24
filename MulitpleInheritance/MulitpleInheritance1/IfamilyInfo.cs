using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MulitpleInheritance1
{
    public interface IfamilyInfo
    {
         string FatherName{get;set;}
         string MotherName{get;set;}
         string HouseAddress{get;set;}
         int NoOfSiblings{get;set;}

        
    }
}