using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance2
{
    public class RackInfo:DepartmentDetails
    {
        private static int s_rackNumber=0;
        private static int s_columnNumber=0;
        public string RackNumber{get;}
        public string ColumnNumber{get;}


        //constructors
        public RackInfo(string departmentName,string degree):base(departmentName,degree){
            RackNumber="RACKNO"+(++s_rackNumber);
            ColumnNumber="COLNo"+(++s_columnNumber);
           
        }
       
        
    }
}