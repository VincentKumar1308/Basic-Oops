using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClassess2
{
    public partial class StudentInfo
    {
        public enum Gender{Male,Female,Others}
        private static int  s_studentID=100;
        public  string  StudentID{get;set;}
        public string StudentName{get;set;}
        public Gender gender{get;set;}
        public DateTime DOB{get;set;}
        public long MobileNo{get;set;}
        public int  Physics{get;set;}
        public int  Chemistry{get;set;}
        public int Maths{get;set;}
        
    }
}