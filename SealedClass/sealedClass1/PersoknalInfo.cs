using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sealedClass1
{
    public enum Gender{Male,Female}
    public class PersonalInfo
    {

        //properities
        public string Name{get;set;}
        public string FatherName{get;set;}
        public string MobileNo{get;set;}
        public Gender Gender;

    }
}