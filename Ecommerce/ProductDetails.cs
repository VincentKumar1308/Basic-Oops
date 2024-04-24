using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class ProductDetails
    {
        //fileds
        private static int s_ProductID=101;
        //auto property
        public string ProductName{get;set;}
        public int Price{get;set;}
        public int Stock{get;set;}
        public int ShippingDuration{get;set;}
        public string ProductID{get;set;}

      //methods
        public ProductDetails(string Name,int stock,int price,int duration){
            ProductName=Name;
            Price=price;
            Stock=stock;
            ShippingDuration=duration;
            ProductID="PID"+s_ProductID++;
          
    }
    }

  
}